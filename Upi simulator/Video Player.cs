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
    public partial class Form2 : Form
    {
        
        private readonly Form1 parentForm;
        private readonly int fixedHeight = 490;
        private readonly int fixedWidth = 815;
        public Form2(string videoPath, Form1 parentForm=null)
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
                this.Close();
            }
        }
         private void Video_Player_Resize(object sender, EventArgs e)
        {
            
            this.Size = new Size(fixedWidth, fixedHeight);
        }


        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void Video_Player_Load(object sender, EventArgs e)
        {


        }
    }
}