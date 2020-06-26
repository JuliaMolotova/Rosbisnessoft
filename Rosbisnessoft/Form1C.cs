using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosbisnessoft
{
    public partial class Form1C : Form
    {
        public Form1C()
        {
            InitializeComponent();
        }

        private void buttonNastr_Click(object sender, EventArgs e)
        {
            Form formnNastr = new FormNastr();
            formnNastr.Show();
        }

        private void buttonObsl_Click(object sender, EventArgs e)
        {
            Form formObsl = new FormObsl();
            formObsl.Show();
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            Form formProd = new FormProd();
            formProd.Show();
        }
    }
}
