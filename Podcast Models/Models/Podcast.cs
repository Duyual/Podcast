using Podcast_Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Podcast_Models
{
    public class Podcast
    {
        public string Title { get; set; }
        public List<Episode> Episodes { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
        //Minutes
        public int UpdateInterval { get; set; }

        public Podcast()
        {
            Episodes = new List<Episode>();
        }

        public override bool Equals(object obj)
        {
            Podcast podcast = obj as Podcast;
            if (podcast != null)
            {
                if (this.Episodes.Count != podcast.Episodes.Count || this.Title != podcast.Title)
                    return false;
                for (int i = 0; i < this.Episodes.Count; i++)
                {
                    if (this.Episodes[i].Title != podcast.Episodes[i].Title
                        || this.Episodes[i].Description != podcast.Episodes[i].Description)
                        return false;
                }
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
