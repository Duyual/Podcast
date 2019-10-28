using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_Models
{
    public class Podcast
    {
        public string Title { get; set; }
        List<Episode> Episodes { get; set; }

        public Podcast()
        {
            Episodes = new List<Episode>();
        }
    }
}
