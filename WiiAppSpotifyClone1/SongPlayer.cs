using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiAppSpotifyClone1
{
    public partial class SongPlayer : Form
    {
        public SongPlayer()
        {
            InitializeComponent();
        }

        private void SongPlayer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDD_SpotifyMusicDataSet1.TBL_SONG' Puede moverla o quitarla según sea necesario.
            this.tBL_SONGTableAdapter.Fill(this.bDD_SpotifyMusicDataSet1.TBL_SONG);

        }
    }
}
