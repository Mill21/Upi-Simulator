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


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //start button
        private void Button3_Click(object sender, EventArgs e)
        {

            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault() ?? new Form3();
            Form2 video_Player = new Form2(@"Videot\Hökäle start.mp4", this);
            form3.Show();
            video_Player.Show();
            this.Hide();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Kela_selvennys_nappi_Click(object sender, EventArgs e)
        {
            kela_button.Enabled = false;

            Form2 video_Player = new Form2(@"Videot\Kela.mp4", this);
            video_Player.Show();
            if (kela_button.Enabled == false && Drink_button.Enabled == false && Pizza_button.Enabled == false)
            {
                Start_button.Enabled = true;
                if (Application.OpenForms["Form4"] != null)
                {
                    Application.OpenForms["Form4"].Close();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hanki_juomat_nappi_Click(object sender, EventArgs e)
        {
            Drink_button.Enabled = false;
            MessageBox.Show("Olet spuge eikä sinulla ole rahaa. Päätät piilottaa juomia kaikkiin taskuihisi.");
            Form2 video_Player = new Form2(@"Videot\Juomat.mp4");
            video_Player.Show();
            if (kela_button.Enabled == false && Drink_button.Enabled == false && Pizza_button.Enabled == false)
            {
                Start_button.Enabled = true;
            }



        }

        private void Pizza_nappi_Click(object sender, EventArgs e)
        {
            Pizza_button.Enabled = false;
            Form2 video_Player = new Form2(@"Videot\Upi löytää pizzan.mp4");
            video_Player.Show();
            if (kela_button.Enabled == false && Drink_button.Enabled == false && Pizza_button.Enabled == false)
            {
                Start_button.Enabled = true;
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
