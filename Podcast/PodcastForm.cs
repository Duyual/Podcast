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
        private PodcastHandler podHandler;
        private JsonHandler jsonHandler;
        private CategoryHandler categoryHandler;

        public PodcastForm()
        {
            InitializeComponent();
            //this.Scale(new SizeF(1f, 0.9f));

            podHandler = new PodcastHandler();
            jsonHandler = new JsonHandler();
            categoryHandler = new CategoryHandler();

            podHandler.StartUpdateFeed();
            //Get data from file
            podcasts = jsonHandler.FetchPodcasts();

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
                        RemoveEpisodesUI();
                        UpdatePodcastsUI();
                        //AddEpisodesUI(selectedPod);
                    }
                }
            }
        }

        public void AddPodcastsUI()
        {
            foreach (Podcast pod in podcasts)
            {
                listBoxPodcasts.DisplayMember = "Title";
                listBoxPodcasts.Items.Add(pod);
            }
        }

        public void UpdatePodcastsUI()
        {
            int selectedIndex = listBoxPodcasts.SelectedIndex;
            listBoxPodcasts.Items.Clear();
            AddPodcastsUI();
            if(listBoxPodcasts.Items.Count > selectedIndex)
                listBoxPodcasts.SelectedIndex = selectedIndex;
        }

        public void UpdateEpisodesUI(Podcast pod)
        {
            RemoveEpisodesUI();
            AddEpisodesUI(pod);
        }

        public void AddEpisodesUI(Podcast pod)
        {
            string[] row = new string[4];
            row[0] = pod.Title;
            row[2] = pod.Category;
            row[3] = pod.UpdateInterval.ToString();
            foreach (Episode episode in pod.Episodes)
            {
                row[1] = episode.Title;
                gwdPodcasts.Rows.Add(row);
            }
        }

        public void RemoveEpisodesUI()
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

        public void UpdatePodcastData(Podcast pod)
        {
            textBoxUrl.Text = pod.Link;
            comboBoxUpdate.SelectedItem = pod.UpdateInterval.ToString();
            comboBoxCategory.SelectedItem = pod.Category;
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

        private void listBoxPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-1 = Out of bounds
            if (listBoxPodcasts.SelectedIndex != -1)
            {
                Podcast pod = listBoxPodcasts.SelectedItem as Podcast;
                UpdateEpisodesUI(pod);
                UpdatePodcastData(pod);
            }
        }

        private void btnNewPodcast_Click(object sender, EventArgs e)
        {
            string link = textBoxUrl.Text;
            string category = comboBoxCategory.SelectedItem.ToString();

            if (!IsEmptyOrNull(link) && !IsEmptyOrNull(category) && !IsEmptyOrNull(comboBoxUpdate.SelectedItem.ToString()))
            {
                int update = Int32.Parse(comboBoxUpdate.SelectedItem.ToString());
                podHandler.AddPodcast(link, category, update);
                UpdatePodcastsUI();
            }
        }

        public bool IsEmptyOrNull(string str)
        {
            return (str == null || str == String.Empty) ? true : false;
        }

        private void btnRemovePodcast_Click(object sender, EventArgs e)
        {
            Podcast removedPod = listBoxPodcasts.SelectedItem as Podcast;
            //listBoxPodcasts.Items.Remove(removedPod);
            podcasts.Remove(removedPod);
            podcasts.Serialize();
            UpdatePodcastsUI();
            

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Podcast changedPod = listBoxPodcasts.SelectedItem as Podcast;
            int index = podcasts.FindIndex(pod => pod.Equals(changedPod));

            string category = comboBoxCategory.SelectedItem.ToString();
            string link = textBoxUrl.Text;
            int update = Int32.Parse(comboBoxUpdate.SelectedItem.ToString());

            await podHandler.UpdatePodcast(changedPod, link, category, update);
            PodcastCollection podColl = new PodcastCollection();
            podcasts = podColl.Deserialize();
            UpdatePodcastsUI();
        }

        private void lblUrl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gwdPodcasts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
