using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Podcast_Models;

namespace Podcast_DAL.RSS
{
    public class PodcastReader
    {
        public PodcastReader()
        {

        }

        public async Task<Podcast> ReadPodcastRSS(string url)
        {
            Podcast podcast = new Podcast();
            podcast.Link = url;
            List<Episode> episodes = new List<Episode>();

            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.Async = true;

            using (XmlReader reader = XmlReader.Create(url, xrs))
            {
                reader.ReadToFollowing("channel");
                while (await reader.ReadAsync())
                {
                    if (reader.IsStartElement())
                    {
                        //If podcast title is read
                        if (reader.Name.Equals("title"))
                        {
                            podcast.Title = reader.ReadElementContentAsString();
                        }

                        //If item is read
                        if (reader.Name.Equals("item"))
                        {
                            XmlReader itemReader = reader.ReadSubtree();

                            Episode episode = new Episode();

                            //Save data to episode
                            while (await itemReader.ReadAsync())
                            {
                                if (itemReader.IsStartElement())
                                {
                                    switch (itemReader.Name)
                                    {
                                        case "title":
                                            episode.Title = itemReader.ReadElementContentAsString();
                                            break;
                                        case "description":
                                            episode.Description = itemReader.ReadElementContentAsString();
                                            break;
                                    }
                                }

                            }
                            //Add episode to list
                            episodes.Add(episode);
                        }
                    }
                }
            }
            podcast.Episodes = episodes;
            return podcast;
        }
    }
}
