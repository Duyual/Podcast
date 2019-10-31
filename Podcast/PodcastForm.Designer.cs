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
            this.lblIntervall = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblPodcastInfo = new System.Windows.Forms.Label();
            this.lblKategori2 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.btnNewPodcast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemovePodcast = new System.Windows.Forms.Button();
            this.labelPodBeskrivning = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.gwdPodcasts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(28, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(46, 20);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            // 
            // lblIntervall
            // 
            this.lblIntervall.AutoSize = true;
            this.lblIntervall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervall.Location = new System.Drawing.Point(388, 18);
            this.lblIntervall.Name = "lblIntervall";
            this.lblIntervall.Size = new System.Drawing.Size(76, 20);
            this.lblIntervall.TabIndex = 1;
            this.lblIntervall.Text = "Intervall";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(229, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(31, 49);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(154, 20);
            this.textBoxUrl.TabIndex = 3;
            // 
            // comboBoxUpdate
            // 
            this.comboBoxUpdate.FormattingEnabled = true;
            this.comboBoxUpdate.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "30",
            "60"});
            this.comboBoxUpdate.Location = new System.Drawing.Point(391, 48);
            this.comboBoxUpdate.Name = "comboBoxUpdate";
            this.comboBoxUpdate.Size = new System.Drawing.Size(83, 21);
            this.comboBoxUpdate.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(232, 48);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(102, 21);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // lblPodcastInfo
            // 
            this.lblPodcastInfo.AutoSize = true;
            this.lblPodcastInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastInfo.Location = new System.Drawing.Point(27, 336);
            this.lblPodcastInfo.Name = "lblPodcastInfo";
            this.lblPodcastInfo.Size = new System.Drawing.Size(177, 20);
            this.lblPodcastInfo.TabIndex = 8;
            this.lblPodcastInfo.Text = "Podcast information";
            // 
            // lblKategori2
            // 
            this.lblKategori2.AutoSize = true;
            this.lblKategori2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori2.Location = new System.Drawing.Point(612, 228);
            this.lblKategori2.Name = "lblKategori2";
            this.lblKategori2.Size = new System.Drawing.Size(96, 20);
            this.lblKategori2.TabIndex = 9;
            this.lblKategori2.Text = "Kategorier";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(606, 372);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(222, 20);
            this.textBoxCategory.TabIndex = 12;
            // 
            // btnNewPodcast
            // 
            this.btnNewPodcast.Location = new System.Drawing.Point(31, 298);
            this.btnNewPodcast.Name = "btnNewPodcast";
            this.btnNewPodcast.Size = new System.Drawing.Size(80, 23);
            this.btnNewPodcast.TabIndex = 13;
            this.btnNewPodcast.Text = "Ny";
            this.btnNewPodcast.UseVisualStyleBackColor = true;
            this.btnNewPodcast.Click += new System.EventHandler(this.btnNewPodcast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.Location = new System.Drawing.Point(246, 298);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(88, 23);
            this.btnRemovePodcast.TabIndex = 15;
            this.btnRemovePodcast.Text = "Ta Bort";
            this.btnRemovePodcast.UseVisualStyleBackColor = true;
            this.btnRemovePodcast.Click += new System.EventHandler(this.btnRemovePodcast_Click);
            // 
            // labelPodBeskrivning
            // 
            this.labelPodBeskrivning.AutoSize = true;
            this.labelPodBeskrivning.Location = new System.Drawing.Point(623, 18);
            this.labelPodBeskrivning.Name = "labelPodBeskrivning";
            this.labelPodBeskrivning.Size = new System.Drawing.Size(41, 15);
            this.labelPodBeskrivning.TabIndex = 17;
            this.labelPodBeskrivning.Text = "label1";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(606, 415);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(53, 23);
            this.btnNewCategory.TabIndex = 18;
            this.btnNewCategory.Text = "Ny";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(765, 415);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(63, 23);
            this.btnTaBort2.TabIndex = 20;
            this.btnTaBort2.Text = "Ta bort";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.Location = new System.Drawing.Point(32, 372);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(452, 95);
            this.listBoxDescription.TabIndex = 21;
            this.listBoxDescription.SelectedIndexChanged += new System.EventHandler(this.listBox12_SelectedIndexChanged);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(606, 261);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(222, 95);
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
            this.gwdPodcasts.Location = new System.Drawing.Point(31, 93);
            this.gwdPodcasts.Name = "gwdPodcasts";
            this.gwdPodcasts.RowHeadersWidth = 51;
            this.gwdPodcasts.Size = new System.Drawing.Size(557, 199);
            this.gwdPodcasts.TabIndex = 24;
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
            this.btnSpara2.Location = new System.Drawing.Point(681, 415);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(58, 23);
            this.btnSpara2.TabIndex = 19;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            // 
            // listBoxPodcasts
            // 
            this.listBoxPodcasts.FormattingEnabled = true;
            this.listBoxPodcasts.Location = new System.Drawing.Point(616, 93);
            this.listBoxPodcasts.Name = "listBoxPodcasts";
            this.listBoxPodcasts.Size = new System.Drawing.Size(212, 95);
            this.listBoxPodcasts.TabIndex = 25;
            this.listBoxPodcasts.SelectedIndexChanged += new System.EventHandler(this.listBoxPodcasts_SelectedIndexChanged);
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1159, 584);
            this.Controls.Add(this.listBoxPodcasts);
            this.Controls.Add(this.gwdPodcasts);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.btnTaBort2);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.labelPodBeskrivning);
            this.Controls.Add(this.btnRemovePodcast);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewPodcast);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.lblKategori2);
            this.Controls.Add(this.lblPodcastInfo);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxUpdate);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblIntervall);
            this.Controls.Add(this.lblUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodcastForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gwdPodcasts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblIntervall;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxUpdate;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblPodcastInfo;
        private System.Windows.Forms.Label lblKategori2;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button btnNewPodcast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemovePodcast;
        private System.Windows.Forms.Label labelPodBeskrivning;
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
    }
}

