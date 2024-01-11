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
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void startup_nappi_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault() ?? new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
