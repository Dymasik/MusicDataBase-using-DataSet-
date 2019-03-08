namespace MusicDataBase
{
    partial class MusicDB
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addButtonArtist = new System.Windows.Forms.Button();
            this.deleteButtonArtist = new System.Windows.Forms.Button();
            this.saveButtonArtist = new System.Windows.Forms.Button();
            this.dGVArtists = new System.Windows.Forms.DataGridView();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acountryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic = new MusicDataBase.DSMusic();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addButtonAlbum = new System.Windows.Forms.Button();
            this.deleteButtonAlbum = new System.Windows.Forms.Button();
            this.saveButtonAlbum = new System.Windows.Forms.Button();
            this.dGVAlbums = new System.Windows.Forms.DataGridView();
            this.aLidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLartIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addButtonSong = new System.Windows.Forms.Button();
            this.deleteButtonSongs = new System.Windows.Forms.Button();
            this.saveButtonSongs = new System.Windows.Forms.Button();
            this.dGVSongs = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.addButtonService = new System.Windows.Forms.Button();
            this.deleteButtonPlayers = new System.Windows.Forms.Button();
            this.saveButtonPlayers = new System.Windows.Forms.Button();
            this.dGVPlayers = new System.Windows.Forms.DataGridView();
            this.mPidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicPlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic1 = new MusicDataBase.DSMusic();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.addButtonCountry = new System.Windows.Forms.Button();
            this.deleteButtonCountries = new System.Windows.Forms.Button();
            this.saveButtonCountries = new System.Windows.Forms.Button();
            this.dGVCountries = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.addButtonGanre = new System.Windows.Forms.Button();
            this.deleteButtonGanres = new System.Windows.Forms.Button();
            this.saveButtonGanres = new System.Windows.Forms.Button();
            this.dGVGanres = new System.Windows.Forms.DataGridView();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ginfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new MusicDataBase.DSMusicTableAdapters.ArtistsTableAdapter();
            this.albumsTableAdapter = new MusicDataBase.DSMusicTableAdapters.AlbumsTableAdapter();
            this.songsTableAdapter = new MusicDataBase.DSMusicTableAdapters.SongsTableAdapter();
            this.QTAdapter = new MusicDataBase.DSMusicTableAdapters.QueriesTableAdapter();
            this.musicPlayersTableAdapter = new MusicDataBase.DSMusicTableAdapters.MusicPlayersTableAdapter();
            this.countriesTableAdapter = new MusicDataBase.DSMusicTableAdapters.CountriesTableAdapter();
            this.ganresTableAdapter = new MusicDataBase.DSMusicTableAdapters.GanresTableAdapter();
            this.songGanreTableAdapter = new MusicDataBase.DSMusicTableAdapters.SongGanreTableAdapter();
            this.sgTA = new MusicDataBase.DSMusicTableAdapters.SongGanreTableAdapter();
            this.artistPlayerTableAdapter = new MusicDataBase.DSMusicTableAdapters.ArtistPlayerTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGanres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Location = new System.Drawing.Point(12, 89);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 349);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Maroon;
            this.tabPage1.Controls.Add(this.addButtonArtist);
            this.tabPage1.Controls.Add(this.deleteButtonArtist);
            this.tabPage1.Controls.Add(this.saveButtonArtist);
            this.tabPage1.Controls.Add(this.dGVArtists);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artists";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // addButtonArtist
            // 
            this.addButtonArtist.Location = new System.Drawing.Point(190, 24);
            this.addButtonArtist.Name = "addButtonArtist";
            this.addButtonArtist.Size = new System.Drawing.Size(75, 23);
            this.addButtonArtist.TabIndex = 3;
            this.addButtonArtist.Text = "Add";
            this.addButtonArtist.UseVisualStyleBackColor = true;
            this.addButtonArtist.Click += new System.EventHandler(this.addButtonArtist_Click);
            // 
            // deleteButtonArtist
            // 
            this.deleteButtonArtist.Location = new System.Drawing.Point(109, 24);
            this.deleteButtonArtist.Name = "deleteButtonArtist";
            this.deleteButtonArtist.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonArtist.TabIndex = 2;
            this.deleteButtonArtist.Text = "Delete";
            this.deleteButtonArtist.UseVisualStyleBackColor = true;
            this.deleteButtonArtist.Click += new System.EventHandler(this.deleteButtonArtist_Click);
            // 
            // saveButtonArtist
            // 
            this.saveButtonArtist.Location = new System.Drawing.Point(28, 24);
            this.saveButtonArtist.Name = "saveButtonArtist";
            this.saveButtonArtist.Size = new System.Drawing.Size(75, 23);
            this.saveButtonArtist.TabIndex = 1;
            this.saveButtonArtist.Text = "Save";
            this.saveButtonArtist.UseVisualStyleBackColor = true;
            this.saveButtonArtist.Click += new System.EventHandler(this.saveButtonArtist_Click);
            // 
            // dGVArtists
            // 
            this.dGVArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVArtists.AutoGenerateColumns = false;
            this.dGVArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn,
            this.acountryIdDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn});
            this.dGVArtists.DataSource = this.artistsBindingSource;
            this.dGVArtists.Location = new System.Drawing.Point(8, 73);
            this.dGVArtists.Name = "dGVArtists";
            this.dGVArtists.ReadOnly = true;
            this.dGVArtists.Size = new System.Drawing.Size(745, 219);
            this.dGVArtists.TabIndex = 0;
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "A_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "ID ";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acountryIdDataGridViewTextBoxColumn
            // 
            this.acountryIdDataGridViewTextBoxColumn.DataPropertyName = "A_countryId";
            this.acountryIdDataGridViewTextBoxColumn.HeaderText = "ID of Country";
            this.acountryIdDataGridViewTextBoxColumn.Name = "acountryIdDataGridViewTextBoxColumn";
            this.acountryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "A_name";
            this.anameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            this.anameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.dSMusic;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.addButtonAlbum);
            this.tabPage2.Controls.Add(this.deleteButtonAlbum);
            this.tabPage2.Controls.Add(this.saveButtonAlbum);
            this.tabPage2.Controls.Add(this.dGVAlbums);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            // 
            // addButtonAlbum
            // 
            this.addButtonAlbum.Location = new System.Drawing.Point(170, 22);
            this.addButtonAlbum.Name = "addButtonAlbum";
            this.addButtonAlbum.Size = new System.Drawing.Size(75, 23);
            this.addButtonAlbum.TabIndex = 3;
            this.addButtonAlbum.Text = "Add";
            this.addButtonAlbum.UseVisualStyleBackColor = true;
            this.addButtonAlbum.Click += new System.EventHandler(this.addButtonAlbum_Click);
            // 
            // deleteButtonAlbum
            // 
            this.deleteButtonAlbum.Location = new System.Drawing.Point(89, 22);
            this.deleteButtonAlbum.Name = "deleteButtonAlbum";
            this.deleteButtonAlbum.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonAlbum.TabIndex = 2;
            this.deleteButtonAlbum.Text = "Delete";
            this.deleteButtonAlbum.UseVisualStyleBackColor = true;
            this.deleteButtonAlbum.Click += new System.EventHandler(this.deleteButtonAlbum_Click);
            // 
            // saveButtonAlbum
            // 
            this.saveButtonAlbum.Location = new System.Drawing.Point(8, 22);
            this.saveButtonAlbum.Name = "saveButtonAlbum";
            this.saveButtonAlbum.Size = new System.Drawing.Size(75, 23);
            this.saveButtonAlbum.TabIndex = 1;
            this.saveButtonAlbum.Text = "Save";
            this.saveButtonAlbum.UseVisualStyleBackColor = true;
            this.saveButtonAlbum.Click += new System.EventHandler(this.saveButtonAlbum_Click);
            // 
            // dGVAlbums
            // 
            this.dGVAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAlbums.AutoGenerateColumns = false;
            this.dGVAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLidDataGridViewTextBoxColumn,
            this.aLnameDataGridViewTextBoxColumn,
            this.aLdateDataGridViewTextBoxColumn,
            this.aLartIdDataGridViewTextBoxColumn});
            this.dGVAlbums.DataSource = this.albumsBindingSource;
            this.dGVAlbums.Location = new System.Drawing.Point(8, 64);
            this.dGVAlbums.Name = "dGVAlbums";
            this.dGVAlbums.ReadOnly = true;
            this.dGVAlbums.Size = new System.Drawing.Size(521, 218);
            this.dGVAlbums.TabIndex = 0;
            // 
            // aLidDataGridViewTextBoxColumn
            // 
            this.aLidDataGridViewTextBoxColumn.DataPropertyName = "AL_id";
            this.aLidDataGridViewTextBoxColumn.HeaderText = "ID ";
            this.aLidDataGridViewTextBoxColumn.Name = "aLidDataGridViewTextBoxColumn";
            this.aLidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLnameDataGridViewTextBoxColumn
            // 
            this.aLnameDataGridViewTextBoxColumn.DataPropertyName = "AL_name";
            this.aLnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.aLnameDataGridViewTextBoxColumn.Name = "aLnameDataGridViewTextBoxColumn";
            this.aLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLdateDataGridViewTextBoxColumn
            // 
            this.aLdateDataGridViewTextBoxColumn.DataPropertyName = "AL_date";
            this.aLdateDataGridViewTextBoxColumn.HeaderText = "Date of release";
            this.aLdateDataGridViewTextBoxColumn.Name = "aLdateDataGridViewTextBoxColumn";
            this.aLdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLartIdDataGridViewTextBoxColumn
            // 
            this.aLartIdDataGridViewTextBoxColumn.DataPropertyName = "AL_artId";
            this.aLartIdDataGridViewTextBoxColumn.HeaderText = "ID of Artist";
            this.aLartIdDataGridViewTextBoxColumn.Name = "aLartIdDataGridViewTextBoxColumn";
            this.aLartIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.dSMusic;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Coral;
            this.tabPage3.Controls.Add(this.addButtonSong);
            this.tabPage3.Controls.Add(this.deleteButtonSongs);
            this.tabPage3.Controls.Add(this.saveButtonSongs);
            this.tabPage3.Controls.Add(this.dGVSongs);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Songs";
            // 
            // addButtonSong
            // 
            this.addButtonSong.Location = new System.Drawing.Point(170, 20);
            this.addButtonSong.Name = "addButtonSong";
            this.addButtonSong.Size = new System.Drawing.Size(75, 23);
            this.addButtonSong.TabIndex = 3;
            this.addButtonSong.Text = "Add";
            this.addButtonSong.UseVisualStyleBackColor = true;
            this.addButtonSong.Click += new System.EventHandler(this.addButtonSong_Click);
            // 
            // deleteButtonSongs
            // 
            this.deleteButtonSongs.Location = new System.Drawing.Point(89, 20);
            this.deleteButtonSongs.Name = "deleteButtonSongs";
            this.deleteButtonSongs.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonSongs.TabIndex = 2;
            this.deleteButtonSongs.Text = "Delete";
            this.deleteButtonSongs.UseVisualStyleBackColor = true;
            this.deleteButtonSongs.Click += new System.EventHandler(this.deleteButtonSongs_Click);
            // 
            // saveButtonSongs
            // 
            this.saveButtonSongs.Location = new System.Drawing.Point(8, 20);
            this.saveButtonSongs.Name = "saveButtonSongs";
            this.saveButtonSongs.Size = new System.Drawing.Size(75, 23);
            this.saveButtonSongs.TabIndex = 1;
            this.saveButtonSongs.Text = "Save";
            this.saveButtonSongs.UseVisualStyleBackColor = true;
            this.saveButtonSongs.Click += new System.EventHandler(this.saveButtonSongs_Click);
            // 
            // dGVSongs
            // 
            this.dGVSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSongs.AutoGenerateColumns = false;
            this.dGVSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.slengthDataGridViewTextBoxColumn,
            this.salbIdDataGridViewTextBoxColumn});
            this.dGVSongs.DataSource = this.songsBindingSource;
            this.dGVSongs.Location = new System.Drawing.Point(8, 59);
            this.dGVSongs.Name = "dGVSongs";
            this.dGVSongs.ReadOnly = true;
            this.dGVSongs.Size = new System.Drawing.Size(523, 246);
            this.dGVSongs.TabIndex = 0;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "S_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "S_id";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sidDataGridViewTextBoxColumn.Visible = false;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "S_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slengthDataGridViewTextBoxColumn
            // 
            this.slengthDataGridViewTextBoxColumn.DataPropertyName = "S_length";
            this.slengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.slengthDataGridViewTextBoxColumn.Name = "slengthDataGridViewTextBoxColumn";
            this.slengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salbIdDataGridViewTextBoxColumn
            // 
            this.salbIdDataGridViewTextBoxColumn.DataPropertyName = "S_albId";
            this.salbIdDataGridViewTextBoxColumn.HeaderText = "ID of Album";
            this.salbIdDataGridViewTextBoxColumn.Name = "salbIdDataGridViewTextBoxColumn";
            this.salbIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.dSMusic;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Chocolate;
            this.tabPage4.Controls.Add(this.addButtonService);
            this.tabPage4.Controls.Add(this.deleteButtonPlayers);
            this.tabPage4.Controls.Add(this.saveButtonPlayers);
            this.tabPage4.Controls.Add(this.dGVPlayers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 323);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Players";
            // 
            // addButtonService
            // 
            this.addButtonService.Location = new System.Drawing.Point(170, 30);
            this.addButtonService.Name = "addButtonService";
            this.addButtonService.Size = new System.Drawing.Size(75, 23);
            this.addButtonService.TabIndex = 3;
            this.addButtonService.Text = "Add";
            this.addButtonService.UseVisualStyleBackColor = true;
            this.addButtonService.Click += new System.EventHandler(this.addButtonService_Click);
            // 
            // deleteButtonPlayers
            // 
            this.deleteButtonPlayers.Location = new System.Drawing.Point(89, 30);
            this.deleteButtonPlayers.Name = "deleteButtonPlayers";
            this.deleteButtonPlayers.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonPlayers.TabIndex = 2;
            this.deleteButtonPlayers.Text = "Delete";
            this.deleteButtonPlayers.UseVisualStyleBackColor = true;
            this.deleteButtonPlayers.Click += new System.EventHandler(this.deleteButtonPlayers_Click);
            // 
            // saveButtonPlayers
            // 
            this.saveButtonPlayers.Location = new System.Drawing.Point(8, 30);
            this.saveButtonPlayers.Name = "saveButtonPlayers";
            this.saveButtonPlayers.Size = new System.Drawing.Size(75, 23);
            this.saveButtonPlayers.TabIndex = 1;
            this.saveButtonPlayers.Text = "Save";
            this.saveButtonPlayers.UseVisualStyleBackColor = true;
            this.saveButtonPlayers.Click += new System.EventHandler(this.saveButtonPlayers_Click);
            // 
            // dGVPlayers
            // 
            this.dGVPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPlayers.AutoGenerateColumns = false;
            this.dGVPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mPidDataGridViewTextBoxColumn,
            this.mPnameDataGridViewTextBoxColumn});
            this.dGVPlayers.DataSource = this.musicPlayersBindingSource;
            this.dGVPlayers.Location = new System.Drawing.Point(8, 74);
            this.dGVPlayers.Name = "dGVPlayers";
            this.dGVPlayers.ReadOnly = true;
            this.dGVPlayers.Size = new System.Drawing.Size(535, 220);
            this.dGVPlayers.TabIndex = 0;
            this.dGVPlayers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVPlayers_CellDoubleClick);
            // 
            // mPidDataGridViewTextBoxColumn
            // 
            this.mPidDataGridViewTextBoxColumn.DataPropertyName = "MP_id";
            this.mPidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.mPidDataGridViewTextBoxColumn.Name = "mPidDataGridViewTextBoxColumn";
            this.mPidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mPnameDataGridViewTextBoxColumn
            // 
            this.mPnameDataGridViewTextBoxColumn.DataPropertyName = "MP_name";
            this.mPnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.mPnameDataGridViewTextBoxColumn.Name = "mPnameDataGridViewTextBoxColumn";
            this.mPnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musicPlayersBindingSource
            // 
            this.musicPlayersBindingSource.DataMember = "MusicPlayers";
            this.musicPlayersBindingSource.DataSource = this.dSMusic1;
            // 
            // dSMusic1
            // 
            this.dSMusic1.DataSetName = "DSMusic";
            this.dSMusic1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Khaki;
            this.tabPage5.Controls.Add(this.addButtonCountry);
            this.tabPage5.Controls.Add(this.deleteButtonCountries);
            this.tabPage5.Controls.Add(this.saveButtonCountries);
            this.tabPage5.Controls.Add(this.dGVCountries);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 323);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Countries";
            // 
            // addButtonCountry
            // 
            this.addButtonCountry.Location = new System.Drawing.Point(170, 47);
            this.addButtonCountry.Name = "addButtonCountry";
            this.addButtonCountry.Size = new System.Drawing.Size(75, 23);
            this.addButtonCountry.TabIndex = 3;
            this.addButtonCountry.Text = "Add";
            this.addButtonCountry.UseVisualStyleBackColor = true;
            this.addButtonCountry.Click += new System.EventHandler(this.addButtonCountry_Click);
            // 
            // deleteButtonCountries
            // 
            this.deleteButtonCountries.Location = new System.Drawing.Point(89, 47);
            this.deleteButtonCountries.Name = "deleteButtonCountries";
            this.deleteButtonCountries.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonCountries.TabIndex = 2;
            this.deleteButtonCountries.Text = "Delete";
            this.deleteButtonCountries.UseVisualStyleBackColor = true;
            this.deleteButtonCountries.Click += new System.EventHandler(this.deleteButtonCountries_Click);
            // 
            // saveButtonCountries
            // 
            this.saveButtonCountries.Location = new System.Drawing.Point(8, 47);
            this.saveButtonCountries.Name = "saveButtonCountries";
            this.saveButtonCountries.Size = new System.Drawing.Size(75, 23);
            this.saveButtonCountries.TabIndex = 1;
            this.saveButtonCountries.Text = "Save";
            this.saveButtonCountries.UseVisualStyleBackColor = true;
            this.saveButtonCountries.Click += new System.EventHandler(this.saveButtonCountries_Click);
            // 
            // dGVCountries
            // 
            this.dGVCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCountries.AutoGenerateColumns = false;
            this.dGVCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn});
            this.dGVCountries.DataSource = this.countriesBindingSource;
            this.dGVCountries.Location = new System.Drawing.Point(8, 76);
            this.dGVCountries.Name = "dGVCountries";
            this.dGVCountries.ReadOnly = true;
            this.dGVCountries.Size = new System.Drawing.Size(535, 204);
            this.dGVCountries.TabIndex = 0;
            this.dGVCountries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCountries_CellDoubleClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "C_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "C_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.dSMusic1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage6.Controls.Add(this.addButtonGanre);
            this.tabPage6.Controls.Add(this.deleteButtonGanres);
            this.tabPage6.Controls.Add(this.saveButtonGanres);
            this.tabPage6.Controls.Add(this.dGVGanres);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(768, 323);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ganres";
            // 
            // addButtonGanre
            // 
            this.addButtonGanre.Location = new System.Drawing.Point(170, 22);
            this.addButtonGanre.Name = "addButtonGanre";
            this.addButtonGanre.Size = new System.Drawing.Size(75, 23);
            this.addButtonGanre.TabIndex = 4;
            this.addButtonGanre.Text = "Add";
            this.addButtonGanre.UseVisualStyleBackColor = true;
            this.addButtonGanre.Click += new System.EventHandler(this.addButtonGanre_Click);
            // 
            // deleteButtonGanres
            // 
            this.deleteButtonGanres.Location = new System.Drawing.Point(89, 22);
            this.deleteButtonGanres.Name = "deleteButtonGanres";
            this.deleteButtonGanres.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonGanres.TabIndex = 3;
            this.deleteButtonGanres.Text = "Delete";
            this.deleteButtonGanres.UseVisualStyleBackColor = true;
            this.deleteButtonGanres.Click += new System.EventHandler(this.deleteButtonGanres_Click);
            // 
            // saveButtonGanres
            // 
            this.saveButtonGanres.Location = new System.Drawing.Point(8, 22);
            this.saveButtonGanres.Name = "saveButtonGanres";
            this.saveButtonGanres.Size = new System.Drawing.Size(75, 23);
            this.saveButtonGanres.TabIndex = 2;
            this.saveButtonGanres.Text = "Save";
            this.saveButtonGanres.UseVisualStyleBackColor = true;
            this.saveButtonGanres.Click += new System.EventHandler(this.saveButtonGanres_Click);
            // 
            // dGVGanres
            // 
            this.dGVGanres.AutoGenerateColumns = false;
            this.dGVGanres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGanres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn,
            this.ginfoDataGridViewTextBoxColumn});
            this.dGVGanres.DataSource = this.ganresBindingSource;
            this.dGVGanres.Location = new System.Drawing.Point(8, 77);
            this.dGVGanres.Name = "dGVGanres";
            this.dGVGanres.ReadOnly = true;
            this.dGVGanres.Size = new System.Drawing.Size(535, 243);
            this.dGVGanres.TabIndex = 1;
            this.dGVGanres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGanres_CellClick);
            this.dGVGanres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGanres_CellDoubleClick);
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "G_id";
            this.gidDataGridViewTextBoxColumn.HeaderText = "G_id";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "G_name";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "G_name";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ginfoDataGridViewTextBoxColumn
            // 
            this.ginfoDataGridViewTextBoxColumn.DataPropertyName = "G_info";
            this.ginfoDataGridViewTextBoxColumn.HeaderText = "G_info";
            this.ginfoDataGridViewTextBoxColumn.Name = "ginfoDataGridViewTextBoxColumn";
            this.ginfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ganresBindingSource
            // 
            this.ganresBindingSource.DataMember = "Ganres";
            this.ganresBindingSource.DataSource = this.dSMusic;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // musicPlayersTableAdapter
            // 
            this.musicPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // ganresTableAdapter
            // 
            this.ganresTableAdapter.ClearBeforeFill = true;
            // 
            // songGanreTableAdapter
            // 
            this.songGanreTableAdapter.ClearBeforeFill = true;
            // 
            // sgTA
            // 
            this.sgTA.ClearBeforeFill = true;
            // 
            // artistPlayerTableAdapter
            // 
            this.artistPlayerTableAdapter.ClearBeforeFill = true;
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(722, 12);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(62, 53);
            this.bHelp.TabIndex = 5;
            this.bHelp.Text = "Help";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicDataBase.Properties.Resources.oboik_ru_58534;
            this.pictureBox1.Location = new System.Drawing.Point(2, -214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 701);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MusicDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusicDB";
            this.Text = "MUSIC";
            this.Load += new System.EventHandler(this.MusicDB_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGanres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVArtists;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private DSMusic dSMusic;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private DSMusicTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private DSMusicTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.DataGridView dGVAlbums;
        private System.Windows.Forms.DataGridView dGVSongs;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private DSMusicTableAdapters.SongsTableAdapter songsTableAdapter;
        private System.Windows.Forms.Button saveButtonArtist;
        private System.Windows.Forms.Button deleteButtonArtist;
        private DSMusicTableAdapters.QueriesTableAdapter QTAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button deleteButtonAlbum;
        private System.Windows.Forms.Button saveButtonAlbum;
        private System.Windows.Forms.Button deleteButtonSongs;
        private System.Windows.Forms.Button saveButtonSongs;
        private System.Windows.Forms.DataGridView dGVPlayers;
        private System.Windows.Forms.Button deleteButtonPlayers;
        private System.Windows.Forms.Button saveButtonPlayers;
        private System.Windows.Forms.DataGridView dGVCountries;
        private System.Windows.Forms.Button deleteButtonCountries;
        private System.Windows.Forms.Button saveButtonCountries;
        private DSMusic dSMusic1;
        private System.Windows.Forms.BindingSource musicPlayersBindingSource;
        private DSMusicTableAdapters.MusicPlayersTableAdapter musicPlayersTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private DSMusicTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acountryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLartIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dGVGanres;
        private System.Windows.Forms.BindingSource ganresBindingSource;
        private DSMusicTableAdapters.GanresTableAdapter ganresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ginfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButtonGanres;
        private System.Windows.Forms.Button saveButtonGanres;
        private System.Windows.Forms.Button addButtonArtist;
        private System.Windows.Forms.Button addButtonAlbum;
        private System.Windows.Forms.Button addButtonSong;
        private DSMusicTableAdapters.SongGanreTableAdapter songGanreTableAdapter;
        private System.Windows.Forms.Button addButtonCountry;
        private System.Windows.Forms.Button addButtonGanre;
        private DSMusicTableAdapters.SongGanreTableAdapter sgTA;
        private System.Windows.Forms.Button addButtonService;
        private DSMusicTableAdapters.ArtistPlayerTableAdapter artistPlayerTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

