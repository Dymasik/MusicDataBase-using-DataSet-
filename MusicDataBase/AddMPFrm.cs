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
    public partial class AddMPFrm : Form
    {
        private string name = "";
        private List<int> artists;

        public AddMPFrm()
        {
            InitializeComponent();
            artists = new List<int>();
            artistsTableAdapter.Fill(dSMusic.Artists);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            name = tBName.Text;
            foreach (int i in lBArtists.SelectedIndices)
            {
                DataRowView drv = (DataRowView)lBArtists.Items[i];
                artists.Add((int)drv["A_id"]);
            }
            if (!name.Equals(""))
            {
                this.Close();
            }
        }

        public string GetName() { return name; }

        public List<int> GetArtists() { return artists; }
    }
}
