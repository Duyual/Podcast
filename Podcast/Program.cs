﻿using Podcast_BLL;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast_GUI
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
            PodcastHandler ph = new PodcastHandler();
            //ph.fetchPodcasts();
            Application.Run(new PodcastForm());
        }
    }
}
