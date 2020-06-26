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
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void buttonPO_Click(object sender, EventArgs e)
        {
            Form formPO = new FormPO();
            formPO.Show();
        }

        private void button1C_Click(object sender, EventArgs e)
        {
            Form form1C = new Form1C();
            form1C.Show();
        }

        private void buttonAvt_Click(object sender, EventArgs e)
        {
            Form formAvt = new FormAvt();
            formAvt.Show();
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            Form formConsultation = new FormConsultation();
            formConsultation.Show();
        }
    }
}
