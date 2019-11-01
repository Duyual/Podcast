using Podcast_Models;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_DAL.RSS
{
    public class JsonReader
    {
        public JsonReader()
        {

        }

        public PodcastCollection GetPodcasts()
        {
            PodcastCollection podColl = new PodcastCollection();
            return podColl.Deserialize();
        }

        public PodcastCollection GetPodcasts(string category)
        {
            PodcastCollection podColl = new PodcastCollection();
            podColl = podColl.Deserialize();

            List<Podcast> podcasts = (from pods in podColl
                                      where pods.Category.Equals(category)
                                      select pods).ToList();

            PodcastCollection podCollCategory = new PodcastCollection();
            foreach (Podcast pod in podcasts)
            {
                podCollCategory.Add(pod);
            }

            return podCollCategory;
        }
    }
}
