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
            Podcast joerog = await pr.ReadPodcastRSS("http://joeroganexp.joerogan.libsynpro.com/rss");
            Podcast ajt = await pr.ReadPodcastRSS("https://feeds.megaphone.fm/ADL9840290619");
            joerog.UpdateInterval = 5;
            ajt.UpdateInterval = 2;
            PodcastCollection podColl = new PodcastCollection();
            podColl.Add(joerog);
            podColl.Add(ajt);
            Debug.WriteLine(podColl[0].UpdateInterval);
            podColl.Serialize();
        }

        public void StartUpdateFeed()
        {
            PodcastCollection podColl = new PodcastCollection();
            podColl = podColl.Deserialize();
            //Add update interval
            List<Task> tasks = new List<Task>();
            foreach (Podcast pod in podColl)
            {
                Debug.WriteLine("periodic started");
                Debug.WriteLine(pod.UpdateInterval);
                tasks.Add(PeriodicUpdateFeed(podColl, pod, new CancellationToken()));
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
                    podcastColl[oldIndex] = newPod;
                    //INSERT UPDATEINTERVAL INTO podcastColl[oldIndex] HERE FROM FORM
                    podcastColl.Serialize();
                }

                await Task.Delay(ts, canceltoken);
            }
        }
    }
}
