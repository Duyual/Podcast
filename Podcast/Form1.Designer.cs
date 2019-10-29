namespace Podcast
{
    partial class Podcast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podcast));
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblIntervall = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxUppdatering = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnEpisode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrekvens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPodcastInfo = new System.Windows.Forms.Label();
            this.lblKategori2 = new System.Windows.Forms.Label();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.btnNy = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.labelPodBeskrivning = new System.Windows.Forms.Label();
            this.btnNy2 = new System.Windows.Forms.Button();
            this.btnSpara2 = new System.Windows.Forms.Button();
            this.btnTaBort2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(28, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(38, 16);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            // 
            // lblIntervall
            // 
            this.lblIntervall.AutoSize = true;
            this.lblIntervall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervall.Location = new System.Drawing.Point(388, 18);
            this.lblIntervall.Name = "lblIntervall";
            this.lblIntervall.Size = new System.Drawing.Size(63, 16);
            this.lblIntervall.TabIndex = 1;
            this.lblIntervall.Text = "Intervall";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(229, 18);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(66, 16);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(31, 49);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(154, 20);
            this.textBoxUrl.TabIndex = 3;
            // 
            // comboBoxUppdatering
            // 
            this.comboBoxUppdatering.FormattingEnabled = true;
            this.comboBoxUppdatering.Location = new System.Drawing.Point(391, 48);
            this.comboBoxUppdatering.Name = "comboBoxUppdatering";
            this.comboBoxUppdatering.Size = new System.Drawing.Size(83, 21);
            this.comboBoxUppdatering.TabIndex = 4;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(232, 48);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(102, 21);
            this.comboBoxKategori.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEpisode,
            this.ColumnNamn,
            this.ColumnFrekvens,
            this.ColumnKategori});
            this.dataGridView1.Location = new System.Drawing.Point(31, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 82);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColumnEpisode
            // 
            this.ColumnEpisode.HeaderText = "Episode";
            this.ColumnEpisode.Name = "ColumnEpisode";
            // 
            // ColumnNamn
            // 
            this.ColumnNamn.HeaderText = "Namn";
            this.ColumnNamn.Name = "ColumnNamn";
            // 
            // ColumnFrekvens
            // 
            this.ColumnFrekvens.HeaderText = "Frekvens";
            this.ColumnFrekvens.Name = "ColumnFrekvens";
            // 
            // ColumnKategori
            // 
            this.ColumnKategori.HeaderText = "Kategori";
            this.ColumnKategori.Name = "ColumnKategori";
            // 
            // lblPodcastInfo
            // 
            this.lblPodcastInfo.AutoSize = true;
            this.lblPodcastInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastInfo.Location = new System.Drawing.Point(28, 229);
            this.lblPodcastInfo.Name = "lblPodcastInfo";
            this.lblPodcastInfo.Size = new System.Drawing.Size(145, 16);
            this.lblPodcastInfo.TabIndex = 8;
            this.lblPodcastInfo.Text = "Podcast information";
            // 
            // lblKategori2
            // 
            this.lblKategori2.AutoSize = true;
            this.lblKategori2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori2.Location = new System.Drawing.Point(526, 229);
            this.lblKategori2.Name = "lblKategori2";
            this.lblKategori2.Size = new System.Drawing.Size(80, 16);
            this.lblKategori2.TabIndex = 9;
            this.lblKategori2.Text = "Kategorier";
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(529, 372);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(222, 20);
            this.textBoxKategori.TabIndex = 12;
            // 
            // btnNy
            // 
            this.btnNy.Location = new System.Drawing.Point(31, 193);
            this.btnNy.Name = "btnNy";
            this.btnNy.Size = new System.Drawing.Size(80, 23);
            this.btnNy.TabIndex = 13;
            this.btnNy.Text = "Ny";
            this.btnNy.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(139, 193);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(74, 23);
            this.btnSpara.TabIndex = 14;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(246, 193);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(88, 23);
            this.btnTaBort.TabIndex = 15;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // labelPodBeskrivning
            // 
            this.labelPodBeskrivning.AutoSize = true;
            this.labelPodBeskrivning.Location = new System.Drawing.Point(526, 21);
            this.labelPodBeskrivning.Name = "labelPodBeskrivning";
            this.labelPodBeskrivning.Size = new System.Drawing.Size(35, 13);
            this.labelPodBeskrivning.TabIndex = 17;
            this.labelPodBeskrivning.Text = "label1";
            // 
            // btnNy2
            // 
            this.btnNy2.Location = new System.Drawing.Point(529, 415);
            this.btnNy2.Name = "btnNy2";
            this.btnNy2.Size = new System.Drawing.Size(53, 23);
            this.btnNy2.TabIndex = 18;
            this.btnNy2.Text = "Ny";
            this.btnNy2.UseVisualStyleBackColor = true;
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(606, 415);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(58, 23);
            this.btnSpara2.TabIndex = 19;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(688, 415);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(63, 23);
            this.btnTaBort2.TabIndex = 20;
            this.btnTaBort2.Text = "Ta bort";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 261);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 95);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox12_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(529, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(222, 121);
            this.listBox2.TabIndex = 22;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(529, 261);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(222, 95);
            this.listBox3.TabIndex = 23;
            // 
            // Podcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTaBort2);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnNy2);
            this.Controls.Add(this.labelPodBeskrivning);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnNy);
            this.Controls.Add(this.textBoxKategori);
            this.Controls.Add(this.lblKategori2);
            this.Controls.Add(this.lblPodcastInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.comboBoxUppdatering);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblIntervall);
            this.Controls.Add(this.lblUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Podcast";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblIntervall;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxUppdatering;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEpisode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrekvens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKategori;
        private System.Windows.Forms.Label lblPodcastInfo;
        private System.Windows.Forms.Label lblKategori2;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.Button btnNy;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label labelPodBeskrivning;
        private System.Windows.Forms.Button btnNy2;
        private System.Windows.Forms.Button btnSpara2;
        private System.Windows.Forms.Button btnTaBort2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

