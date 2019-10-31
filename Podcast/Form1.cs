using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast
{
    public partial class Podcast : Form
    {
        public Podcast()
        {
            InitializeComponent();
        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNy2_Click(object sender, EventArgs e)
        {
            if (this.textBoxKategori.Text != "")
            {
                listBox3.Items.Add(this.textBoxKategori.Text);
                comboBoxKategori.Items.Add(this.textBoxKategori.Text);
                this.textBoxKategori.Focus();
                this.textBoxKategori.Clear();
            } else {


            }
        }

        private void textBoxKategori_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
