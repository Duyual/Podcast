namespace Podcast_GUI
{
    partial class PodcastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodcastForm));
            this.lblUrl = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblPodcastInfo = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.btnNewPodcast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemovePodcast = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnTaBort2 = new System.Windows.Forms.Button();
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.gwdPodcasts = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSpara2 = new System.Windows.Forms.Button();
            this.listBoxPodcasts = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gwdPodcasts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUrl.Location = new System.Drawing.Point(67, 153);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(105, 58);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            this.lblUrl.Click += new System.EventHandler(this.lblUrl_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.Location = new System.Drawing.Point(26, 220);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(191, 27);
            this.textBoxUrl.TabIndex = 3;
            // 
            // comboBoxUpdate
            // 
            this.comboBoxUpdate.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUpdate.FormattingEnabled = true;
            this.comboBoxUpdate.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "30",
            "60"});
            this.comboBoxUpdate.Location = new System.Drawing.Point(26, 456);
            this.comboBoxUpdate.Name = "comboBoxUpdate";
            this.comboBoxUpdate.Size = new System.Drawing.Size(191, 44);
            this.comboBoxUpdate.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(26, 328);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(191, 40);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // lblPodcastInfo
            // 
            this.lblPodcastInfo.AutoSize = true;
            this.lblPodcastInfo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastInfo.Location = new System.Drawing.Point(295, 785);
            this.lblPodcastInfo.Name = "lblPodcastInfo";
            this.lblPodcastInfo.Size = new System.Drawing.Size(274, 32);
            this.lblPodcastInfo.TabIndex = 8;
            this.lblPodcastInfo.Text = "Podcast information";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategory.Location = new System.Drawing.Point(18, 834);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(222, 33);
            this.textBoxCategory.TabIndex = 12;
            // 
            // btnNewPodcast
            // 
            this.btnNewPodcast.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPodcast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewPodcast.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNewPodcast.FlatAppearance.BorderSize = 0;
            this.btnNewPodcast.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPodcast.Location = new System.Drawing.Point(62, 518);
            this.btnNewPodcast.Name = "btnNewPodcast";
            this.btnNewPodcast.Size = new System.Drawing.Size(120, 45);
            this.btnNewPodcast.TabIndex = 13;
            this.btnNewPodcast.Text = "Ny";
            this.btnNewPodcast.UseVisualStyleBackColor = false;
            this.btnNewPodcast.Click += new System.EventHandler(this.btnNewPodcast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(64, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRemovePodcast.FlatAppearance.BorderSize = 0;
            this.btnRemovePodcast.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePodcast.Location = new System.Drawing.Point(62, 619);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(120, 45);
            this.btnRemovePodcast.TabIndex = 15;
            this.btnRemovePodcast.Text = "Ta Bort";
            this.btnRemovePodcast.UseVisualStyleBackColor = true;
            this.btnRemovePodcast.Click += new System.EventHandler(this.btnRemovePodcast_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.FlatAppearance.BorderSize = 0;
            this.btnNewCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCategory.Location = new System.Drawing.Point(12, 886);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(53, 36);
            this.btnNewCategory.TabIndex = 18;
            this.btnNewCategory.Text = "Ny";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.FlatAppearance.BorderSize = 0;
            this.btnTaBort2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBort2.Location = new System.Drawing.Point(161, 886);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(89, 36);
            this.btnTaBort2.TabIndex = 20;
            this.btnTaBort2.Text = "Ta bort";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.ItemHeight = 18;
            this.listBoxDescription.Location = new System.Drawing.Point(301, 825);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(250, 94);
            this.listBoxDescription.TabIndex = 21;
            this.listBoxDescription.SelectedIndexChanged += new System.EventHandler(this.listBox12_SelectedIndexChanged);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 25;
            this.listBoxCategory.Location = new System.Drawing.Point(18, 740);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(222, 79);
            this.listBoxCategory.TabIndex = 23;
            // 
            // gwdPodcasts
            // 
            this.gwdPodcasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwdPodcasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAvsnitt,
            this.colCategory,
            this.colFrequence});
            this.gwdPodcasts.Location = new System.Drawing.Point(278, 19);
            this.gwdPodcasts.Name = "gwdPodcasts";
            this.gwdPodcasts.RowHeadersWidth = 51;
            this.gwdPodcasts.Size = new System.Drawing.Size(570, 705);
            this.gwdPodcasts.TabIndex = 24;
            this.gwdPodcasts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwdPodcasts_CellContentClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Namn";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colAvsnitt
            // 
            this.colAvsnitt.HeaderText = "Avsnitt";
            this.colAvsnitt.MinimumWidth = 6;
            this.colAvsnitt.Name = "colAvsnitt";
            this.colAvsnitt.Width = 125;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Kategori";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 125;
            // 
            // colFrequence
            // 
            this.colFrequence.HeaderText = "Frekvens";
            this.colFrequence.MinimumWidth = 6;
            this.colFrequence.Name = "colFrequence";
            this.colFrequence.Width = 125;
            // 
            // btnSpara2
            // 
            this.btnSpara2.FlatAppearance.BorderSize = 0;
            this.btnSpara2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpara2.Location = new System.Drawing.Point(71, 886);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(86, 36);
            this.btnSpara2.TabIndex = 19;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            // 
            // listBoxPodcasts
            // 
            this.listBoxPodcasts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPodcasts.FormattingEnabled = true;
            this.listBoxPodcasts.ItemHeight = 19;
            this.listBoxPodcasts.Location = new System.Drawing.Point(593, 825);
            this.listBoxPodcasts.Name = "listBoxPodcasts";
            this.listBoxPodcasts.Size = new System.Drawing.Size(233, 99);
            this.listBoxPodcasts.TabIndex = 25;
            this.listBoxPodcasts.SelectedIndexChanged += new System.EventHandler(this.listBoxPodcasts_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTaBort2);
            this.panel1.Controls.Add(this.textBoxCategory);
            this.panel1.Controls.Add(this.btnSpara2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNewCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxCategory);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Controls.Add(this.textBoxUrl);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.comboBoxUpdate);
            this.panel1.Controls.Add(this.btnNewPodcast);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRemovePodcast);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 960);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.gwdPodcasts);
            this.panel2.Controls.Add(this.listBoxPodcasts);
            this.panel2.Controls.Add(this.listBoxDescription);
            this.panel2.Controls.Add(this.lblPodcastInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 960);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "\"never miss a podcast\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 58);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 58);
            this.label3.TabIndex = 19;
            this.label3.Text = "Intervall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 691);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 46);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kategorier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(673, 785);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Följer";
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(862, 960);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodcastForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gwdPodcasts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxUpdate;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblPodcastInfo;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button btnNewPodcast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemovePodcast;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnTaBort2;
        private System.Windows.Forms.ListBox listBoxDescription;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.DataGridView gwdPodcasts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequence;
        private System.Windows.Forms.Button btnSpara2;
        private System.Windows.Forms.ListBox listBoxPodcasts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

