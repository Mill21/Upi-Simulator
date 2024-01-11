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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void juhannus_nappi_Click(object sender, EventArgs e)
        {
            juhannus_nappi.Enabled = false;

            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Juhannus.mp4");
            video_Player.Show();
            if (juhannus_nappi.Enabled == false && mikro_nappi.Enabled == false && pisu_nappi.Enabled == false && emanta_nappi.Enabled == false && tuoli_nappi.Enabled == false && maailmanloppu_nappi.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
        }
        //mikro
        private void sauna_nappi_Click(object sender, EventArgs e)
        {
            mikro_nappi.Enabled = false;

            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Tupakka.mp4");
            video_Player.Show();
            if (juhannus_nappi.Enabled == false && mikro_nappi.Enabled == false && pisu_nappi.Enabled == false && emanta_nappi.Enabled == false && tuoli_nappi.Enabled == false && maailmanloppu_nappi.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
        }

        private void pisu_nappi_Click(object sender, EventArgs e)
        {
            pisu_nappi.Enabled = false;
            if (juhannus_nappi.Enabled == false && mikro_nappi.Enabled == false && pisu_nappi.Enabled == false && emanta_nappi.Enabled == false && tuoli_nappi.Enabled == false && maailmanloppu_nappi.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Vessa.mp4");
            video_Player.Show();
        }

        private void koko_nappi_Click(object sender, EventArgs e)
        {
            emanta_nappi.Enabled = false;
            if (juhannus_nappi.Enabled == false && mikro_nappi.Enabled == false && pisu_nappi.Enabled == false && emanta_nappi.Enabled == false && tuoli_nappi.Enabled == false && maailmanloppu_nappi.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Unelma.mp4");
            video_Player.Show();
        }

        private void tuoli_nappi_Click(object sender, EventArgs e)
        {
            tuoli_nappi.Enabled = false;
            if (juhannus_nappi.Enabled == false && mikro_nappi.Enabled == false && pisu_nappi.Enabled == false && emanta_nappi.Enabled == false && tuoli_nappi.Enabled == false && maailmanloppu_nappi.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Tuoli.mp4");
            video_Player.Show();
        }

        private void maailmanloppu_nappi_Click(object sender, EventArgs e)
        {
            maailmanloppu_nappi.Enabled = false;
            if (juhannus_nappi.Enabled == false && mikro_nappi.Enabled == false && pisu_nappi.Enabled == false && emanta_nappi.Enabled == false && tuoli_nappi.Enabled == false && maailmanloppu_nappi.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Maailmanloppu.mp4");
            video_Player.Show();
        }
    }
}
