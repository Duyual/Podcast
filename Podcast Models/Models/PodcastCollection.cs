﻿using Newtonsoft.Json;
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
            CreateFileIfNotExists("podcast.json");
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader("podcast.json"))
            {
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {
                    return serializer.Deserialize<PodcastCollection>(jsonReader);
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
            using (StreamWriter writer = new StreamWriter("podcast.json"))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jsonWriter, this);
                }
            }
        }

        public override bool Equals(object obj)
        {
            PodcastCollection podcasts = obj as PodcastCollection;
            if (podcasts == null || this == null)
                return false;
            if (podcasts.Count != this.Count)
                return false;

            for (int i = 0; i < this.Count; i++)
            {
                if (!this[i].Equals(podcasts[i]))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
