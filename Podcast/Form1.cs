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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
         }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNy2_Click(object sender, EventArgs e)
        {
            if (this.textBoxKategori.Text != "")
            {
                comboBoxKategori.Items.Add(this.textBoxKategori.Text);
                richTextBoxKategori.Items.Add(this.textBoxKategori.Text);
                this.textBoxKategori.Focus();
                this.textBoxKategori.Clear();
            }
            else
            {


            }
        }

        private void comboBoxKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBoxKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

