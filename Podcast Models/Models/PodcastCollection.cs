using Newtonsoft.Json;
using Podcast_Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_Models.Models
{
    public class PodcastCollection : List<Podcast>, ISerialize<PodcastCollection>
    {
        public PodcastCollection()
        {

        }
        public PodcastCollection Deserialize()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader("podcast.json"))
            {
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    return serializer.Deserialize<PodcastCollection>(jsonReader);
                }
            }
        }

        public void Serialize()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter writer = new StreamWriter("podcast.json"))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jsonWriter, this);
                }
            }
        }
    }
}
