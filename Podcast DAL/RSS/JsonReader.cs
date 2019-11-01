using Podcast_Models.Models;
using System;
using System.Collections.Generic;
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

            return podColl.Where(p => p.Category.Equals(category))
                .Select(p => p)
                .ToList() as PodcastCollection;
        }
    }
}
