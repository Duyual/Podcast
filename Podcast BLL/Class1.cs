using Podcast_DAL.RSS;
using Podcast_Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast_BLL
{
    public class Class1
    {
        public async void fetchPodcast()
        {
            PodcastReader pr = new PodcastReader();
            Podcast joerog = await pr.readPodcastRSS("http://joeroganexp.joerogan.libsynpro.com/rss");
        }
    }
}
