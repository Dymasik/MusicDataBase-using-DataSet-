namespace MusicDataBase
{
    partial class AddAlbumFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cBArtist = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic = new MusicDataBase.DSMusic();
            this.tBName = new System.Windows.Forms.TextBox();
            this.artistsTableAdapter = new MusicDataBase.DSMusicTableAdapters.ArtistsTableAdapter();
            this.dTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.cBArtist);
            this.groupBox1.Controls.Add(this.dTime);
            this.groupBox1.Controls.Add(this.tBName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of release";
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
            this.addBtn.Location = new System.Drawing.Point(146, 129);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cBArtist
            // 
            this.cBArtist.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "A_id", true));
            this.cBArtist.DataSource = this.bindingSource1;
            this.cBArtist.DisplayMember = "A_name";
            this.cBArtist.FormattingEnabled = true;
            this.cBArtist.Location = new System.Drawing.Point(101, 80);
            this.cBArtist.Name = "cBArtist";
            this.cBArtist.Size = new System.Drawing.Size(200, 21);
            this.cBArtist.TabIndex = 2;
            this.cBArtist.ValueMember = "A_id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Artists";
            this.bindingSource1.DataSource = this.dSMusic;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(101, 28);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(200, 20);
            this.tBName.TabIndex = 0;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // dTime
            // 
            this.dTime.Location = new System.Drawing.Point(101, 54);
            this.dTime.Name = "dTime";
            this.dTime.Size = new System.Drawing.Size(200, 20);
            this.dTime.TabIndex = 1;
            // 
            // AddAlbumFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAlbumFrm";
            this.Text = "AddAlbumFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox cBArtist;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DSMusic dSMusic;
        private DSMusicTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.DateTimePicker dTime;
    }
}