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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kela_selvennys_nappi_Click(object sender, EventArgs e)
        {
            kela_selvennys_nappi.Enabled = false;

            Video_Player video_Player = new Video_Player(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Kela.mp4", this);
            video_Player.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hanki_juomat_nappi_Click(object sender, EventArgs e)
        {
            hanki_juomat_nappi.Enabled = false;
            MessageBox.Show("Olet spuge eikä sinulla ole rahaa. Päätät piilottaa juomia kaikkiin taskuihisi.");
            Video_Player video_Player = new Video_Player(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Juomat.mp4", @"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Pizza_start.mp4");
            video_Player.Show();
           
        }
    }
}
