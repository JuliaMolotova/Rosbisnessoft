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
    public partial class FormPO : Form
    {
        public FormPO()
        {
            InitializeComponent();
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            Form formConsultation = new FormConsultation();
            formConsultation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
