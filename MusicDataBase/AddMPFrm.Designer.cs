namespace MusicDataBase
{
    partial class AddMPFrm
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
            this.bAdd = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lBArtists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic = new MusicDataBase.DSMusic();
            this.artistsTableAdapter = new MusicDataBase.DSMusicTableAdapters.ArtistsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lBArtists);
            this.groupBox1.Controls.Add(this.tBName);
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add music player";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(161, 158);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(204, 54);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(168, 20);
            this.tBName.TabIndex = 1;
            // 
            // lBArtists
            // 
            this.lBArtists.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "A_id", true));
            this.lBArtists.DataSource = this.bindingSource;
            this.lBArtists.DisplayMember = "A_name";
            this.lBArtists.FormattingEnabled = true;
            this.lBArtists.Location = new System.Drawing.Point(204, 80);
            this.lBArtists.Name = "lBArtists";
            this.lBArtists.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBArtists.Size = new System.Drawing.Size(168, 56);
            this.lBArtists.TabIndex = 2;
            this.lBArtists.ValueMember = "A_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Artists";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Artists";
            this.bindingSource.DataSource = this.dSMusic;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // AddMPFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMPFrm";
            this.Text = "AddMPFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBArtists;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.BindingSource bindingSource;
        private DSMusic dSMusic;
        private DSMusicTableAdapters.ArtistsTableAdapter artistsTableAdapter;
    }
}