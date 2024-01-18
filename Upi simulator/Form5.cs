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
    public partial class Form5 : Form
    {
       
        public Form5()
        {
            InitializeComponent();
            Stop_button.Click += Button1_Click;

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            
            foreach (Form form in Application.OpenForms)
            {
                
                
                    formsToClose.Add(form);
                
            }
            foreach (Form form in formsToClose)
            {
                form.Visible = true;  
                form.Close();
            }
        }
    }
}
