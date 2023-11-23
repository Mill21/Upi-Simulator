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
            {
                InitializeComponent();
            }
        }
        int seconds = 0;

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
            // AVAA VIDEO SOITTIMEN
            Video_Player video_Player = new Video_Player();
            video_Player.ShowDialog();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds += 1;
            if (seconds == 39)
            {
                kela_selvennys_nappi.Enabled = false;
                timer1.Enabled = false;

               
            }
        }
    }
}
