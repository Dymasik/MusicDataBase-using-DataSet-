namespace MusicDataBase
{
    partial class MPSearchFrm
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
            this.components = new System.ComponentModel.Container();
            this.bSCountry = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic = new MusicDataBase.DSMusic();
            this.mpSearchTA = new MusicDataBase.DSMusicTableAdapters.MPSearchTA();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVByCountry = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVByArtists = new System.Windows.Forms.DataGridView();
            this.aidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSArtist = new System.Windows.Forms.BindingSource(this.components);
            this.mPASearchTA = new MusicDataBase.DSMusicTableAdapters.MPASearchTA();
            ((System.ComponentModel.ISupportInitialize)(this.bSCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVByCountry)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVByArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // bSCountry
            // 
            this.bSCountry.DataMember = "MPSearch";
            this.bSCountry.DataSource = this.dSMusic;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mpSearchTA
            // 
            this.mpSearchTA.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVByCountry);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player present such countries";
            // 
            // dGVByCountry
            // 
            this.dGVByCountry.AutoGenerateColumns = false;
            this.dGVByCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVByCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn});
            this.dGVByCountry.DataSource = this.bSCountry;
            this.dGVByCountry.Location = new System.Drawing.Point(6, 19);
            this.dGVByCountry.Name = "dGVByCountry";
            this.dGVByCountry.Size = new System.Drawing.Size(348, 130);
            this.dGVByCountry.TabIndex = 0;
            this.dGVByCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVByCountry_CellContentClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "C_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "C_id";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "C_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "C_name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVByArtists);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country has such artists";
            // 
            // dGVByArtists
            // 
            this.dGVByArtists.AutoGenerateColumns = false;
            this.dGVByArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVByArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn1,
            this.anameDataGridViewTextBoxColumn1});
            this.dGVByArtists.DataSource = this.bSArtist;
            this.dGVByArtists.Location = new System.Drawing.Point(3, 16);
            this.dGVByArtists.Name = "dGVByArtists";
            this.dGVByArtists.Size = new System.Drawing.Size(345, 137);
            this.dGVByArtists.TabIndex = 0;
            // 
            // aidDataGridViewTextBoxColumn1
            // 
            this.aidDataGridViewTextBoxColumn1.DataPropertyName = "A_id";
            this.aidDataGridViewTextBoxColumn1.HeaderText = "A_id";
            this.aidDataGridViewTextBoxColumn1.Name = "aidDataGridViewTextBoxColumn1";
            this.aidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anameDataGridViewTextBoxColumn1
            // 
            this.anameDataGridViewTextBoxColumn1.DataPropertyName = "A_name";
            this.anameDataGridViewTextBoxColumn1.HeaderText = "A_name";
            this.anameDataGridViewTextBoxColumn1.Name = "anameDataGridViewTextBoxColumn1";
            // 
            // bSArtist
            // 
            this.bSArtist.DataMember = "MPASearch";
            this.bSArtist.DataSource = this.dSMusic;
            // 
            // mPASearchTA
            // 
            this.mPASearchTA.ClearBeforeFill = true;
            // 
            // MPSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MPSearchFrm";
            this.Text = "MPSearchFrm";
            ((System.ComponentModel.ISupportInitialize)(this.bSCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVByCountry)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVByArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bSCountry;
        private DSMusicTableAdapters.MPSearchTA mpSearchTA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVByArtists;
        private System.Windows.Forms.BindingSource bSArtist;
        private DSMusic dSMusic;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn1;
        private DSMusicTableAdapters.MPASearchTA mPASearchTA;
        private System.Windows.Forms.DataGridView dGVByCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
    }
}