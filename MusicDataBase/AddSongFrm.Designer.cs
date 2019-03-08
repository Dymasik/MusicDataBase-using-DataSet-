namespace MusicDataBase
{
    partial class AddSongFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lBGanres = new System.Windows.Forms.ListBox();
            this.numLen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cBAlbum = new System.Windows.Forms.ComboBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.dSMusic = new MusicDataBase.DSMusic();
            this.albumsTableAdapter1 = new MusicDataBase.DSMusicTableAdapters.AlbumsTableAdapter();
            this.ganresTableAdapter1 = new MusicDataBase.DSMusicTableAdapters.GanresTableAdapter();
            this.bSAlb = new System.Windows.Forms.BindingSource(this.components);
            this.bSGanres = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSAlb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSGanres)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lBGanres);
            this.groupBox1.Controls.Add(this.numLen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.cBAlbum);
            this.groupBox1.Controls.Add(this.tBName);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ganres";
            // 
            // lBGanres
            // 
            this.lBGanres.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSGanres, "G_id", true));
            this.lBGanres.DataSource = this.bSGanres;
            this.lBGanres.DisplayMember = "G_name";
            this.lBGanres.FormattingEnabled = true;
            this.lBGanres.Location = new System.Drawing.Point(101, 123);
            this.lBGanres.Name = "lBGanres";
            this.lBGanres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBGanres.Size = new System.Drawing.Size(200, 69);
            this.lBGanres.TabIndex = 8;
            this.lBGanres.ValueMember = "G_id";
            // 
            // numLen
            // 
            this.numLen.Location = new System.Drawing.Point(101, 54);
            this.numLen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLen.Name = "numLen";
            this.numLen.Size = new System.Drawing.Size(200, 20);
            this.numLen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(158, 202);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cBAlbum
            // 
            this.cBAlbum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bSAlb, "AL_id", true));
            this.cBAlbum.DataSource = this.bSAlb;
            this.cBAlbum.DisplayMember = "AL_name";
            this.cBAlbum.FormattingEnabled = true;
            this.cBAlbum.Location = new System.Drawing.Point(101, 80);
            this.cBAlbum.Name = "cBAlbum";
            this.cBAlbum.Size = new System.Drawing.Size(200, 21);
            this.cBAlbum.TabIndex = 2;
            this.cBAlbum.ValueMember = "AL_id";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(101, 28);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(200, 20);
            this.tBName.TabIndex = 0;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsTableAdapter1
            // 
            this.albumsTableAdapter1.ClearBeforeFill = true;
            // 
            // ganresTableAdapter1
            // 
            this.ganresTableAdapter1.ClearBeforeFill = true;
            // 
            // bSAlb
            // 
            this.bSAlb.DataMember = "Albums";
            this.bSAlb.DataSource = this.dSMusic;
            // 
            // bSGanres
            // 
            this.bSGanres.DataMember = "Ganres";
            this.bSGanres.DataSource = this.dSMusic;
            // 
            // AddSongFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 249);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSongFrm";
            this.Text = "AddSongFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSAlb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSGanres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lBGanres;
        private System.Windows.Forms.NumericUpDown numLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox cBAlbum;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.BindingSource bSGanres;
        private DSMusic dSMusic;
        private System.Windows.Forms.BindingSource bSAlb;
        private DSMusicTableAdapters.AlbumsTableAdapter albumsTableAdapter1;
        private DSMusicTableAdapters.GanresTableAdapter ganresTableAdapter1;
    }
}