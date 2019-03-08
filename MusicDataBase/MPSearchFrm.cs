using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDataBase
{
    public partial class MPSearchFrm : Form
    {
        private int mpID;

        public MPSearchFrm()
        {
            InitializeComponent();
        }

        public MPSearchFrm(int id, string name)
        {
            InitializeComponent();
            mpID = id;
            this.Text = "Music player " + name + " presents such countries and artists";
            mpSearchTA.FillByPlayer(dSMusic.MPSearch, id);
        }

        private void dGVByCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Lol");
            int id = (int)dGVByCountry.CurrentRow.Cells["cidDataGridViewTextBoxColumn"].Value;
            mPASearchTA.Fill(dSMusic.MPASearch, mpID, id);
        }
    }
}
