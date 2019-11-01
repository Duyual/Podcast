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
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamReader reader = new StreamReader("categories.json"))
                {
                    using (JsonReader jsonReader = new JsonTextReader(reader))
                    {
                        return serializer.Deserialize<Categories>(jsonReader);
                    }
                }
            } catch(FileNotFoundException)
            {
                return null;
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
