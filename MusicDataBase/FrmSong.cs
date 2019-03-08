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
    public partial class FrmSong : Form
    {
        private int ganreId;
        private string ganreName;

        public FrmSong()
        {
            InitializeComponent();
        }

        public FrmSong(int ganreId, string ganreName)
        {
            InitializeComponent();
            this.Text = "Songs of ganre: " + ganreName;
            this.ganreId = ganreId;
            this.ganreName = ganreName;
            findSongs();
        }

        private void FrmSong_Load(object sender, EventArgs e)
        {

        }

        private void findSongs()
        {
            if (!cBName.Checked && !cBArtist.Checked && !cBAlbum.Checked && !cBLen.Checked)
            {
                dtSongsOfGanreTableAdapter.FillByGanre(dSMusic.DTSongsOfGanre, ganreId);
            }
            else
            {
                string findName = "";
                string findALb = "";
                string findArt = "";
                int low = (int)lowerBound.Value;
                int hi = (int)upperBound.Value;
                if (cBName.Checked)
                {
                    findName = "%" + tBName.Text + "%";
                    if (cBAlbum.Checked)
                    {
                        findALb = "%" + tBAlbum.Text + "%";
                        if (cBArtist.Checked)
                        {
                            findArt = "%" + tBArtist.Text + "%";
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByNameAlbumArtistBounds(dSMusic.DTSongsOfGanre, ganreId, findName, findALb, findArt, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByNameAlbumArtist(dSMusic.DTSongsOfGanre, ganreId, findName, findALb, findArt);
                            }
                        }
                        else
                        {
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByNameAlbumBounds(dSMusic.DTSongsOfGanre, ganreId, findName, findALb, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByNameAlbum(dSMusic.DTSongsOfGanre, ganreId, findName, findALb);
                            }
                        }
                    }
                    else
                    {
                        if (cBArtist.Checked)
                        {
                            findArt = "%" + tBArtist.Text + "%";
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByNameArtistBounds(dSMusic.DTSongsOfGanre, ganreId, findName, findArt, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByNameArtist(dSMusic.DTSongsOfGanre, ganreId, findName, findArt);
                            }
                        }
                        else
                        {
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByNameBounds(dSMusic.DTSongsOfGanre, ganreId, findName, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByName(dSMusic.DTSongsOfGanre, ganreId, findName);
                            }
                        }
                    }
                }
                else
                {
                    if (cBAlbum.Checked)
                    {
                        findALb = "%" + tBAlbum.Text + "%";
                        if (cBArtist.Checked)
                        {
                            findArt = "%" + tBArtist.Text + "%";
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByAlbumArtistBounds(dSMusic.DTSongsOfGanre, ganreId, findALb, findArt, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByAlbumArtist(dSMusic.DTSongsOfGanre, ganreId, findALb, findArt);
                            }
                        }
                        else
                        {
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByAlbumBounds(dSMusic.DTSongsOfGanre, ganreId, findALb, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByAlbum(dSMusic.DTSongsOfGanre, ganreId, findALb);
                            }
                        }
                    }
                    else
                    {
                        if (cBArtist.Checked)
                        {
                            findArt = "%" + tBArtist.Text + "%";
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByArtistBounds(dSMusic.DTSongsOfGanre, ganreId, findArt, hi, low);
                            }
                            else
                            {
                                dtSongsOfGanreTableAdapter.FillByArtist(dSMusic.DTSongsOfGanre, ganreId, findArt);
                            }
                        }
                        else
                        {
                            if (cBLen.Checked)
                            {
                                dtSongsOfGanreTableAdapter.FillByBounds(dSMusic.DTSongsOfGanre, ganreId, hi, low);
                            }
                        }
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            findSongs();
        }

        private void searchParametrs_Enter(object sender, EventArgs e)
        {

        }

        private void dGVSongSearch_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dGVSongSearch.Rows[e.RowIndex].Cells["sidDataGridViewTextBoxColumn"].Value;
                //MessageBox.Show(id.ToString());
                albumsSearchTableAdapter.Fill(dSMusic.AlbumsSearch, id);
            }
            catch
            {

            }
        }

    }
}
