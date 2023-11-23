using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upi_simulator
{
    public partial class Video_Player : Form
    {
        public Video_Player()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            media_player.URL = @"C:/Users/s3kuel01/source/repos/Upi simulator/Videot/y2mate.is - Upi ryhdistäytyy ja laittaa asiat kuntoon-X00zekIoPEw-1080pp-1700735740.mp4";
        }

        private void Video_Player_Load(object sender, EventArgs e)
        {
            media_player.settings.autoStart = true;
        }
    }
}
