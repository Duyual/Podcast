using Podcast_DAL.RSS;
using Podcast_Models;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Podcast_BLL
{
    public class PodcastHandler
    {

        //Används för test
        public async void fetchPodcasts()
        {
            PodcastReader pr = new PodcastReader();
            //Podcast joerog = await pr.ReadPodcastRSS("http://joeroganexp.joerogan.libsynpro.com/rss");
            Podcast ajt = await pr.ReadPodcastRSS("http://feeds.soundcloud.com/users/soundcloud:users:118147039/sounds.rss?fbclid=IwAR0UHQZF3GhpNmuazs4-Kw7K6--IzB0AZjQQ-4QqKOmCKqQqeGi6xdMweQo");
            //joerog.UpdateInterval = 5;
            ajt.UpdateInterval = 2;
            PodcastCollection podColl = new PodcastCollection();
            //podColl.Add(joerog);
            podColl.Add(ajt);
            Debug.WriteLine(podColl[0].UpdateInterval);
            podColl.Serialize();
        }

        public async void AddPodcast(string link, string category, int update)
        {
            PodcastReader pr = new PodcastReader();
            Podcast newPod = await pr.ReadPodcastRSS(link);
            newPod.UpdateInterval = update;
            newPod.Category = category;
            PodcastCollection podColl = new PodcastCollection();
            podColl = podColl.Deserialize();
            podColl.Add(newPod);
            podColl.Serialize();
        }

        public async Task UpdatePodcast(Podcast pod, string link, string category, int update)
        {
            PodcastReader pr = new PodcastReader();
            Podcast newPod = await pr.ReadPodcastRSS(link);
            newPod.UpdateInterval = update;
            newPod.Category = category;
            PodcastCollection podColl = new PodcastCollection();
            podColl = podColl.Deserialize();
            int index = podColl.FindIndex(item => item.Equals(pod));
            podColl[index] = newPod;
            podColl.Serialize();
        }

        public void StartUpdateFeed()
        {
            PodcastCollection podColl = new PodcastCollection();
            podColl = podColl.Deserialize();
            //Add update interval
            if (podColl != null)
            {
                List<Task> tasks = new List<Task>();
                foreach (Podcast pod in podColl)
                {
                    Debug.WriteLine("periodic started");
                    Debug.WriteLine(pod.UpdateInterval);
                    tasks.Add(PeriodicUpdateFeed(podColl, pod, new CancellationToken()));
                }
            }

        }

        public async Task PeriodicUpdateFeed(PodcastCollection podcastColl, Podcast podcast, CancellationToken canceltoken)
        {
            TimeSpan ts = new TimeSpan(0, podcast.UpdateInterval, 0);
            PodcastReader pr = new PodcastReader();
            int oldIndex = 0;
            //Remember where in the list the podcast is.
            for (int i = 0; i < podcastColl.Count; i++)
            {
               if (podcastColl[i].Equals(podcast))
               {
                    oldIndex = i;
               }
            }
            Podcast oldPod = podcastColl[oldIndex];

            //Async delen
            while (true)
            {
                Debug.WriteLine(podcast.Link);
                Podcast newPod = await pr.ReadPodcastRSS(podcast.Link);

                //If the podcast isn't the same, change it.
                if (!newPod.Equals(oldPod))
                {
                    int updateInterval = oldPod.UpdateInterval;
                    podcastColl[oldIndex] = newPod;
                    podcastColl[oldIndex].UpdateInterval = updateInterval;
                    //INSERT UPDATEINTERVAL INTO podcastColl[oldIndex] HERE FROM FORM
                    podcastColl.Serialize();
                }

                await Task.Delay(ts, canceltoken);
            }
        }
    }
}
