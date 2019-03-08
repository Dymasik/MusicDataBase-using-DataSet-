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
    public partial class ArtistByCountryFrm : Form
    {
        public ArtistByCountryFrm()
        {
            InitializeComponent();
        }

        public ArtistByCountryFrm(int id, string name)
        {
            InitializeComponent();
            artistsSearchTA.FillByCountry(dSMusic.ArtistsSearch, id);
            this.Text = "Artists from " + name;
        }

        private void ArtistByCountryFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
