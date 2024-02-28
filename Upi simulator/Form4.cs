using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Upi_simulator
{
    public partial class Startup : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();


        public Startup()
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer(@"Videot/aloitusbiisi.wav");


        }

        private void Startup_nappi_Click(object sender, EventArgs e)
        {


            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault() ?? new Form1();
            form1.Show();
            this.Hide();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Startup_Load(object sender, EventArgs e)
        {
            // Form load logic here, if needed
        }



        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


    }
}
