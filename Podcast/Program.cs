using Podcast_BLL;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PodcastHandler podHandler = new PodcastHandler();
            podHandler.StartUpdateFeed();
            Application.Run(new Podcast());
        }
    }
}
