namespace MusicDataBase
{
    partial class AddArtistFrm
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
            this.tBName = new System.Windows.Forms.TextBox();
            this.gBArtist = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCountry = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMusic = new MusicDataBase.DSMusic();
            this.countriesTableAdapter = new MusicDataBase.DSMusicTableAdapters.CountriesTableAdapter();
            this.gBArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(144, 19);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(156, 20);
            this.tBName.TabIndex = 0;
            // 
            // gBArtist
            // 
            this.gBArtist.Controls.Add(this.bAdd);
            this.gBArtist.Controls.Add(this.label2);
            this.gBArtist.Controls.Add(this.label1);
            this.gBArtist.Controls.Add(this.cBCountry);
            this.gBArtist.Controls.Add(this.tBName);
            this.gBArtist.Location = new System.Drawing.Point(50, 32);
            this.gBArtist.Name = "gBArtist";
            this.gBArtist.Size = new System.Drawing.Size(367, 117);
            this.gBArtist.TabIndex = 1;
            this.gBArtist.TabStop = false;
            this.gBArtist.Text = "Add artist";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(129, 88);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // cBCountry
            // 
            this.cBCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "C_id", true));
            this.cBCountry.DataSource = this.bindingSource1;
            this.cBCountry.DisplayMember = "C_name";
            this.cBCountry.FormattingEnabled = true;
            this.cBCountry.Location = new System.Drawing.Point(144, 45);
            this.cBCountry.Name = "cBCountry";
            this.cBCountry.Size = new System.Drawing.Size(156, 21);
            this.cBCountry.TabIndex = 1;
            this.cBCountry.ValueMember = "C_id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Countries";
            this.bindingSource1.DataSource = this.dSMusic;
            // 
            // dSMusic
            // 
            this.dSMusic.DataSetName = "DSMusic";
            this.dSMusic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // AddArtistFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.gBArtist);
            this.Name = "AddArtistFrm";
            this.Text = "AddArtistFrm";
            this.Load += new System.EventHandler(this.AddArtistFrm_Load);
            this.gBArtist.ResumeLayout(false);
            this.gBArtist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.GroupBox gBArtist;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCountry;
        private DSMusicTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DSMusic dSMusic;
    }
}