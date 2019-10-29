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
            if (this.textBox1.Text!="")
                 {
                comboBoxKategori.Items.Add(this.textBox1.Text);
                this.textBox1.Focus();
                this.textBox1.Clear();
            } else {

                
            }
         }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

