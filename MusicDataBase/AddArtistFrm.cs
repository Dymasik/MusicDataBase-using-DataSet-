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
    public partial class AddArtistFrm : Form
    {
        private string name = "";
        private int countryID = -1;

        public AddArtistFrm()
        {
            InitializeComponent();
        }

        private void AddArtistFrm_Load(object sender, EventArgs e)
        {
            countriesTableAdapter.Fill(dSMusic.Countries);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!tBName.Text.Equals(""))
                name = tBName.Text;
            countryID = (int)(bindingSource1.Current as DataRowView)["C_id"];
            if(name != "" && countryID != -1)
            {
                //this.Dispose();
                this.Close();
            }
        }

        public string GetName() { return name; }
        public int GetID() { return countryID; }
    }
}
