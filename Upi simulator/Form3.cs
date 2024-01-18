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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Juhannus_nappi_Click(object sender, EventArgs e)
        {
            Midsummer_button.Enabled = false;

            Form2 video_Player = new Form2(@"Videot\Juhannus.mp4");
            video_Player.Show();
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
                
            }
        }
        //mikro
        private void Sauna_nappi_Click(object sender, EventArgs e)
        {
            Microwawe_button.Enabled = false;

            Form2 video_Player = new Form2(@"Videot\Tupakka.mp4");
            video_Player.Show();
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
                
            }
        }

        private void Pisu_nappi_Click(object sender, EventArgs e)
        {
            Pee_button.Enabled = false;
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"Videot\Vessa.mp4");
            video_Player.Show();
        }

        private void Koko_nappi_Click(object sender, EventArgs e)
        {
            Woman_button.Enabled = false;
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"Videot\Unelma.mp4");
            video_Player.Show();
        }

        private void Tuoli_nappi_Click(object sender, EventArgs e)
        {
            Chair_button.Enabled = false;
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"Videot\Tuoli.mp4");
            video_Player.Show();
        }

        private void Maailmanloppu_nappi_Click(object sender, EventArgs e)
        {
            Gameover_button.Enabled = false;
            if (Midsummer_button.Enabled == false && Microwawe_button.Enabled == false && Pee_button.Enabled == false && Woman_button.Enabled == false && Chair_button.Enabled == false && Gameover_button.Enabled == false)
            {
                Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
                this.Hide();
                form5.Show();
            }
            Form2 video_Player = new Form2(@"Videot\Maailmanloppu.mp4");
            video_Player.Show();
        }
    }
}
