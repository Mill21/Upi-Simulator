using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upi_simulator
{
    public partial class Form5 : Form
    {
        private SoundPlayer soundPlayer;
        private bool isMusicPlaying = true;

        public Form5()
        {
            InitializeComponent();
            Stop_button.Click += Button1_Click;

            // Initialize and start playing the music in a loop
            soundPlayer = new SoundPlayer(@"Videot/aloitusbiisi.wav");
            Task.Run(() => PlayMusicLoop());
        }

        private void PlayMusicLoop()
        {
            while (isMusicPlaying)
            {
                if (!soundPlayer.IsLoadCompleted)
                {
                    soundPlayer.Load();  // Ensure the sound is loaded before playing
                }

                soundPlayer.PlaySync();  // Play the music synchronously
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Stop the music when the button is clicked
            isMusicPlaying = false;

            // Close all forms except the current one
            List<Form> formsToClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    formsToClose.Add(form);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Visible = true;
                form.Close();
            }

        }
    }
}
