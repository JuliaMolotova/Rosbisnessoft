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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "admin") { buttonConsultation.Enabled = false; }
            if (FormAuthorization.users.type == "agent") { buttonClients.Enabled = false; buttonAgents.Enabled = false; buttonOrder.Enabled = false; buttonService.Enabled = false; }
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form formClients = new FormClients();
            formClients.Show();

        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form formAgents = new FormAgents();
            formAgents.Show();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            Form formService = new FormService();
            formService.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormOrder();
            formOrder.Show();
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            Form formConsultation = new FormConsultation();
            formConsultation.Show();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            Form formInformation = new FormInformation();
            formInformation.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
