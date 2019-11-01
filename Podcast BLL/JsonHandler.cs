using Podcast_DAL.RSS;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_BLL
{
    public class JsonHandler
    {
        private JsonReader reader;

        public JsonHandler()
        {
            reader = new JsonReader();
        }

        public PodcastCollection FetchPodcasts()
        {
            return reader.GetPodcasts();
        }

        public PodcastCollection FetchPodcasts(string category)
        {
            return reader.GetPodcasts(category);
        }

        public void SavePodcasts(PodcastCollection podColl)
        {
            podColl.Serialize();
        }
    }
}
