namespace MusicDataBase
{
    partial class FrmSong
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
            this.dGVSongSearch = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic = new MusicDataBase.DSMusic();
            this.dtSongsOfGanreTableAdapter = new MusicDataBase.DSMusicTableAdapters.DTSongsOfGanreTableAdapter();
            this.searchParametrs = new System.Windows.Forms.GroupBox();
            this.cBLen = new System.Windows.Forms.CheckBox();
            this.cBArtist = new System.Windows.Forms.CheckBox();
            this.cBAlbum = new System.Windows.Forms.CheckBox();
            this.cBName = new System.Windows.Forms.CheckBox();
            this.upperBound = new System.Windows.Forms.NumericUpDown();
            this.lowerBound = new System.Windows.Forms.NumericUpDown();
            this.tBArtist = new System.Windows.Forms.TextBox();
            this.tBAlbum = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dGVAlbSong = new System.Windows.Forms.DataGridView();
            this.aLidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.albumsSearchTableAdapter = new MusicDataBase.DSMusicTableAdapters.AlbumsSearchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSongSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            this.searchParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlbSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVSongSearch
            // 
            this.dGVSongSearch.AllowUserToOrderColumns = true;
            this.dGVSongSearch.AutoGenerateColumns = false;
            this.dGVSongSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSongSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.slengthDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn,
            this.gidDataGridViewTextBoxColumn});
            this.dGVSongSearch.DataSource = this.bindingSource1;
            this.dGVSongSearch.Location = new System.Drawing.Point(43, 211);
            this.dGVSongSearch.Name = "dGVSongSearch";
            this.dGVSongSearch.Size = new System.Drawing.Size(392, 164);
            this.dGVSongSearch.TabIndex = 0;
            this.dGVSongSearch.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSongSearch_CellMouseEnter);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "S_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "S_id";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "S_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "S_name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // slengthDataGridViewTextBoxColumn
            // 
            this.slengthDataGridViewTextBoxColumn.DataPropertyName = "S_length";
            this.slengthDataGridViewTextBoxColumn.HeaderText = "S_length";
            this.slengthDataGridViewTextBoxColumn.Name = "slengthDataGridViewTextBoxColumn";
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "G_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "G_name";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "G_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "G_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gidDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DTSongsOfGanre";
            this.bindingSource1.DataSource = this.dSMusic;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSongsOfGanreTableAdapter
            // 
            this.dtSongsOfGanreTableAdapter.ClearBeforeFill = true;
            // 
            // searchParametrs
            // 
            this.searchParametrs.Controls.Add(this.cBLen);
            this.searchParametrs.Controls.Add(this.cBArtist);
            this.searchParametrs.Controls.Add(this.cBAlbum);
            this.searchParametrs.Controls.Add(this.cBName);
            this.searchParametrs.Controls.Add(this.upperBound);
            this.searchParametrs.Controls.Add(this.lowerBound);
            this.searchParametrs.Controls.Add(this.tBArtist);
            this.searchParametrs.Controls.Add(this.tBAlbum);
            this.searchParametrs.Controls.Add(this.tBName);
            this.searchParametrs.Location = new System.Drawing.Point(30, 66);
            this.searchParametrs.Name = "searchParametrs";
            this.searchParametrs.Size = new System.Drawing.Size(384, 139);
            this.searchParametrs.TabIndex = 1;
            this.searchParametrs.TabStop = false;
            this.searchParametrs.Text = "Parametrs of Search";
            this.searchParametrs.Enter += new System.EventHandler(this.searchParametrs_Enter);
            // 
            // cBLen
            // 
            this.cBLen.AutoSize = true;
            this.cBLen.Location = new System.Drawing.Point(12, 100);
            this.cBLen.Name = "cBLen";
            this.cBLen.Size = new System.Drawing.Size(97, 17);
            this.cBLen.TabIndex = 8;
            this.cBLen.Text = "Length of song";
            this.cBLen.UseVisualStyleBackColor = true;
            // 
            // cBArtist
            // 
            this.cBArtist.AutoSize = true;
            this.cBArtist.Location = new System.Drawing.Point(12, 71);
            this.cBArtist.Name = "cBArtist";
            this.cBArtist.Size = new System.Drawing.Size(49, 17);
            this.cBArtist.TabIndex = 7;
            this.cBArtist.Text = "Artist";
            this.cBArtist.UseVisualStyleBackColor = true;
            // 
            // cBAlbum
            // 
            this.cBAlbum.AutoSize = true;
            this.cBAlbum.Location = new System.Drawing.Point(12, 45);
            this.cBAlbum.Name = "cBAlbum";
            this.cBAlbum.Size = new System.Drawing.Size(55, 17);
            this.cBAlbum.TabIndex = 6;
            this.cBAlbum.Text = "Album";
            this.cBAlbum.UseVisualStyleBackColor = true;
            // 
            // cBName
            // 
            this.cBName.AutoSize = true;
            this.cBName.Location = new System.Drawing.Point(12, 19);
            this.cBName.Name = "cBName";
            this.cBName.Size = new System.Drawing.Size(54, 17);
            this.cBName.TabIndex = 5;
            this.cBName.Text = "Name";
            this.cBName.UseVisualStyleBackColor = true;
            // 
            // upperBound
            // 
            this.upperBound.Location = new System.Drawing.Point(241, 97);
            this.upperBound.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.upperBound.Name = "upperBound";
            this.upperBound.Size = new System.Drawing.Size(120, 20);
            this.upperBound.TabIndex = 4;
            // 
            // lowerBound
            // 
            this.lowerBound.Location = new System.Drawing.Point(115, 97);
            this.lowerBound.Name = "lowerBound";
            this.lowerBound.Size = new System.Drawing.Size(120, 20);
            this.lowerBound.TabIndex = 3;
            // 
            // tBArtist
            // 
            this.tBArtist.Location = new System.Drawing.Point(115, 71);
            this.tBArtist.Name = "tBArtist";
            this.tBArtist.Size = new System.Drawing.Size(263, 20);
            this.tBArtist.TabIndex = 2;
            // 
            // tBAlbum
            // 
            this.tBAlbum.Location = new System.Drawing.Point(115, 45);
            this.tBAlbum.Name = "tBAlbum";
            this.tBAlbum.Size = new System.Drawing.Size(263, 20);
            this.tBAlbum.TabIndex = 1;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(115, 19);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(263, 20);
            this.tBName.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(30, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dGVAlbSong
            // 
            this.dGVAlbSong.AutoGenerateColumns = false;
            this.dGVAlbSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlbSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLidDataGridViewTextBoxColumn,
            this.aLnameDataGridViewTextBoxColumn,
            this.aLdateDataGridViewTextBoxColumn});
            this.dGVAlbSong.DataSource = this.bindingSource2;
            this.dGVAlbSong.Location = new System.Drawing.Point(6, 24);
            this.dGVAlbSong.Name = "dGVAlbSong";
            this.dGVAlbSong.Size = new System.Drawing.Size(381, 96);
            this.dGVAlbSong.TabIndex = 4;
            // 
            // aLidDataGridViewTextBoxColumn
            // 
            this.aLidDataGridViewTextBoxColumn.DataPropertyName = "AL_id";
            this.aLidDataGridViewTextBoxColumn.HeaderText = "AL_id";
            this.aLidDataGridViewTextBoxColumn.Name = "aLidDataGridViewTextBoxColumn";
            this.aLidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLnameDataGridViewTextBoxColumn
            // 
            this.aLnameDataGridViewTextBoxColumn.DataPropertyName = "AL_name";
            this.aLnameDataGridViewTextBoxColumn.HeaderText = "AL_name";
            this.aLnameDataGridViewTextBoxColumn.Name = "aLnameDataGridViewTextBoxColumn";
            // 
            // aLdateDataGridViewTextBoxColumn
            // 
            this.aLdateDataGridViewTextBoxColumn.DataPropertyName = "AL_date";
            this.aLdateDataGridViewTextBoxColumn.HeaderText = "AL_date";
            this.aLdateDataGridViewTextBoxColumn.Name = "aLdateDataGridViewTextBoxColumn";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "AlbumsSearch";
            this.bindingSource2.DataSource = this.dSMusic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVAlbSong);
            this.groupBox1.Location = new System.Drawing.Point(43, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album of current song";
            // 
            // albumsSearchTableAdapter
            // 
            this.albumsSearchTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dGVSongSearch);
            this.Controls.Add(this.searchParametrs);
            this.Name = "FrmSong";
            this.Text = "FrmSong";
            this.Load += new System.EventHandler(this.FrmSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSongSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            this.searchParametrs.ResumeLayout(false);
            this.searchParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlbSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVSongSearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DSMusic dSMusic;
        private DSMusicTableAdapters.DTSongsOfGanreTableAdapter dtSongsOfGanreTableAdapter;
        private System.Windows.Forms.GroupBox searchParametrs;
        private System.Windows.Forms.TextBox tBArtist;
        private System.Windows.Forms.TextBox tBAlbum;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox cBLen;
        private System.Windows.Forms.CheckBox cBArtist;
        private System.Windows.Forms.CheckBox cBAlbum;
        private System.Windows.Forms.CheckBox cBName;
        private System.Windows.Forms.NumericUpDown upperBound;
        private System.Windows.Forms.NumericUpDown lowerBound;
        private System.Windows.Forms.DataGridView dGVAlbSong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DSMusicTableAdapters.AlbumsSearchTableAdapter albumsSearchTableAdapter;
    }
}