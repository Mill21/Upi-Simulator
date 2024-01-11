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
        //start button
        private void button3_Click(object sender, EventArgs e)
        {

            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault() ?? new Form3();
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Hökäle start.mp4", this);
            form3.Show();
            video_Player.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kela_selvennys_nappi_Click(object sender, EventArgs e)
        {
            kela_selvennys_nappi.Enabled = false;

            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Kela.mp4", this);
            video_Player.Show();
            if (kela_selvennys_nappi.Enabled == false && hanki_juomat_nappi.Enabled == false && pizza_nappi.Enabled == false)
            {
                start.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hanki_juomat_nappi_Click(object sender, EventArgs e)
        {
            hanki_juomat_nappi.Enabled = false;
            MessageBox.Show("Olet spuge eikä sinulla ole rahaa. Päätät piilottaa juomia kaikkiin taskuihisi.");
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Juomat.mp4");
            video_Player.Show();
            if (kela_selvennys_nappi.Enabled == false && hanki_juomat_nappi.Enabled == false && pizza_nappi.Enabled == false)
            {
                start.Enabled = true;
            }



        }

        private void pizza_nappi_Click(object sender, EventArgs e)
        {
            pizza_nappi.Enabled = false;
            Form2 video_Player = new Form2(@"C:\Users\s3kuel01\source\repos\Upi simulator\Videot\Upi löytää pizzan.mp4");
            video_Player.Show();
            if (kela_selvennys_nappi.Enabled == false && hanki_juomat_nappi.Enabled == false && pizza_nappi.Enabled == false)
            {
                start.Enabled = true;
            }

        }
    }
}
