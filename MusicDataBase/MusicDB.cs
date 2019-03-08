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
    public partial class MusicDB : Form
    {
        public MusicDB()
        {
            InitializeComponent();
        }

        private void MusicDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dSMusic.Ganres". При необходимости она может быть перемещена или удалена.
            this.ganresTableAdapter.Fill(this.dSMusic.Ganres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dSMusic1.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.dSMusic1.Countries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dSMusic1.MusicPlayers". При необходимости она может быть перемещена или удалена.
            this.musicPlayersTableAdapter.Fill(this.dSMusic1.MusicPlayers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dSMusic.Songs". При необходимости она может быть перемещена или удалена.
            this.songsTableAdapter.Fill(this.dSMusic.Songs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dSMusic.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.dSMusic.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dSMusic.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.dSMusic.Artists);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void saveButtonArtist_Click(object sender, EventArgs e)
        {
            artistsTableAdapter.Update(dSMusic.Artists);
        }

        private void deleteButtonArtist_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = (int)dGVArtists.CurrentRow.Cells["aidDataGridViewTextBoxColumn"].Value;
                //MessageBox.Show(id.ToString());
                global::System.Nullable<int> a_count = QTAdapter.CountA_idInAlbums(id);
                //MessageBox.Show(a_count.ToString());
                if(a_count == 0)
                {
                    global::System.Nullable<int> shouldDelete = artistPlayerTableAdapter.NeedDelete(id);
                    if(shouldDelete > 0)
                    {
                        DialogResult res = MessageBox.Show("Are you sure, you want to delete data, it will be impossible to restore data!", "Warning!", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            artistPlayerTableAdapter.DeleteByArt(id);
                            artistsBindingSource.RemoveCurrent();
                            artistsTableAdapter.Update(dSMusic.Artists);
                        }
                    }
                    else
                    {
                        artistsBindingSource.RemoveCurrent();
                    }
                }
                else
                {
                    MessageBox.Show("Error. The deleting is impossible! The artist has albums!", "Error of deleting artist");
                }
            }
            catch 
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void saveButtonAlbum_Click(object sender, EventArgs e)
        {
            albumsTableAdapter.Update(dSMusic.Albums);
        }

        private void deleteButtonAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVAlbums.CurrentRow.Cells["aLidDataGridViewTextBoxColumn"].Value;
                //MessageBox.Show(id.ToString());
                global::System.Nullable<int> al_count = QTAdapter.CountAL_idInSongs(id);
                //MessageBox.Show(a_count.ToString());
                if (al_count == 0)
                {
                    albumsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Error. The deleting is impossible! The album has songs!", "Error of deleting album");
                }
            }
            catch
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void saveButtonSongs_Click(object sender, EventArgs e)
        {
            songsTableAdapter.Update(dSMusic.Songs);
        }

        private void deleteButtonSongs_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVSongs.CurrentRow.Cells["sidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> shouldDelete = sgTA.NeedDelete(id);
                if (shouldDelete > 0)
                {
                    DialogResult res = MessageBox.Show("Are you sure, you want to delete data, it will be impossible to restore data!", "Warning!", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        sgTA.DeleteBySong(id);
                        songsBindingSource.RemoveCurrent();
                        songsTableAdapter.Update(dSMusic.Songs);
                    }
                }
                else
                {
                    songsBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void saveButtonPlayers_Click(object sender, EventArgs e)
        {
            musicPlayersTableAdapter.Update(dSMusic1.MusicPlayers);
        }

        private void deleteButtonPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVPlayers.CurrentRow.Cells["mPidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> shouldDelete = artistPlayerTableAdapter.NeedDeleteP(id);
                if (shouldDelete > 0)
                {
                    DialogResult res = MessageBox.Show("Are you sure, you want to delete data, it will be impossible to restore data!", "Warning!", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        artistPlayerTableAdapter.DeleteByPlayer(id);
                        musicPlayersBindingSource.RemoveCurrent();
                        musicPlayersTableAdapter.Update(dSMusic1.MusicPlayers);
                    }
                }
                else
                {
                    musicPlayersBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void saveButtonCountries_Click(object sender, EventArgs e)
        {
            countriesTableAdapter.Update(dSMusic1.Countries);
        }

        private void deleteButtonCountries_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVCountries.CurrentRow.Cells["cidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> c_count = (int)QTAdapter.CountC_idInArtists(id);
                if (c_count == 0)
                {
                    countriesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Error. The deleting is impossible! The country has artists!", "Error of deleting album");
                }
            }
            catch
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void saveButtonGanres_Click(object sender, EventArgs e)
        {
            ganresTableAdapter.Update(dSMusic.Ganres);
        }

        private void deleteButtonGanres_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVGanres.CurrentRow.Cells["gidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> g_count = (int)QTAdapter.CountG_idInSongGanre(id);
                if (g_count == 0)
                {
                    ganresBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Error. The deleting is impossible! The ganre is connected to songs!", "Error of deleting ganre");
                }
            }
            catch
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void dGVGanres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dGVGanres.CurrentRow.Cells["gidDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVGanres.CurrentRow.Cells["gnameDataGridViewTextBoxColumn"].Value;
                FrmSong frm = new FrmSong(id, name);
                frm.ShowDialog(this);
                frm.Dispose();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void dGVGanres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addButtonArtist_Click(object sender, EventArgs e)
        {
            AddArtistFrm frm = new AddArtistFrm();
            frm.ShowDialog(this);
            string name = frm.GetName();
            int c_id = frm.GetID();
            frm.Dispose();
            DataRow row = dSMusic.Artists.NewRow();
            row["A_countryId"] = c_id;
            row["A_name"] = name;
            dSMusic.Artists.Rows.Add(row);
        }

        private void addButtonAlbum_Click(object sender, EventArgs e)
        {
            AddAlbumFrm frm = new AddAlbumFrm();
            frm.ShowDialog(this);
            string name = frm.GetName();
            int a_id = frm.GetID();
            DateTime date = frm.GetDate();
            frm.Dispose();
            DataRow row = dSMusic.Albums.NewRow();
            row["AL_name"] = name;
            row["AL_date"] = date;
            row["AL_artId"] = a_id;
            dSMusic.Albums.Rows.Add(row);
        }

        private void addButtonSong_Click(object sender, EventArgs e)
        {
            AddSongFrm frm = new AddSongFrm();
            frm.ShowDialog(this);
            string name = frm.GetName();
            int al_id = frm.GetID();
            int len = frm.GetLen();
            List<int> ganres = frm.GetGanres();
            frm.Dispose();
            DataRow row = dSMusic.Songs.NewRow();
            row["S_name"] = name;
            row["S_length"] = len;
            row["S_albId"] = al_id;
            dSMusic.Songs.Rows.Add(row);
            songsTableAdapter.Update(dSMusic.Songs);
            int s_id = (int)row["S_id"];
            foreach(int id in ganres)
            {
                DataRow curRow = dSMusic1.SongGanre.NewRow();
                curRow["SG_songId"] = s_id;
                curRow["SG_ganreId"] = id;
                dSMusic1.SongGanre.Rows.Add(curRow);
            }
            songGanreTableAdapter.Update(dSMusic1.SongGanre);
        }

        private void addButtonCountry_Click(object sender, EventArgs e)
        {
            AddCountryFrm frm = new AddCountryFrm();
            frm.ShowDialog(this);
            string name = frm.GetName();
            frm.Dispose();
            DataRow row = dSMusic1.Countries.NewRow();
            row["C_name"] = name;
            dSMusic1.Countries.Rows.Add(row);
        }

        private void addButtonGanre_Click(object sender, EventArgs e)
        {
            AddGanreFrm frm = new AddGanreFrm();
            frm.ShowDialog(this);
            string name = frm.GetName();
            string info = frm.GetInfo();
            frm.Dispose();
            DataRow row = dSMusic.Ganres.NewRow();
            row["G_name"] = name;
            row["G_info"] = info;
            dSMusic.Ganres.Rows.Add(row);
        }

        private void addButtonService_Click(object sender, EventArgs e)
        {
            AddMPFrm frm = new AddMPFrm();
            frm.ShowDialog(this);
            string name = frm.GetName();
            List<int> artists = frm.GetArtists();
            frm.Dispose();
            DataRow row = dSMusic1.MusicPlayers.NewRow();
            row["MP_name"] = name;
            dSMusic1.MusicPlayers.Rows.Add(row);
            musicPlayersTableAdapter.Update(dSMusic1.MusicPlayers);
            int mp_id = (int)row["MP_id"];
            foreach (int id in artists)
            {
                DataRow curRow = dSMusic1.ArtistPlayer.NewRow();
                curRow["AP_playerId"] = mp_id;
                curRow["AP_artId"] = id;
                dSMusic1.ArtistPlayer.Rows.Add(curRow);
            }
            artistPlayerTableAdapter.Update(dSMusic1.ArtistPlayer);
        }

        private void dGVCountries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dGVCountries.CurrentRow.Cells["cidDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVCountries.CurrentRow.Cells["cnameDataGridViewTextBoxColumn"].Value;
                ArtistByCountryFrm frm = new ArtistByCountryFrm(id, name);
                frm.ShowDialog(this);
                frm.Dispose();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void dGVPlayers_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dGVPlayers.CurrentRow.Cells["mPidDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVPlayers.CurrentRow.Cells["mPnameDataGridViewTextBoxColumn"].Value;
                MPSearchFrm frm = new MPSearchFrm(id, name);
                frm.ShowDialog(this);
                frm.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you make double click in contents of Artist table or Country table or Ganre table or Players table you will have a chance to make some search by this parametrs!");
        }
    }
}
