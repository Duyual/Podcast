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
            this.comboBoxUppdatering = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblPodcastInfo = new System.Windows.Forms.Label();
            this.lblKategori2 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.btnNy = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.labelPodBeskrivning = new System.Windows.Forms.Label();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnTaBort2 = new System.Windows.Forms.Button();
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.gwdPodcasts = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvsnitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSpara2 = new System.Windows.Forms.Button();
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
            // comboBoxUppdatering
            // 
            this.comboBoxUppdatering.FormattingEnabled = true;
            this.comboBoxUppdatering.Location = new System.Drawing.Point(391, 48);
            this.comboBoxUppdatering.Name = "comboBoxUppdatering";
            this.comboBoxUppdatering.Size = new System.Drawing.Size(83, 21);
            this.comboBoxUppdatering.TabIndex = 4;
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
            // btnNy
            // 
            this.btnNy.Location = new System.Drawing.Point(31, 298);
            this.btnNy.Name = "btnNy";
            this.btnNy.Size = new System.Drawing.Size(80, 23);
            this.btnNy.TabIndex = 13;
            this.btnNy.Text = "Ny";
            this.btnNy.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(130, 298);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(74, 23);
            this.btnSpara.TabIndex = 14;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(246, 298);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(88, 23);
            this.btnTaBort.TabIndex = 15;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
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
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(616, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(222, 121);
            this.listBox2.TabIndex = 22;
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
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1159, 584);
            this.Controls.Add(this.gwdPodcasts);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.btnTaBort2);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.labelPodBeskrivning);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnNy);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.lblKategori2);
            this.Controls.Add(this.lblPodcastInfo);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxUppdatering);
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
        private System.Windows.Forms.ComboBox comboBoxUppdatering;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblPodcastInfo;
        private System.Windows.Forms.Label lblKategori2;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button btnNy;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label labelPodBeskrivning;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnTaBort2;
        private System.Windows.Forms.ListBox listBoxDescription;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.DataGridView gwdPodcasts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequence;
        private System.Windows.Forms.Button btnSpara2;
    }
}

