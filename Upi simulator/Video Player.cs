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
        private bool messageBoxShown = false;
        private Form1 parentForm;
        private int fixedHeight = 490;
        private int fixedWidth = 815;
        private bool firstoVideoEnded = false;
        private string secondVideoPath;

        public Video_Player(string videoPath, string firstvideopath, string secoundvideopath, Form1 parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;

            
            axWindowsMediaPlayer1.URL = videoPath;
           
            axWindowsMediaPlayer1.settings.setMode("loop", false);
            axWindowsMediaPlayer1.stretchToFit = false;
            this.Resize += Video_Player_Resize;


            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;

            
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
           
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.close();


                if (!messageBoxShown)
                {
                    MessageBox.Show("Video has ended!");
                    messageBoxShown = true; 
                }
                this.Close();
            }
        }
         private void Video_Player_Resize(object sender, EventArgs e)
        {
            
            this.Size = new Size(fixedWidth, fixedHeight);
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void Video_Player_Load(object sender, EventArgs e)
        {


        }
    }
}