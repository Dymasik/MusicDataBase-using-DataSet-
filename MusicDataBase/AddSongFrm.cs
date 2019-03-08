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
    public partial class AddSongFrm : Form
    {
        private string name = "";
        private int albID = -1;
        private int len = 0;
        private List<int> ganres;

        public AddSongFrm()
        {
            ganres = new List<int>();
            InitializeComponent();
            albumsTableAdapter1.Fill(dSMusic.Albums);
            ganresTableAdapter1.Fill(dSMusic.Ganres);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!tBName.Text.Equals(""))
                name = tBName.Text;
            albID = (int)(bSAlb.Current as DataRowView)["AL_id"];
            len = (int)numLen.Value;
            foreach(int i in lBGanres.SelectedIndices)
            {
                DataRowView drv = (DataRowView)lBGanres.Items[i];
                ganres.Add((int)drv["G_id"]);
            }
            if (name != "" && albID != -1)
            {
                //this.Dispose();
                this.Close();
            }
        }

        public string GetName() { return name; }

        public int GetID() { return albID; }

        public int GetLen() { return len; }

        public List<int> GetGanres() { return ganres; }
    }
}
