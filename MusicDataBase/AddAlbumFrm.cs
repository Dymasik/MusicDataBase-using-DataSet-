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
    public partial class AddAlbumFrm : Form
    {
        private string name = "";
        private int artID = -1;
        private DateTime date;

        public AddAlbumFrm()
        {
            InitializeComponent();
            artistsTableAdapter.Fill(dSMusic.Artists);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!tBName.Text.Equals(""))
                name = tBName.Text;
            artID = (int)(bindingSource1.Current as DataRowView)["A_id"];
            date = (DateTime)dTime.Value;
            if (name != "" && artID != -1)
            {
                //this.Dispose();
                this.Close();
            }
        }

        public string GetName()
        {
            return name;
        }

        public int GetID() { return artID; }

        public DateTime GetDate() { return date; }
    }
}
