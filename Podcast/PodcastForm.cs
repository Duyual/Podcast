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
        CategoryHandler categoryHandler;

        public PodcastForm()
        {
            InitializeComponent();

            PodcastHandler podHandler = new PodcastHandler();
            categoryHandler = new CategoryHandler();

            podHandler.StartUpdateFeed();
            //Get data from file
            podcasts = new PodcastCollection();
            podcasts = podcasts.Deserialize();
            if (podcasts != null)
            {
                AddPodcastsUI();
                //Update UI
                UpdateUI();
            }

            AddCategoriesUI();

        }

        public async Task UpdateUI()
        {
            while (true)
            {
                await Task.Delay(new TimeSpan(0, 0, 5));
                PodcastCollection pod = new PodcastCollection();
                pod = pod.Deserialize();

                if (pod != null)
                {
                    //If new changes to podcast file
                    if (!pod.Equals(podcasts))
                    {
                        //Change podcast
                        podcasts = pod;
                        RemovePodcastsUI();
                        AddPodcastsUI();
                    }
                }
            }
        }

        public void AddPodcastsUI()
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

        public void RemovePodcastsUI()
        {
            gwdPodcasts.Rows.Clear();
        }

        public void AddCategoriesUI()
        {
            Categories categories = categoryHandler.fetchCategories();
            if (categories != null)
            {
                foreach (string category in categories)
                {
                    //ListBox
                    listBoxCategory.Items.Add(category);
                    //ComboBox
                    comboBoxCategory.Items.Add(category);
                }

            }
        }

        public void AddCategoryUI(string category)
        {
            listBoxCategory.Items.Add(category);
            comboBoxCategory.Items.Add(category);
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

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            if (textBoxCategory.Text != "")
            {
                //If added
                if (categoryHandler.addCategory(textBoxCategory.Text))
                {
                    AddCategoryUI(textBoxCategory.Text);
                }
            }
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
