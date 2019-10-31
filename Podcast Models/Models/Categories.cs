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
    public class Categories : List<string>, ISerialize<Categories>
    {

        public Categories Deserialize()
        {
            CreateFileIfNotExists("categories.json");
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader("categories.json"))
            {
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    return serializer.Deserialize<Categories>(jsonReader);
                }
            }
        }

        public void CreateFileIfNotExists(string filename)
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
        }

        public void Serialize()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter writer = new StreamWriter("categories.json"))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jsonWriter, this);
                }
            }
        }
    }
}
