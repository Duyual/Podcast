using Podcast_BLL;
using Podcast_Models;
using Podcast_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast_GUI
{
    public partial class PodcastForm : Form
    {

        private PodcastCollection podcasts;
        private Podcast selectedPod;

        public PodcastForm()
        {
            InitializeComponent();

            PodcastHandler podHandler = new PodcastHandler();
            podHandler.StartUpdateFeed();
            //Get data from file
            podcasts = new PodcastCollection();
            podcasts = podcasts.Deserialize();
            AddPodcasts();
            //RemovePodcasts();
            //Update UI
            UpdateUI();

        }

        public async Task UpdateUI()
        {
            while (true)
            {
                await Task.Delay(new TimeSpan(0, 0, 5));
                PodcastCollection pod = new PodcastCollection();
                pod = pod.Deserialize();

                //If new changes to podcast file
                if (!pod.Equals(podcasts))
                {
                    RemovePodcasts();
                    AddPodcasts();
                }
            }
        }

        public void AddPodcasts()
        {
            foreach(Podcast pod in podcasts)
            {
                string[] row = new string[4];
                row[0] = pod.Title;
                row[3] = pod.UpdateInterval.ToString();
                foreach(Episode episode in pod.Episodes)
                {
                    row[1] = episode.Title;
                    gwdPodcasts.Rows.Add(row);
                }
            }
        }

        public void RemovePodcasts()
        {
            gwdPodcasts.Rows.Clear();
        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Podcast pod in podcasts)
            {
                Debug.WriteLine(gwdPodcasts.SelectedRows[0].ToString());
                if (pod.Title.Equals(gwdPodcasts.SelectedRows[0].ToString()))
                {

                }
            }
            
        }
    }
}
