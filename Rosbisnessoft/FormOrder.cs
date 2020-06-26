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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowService();
            ShowOrder();
        }

        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentSet in Program.росбизнессофт.AgentsSet)
            {
                string[] item = { agentSet.Id.ToString() + ". ", "" + agentSet.FIO };
                comboBoxAgents.Items.Add(string.Join("", item));
            }
        }

        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.росбизнессофт.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ". ", "" + clientsSet.FIO };
                comboBoxClients.Items.Add(string.Join("", item));
            }
        }

        void ShowService()
        {
            comboBoxService.Items.Clear();
            foreach (Service service in Program.росбизнессофт.Service)
            {
                string[] item = { service.Id.ToString() + ". ", "" + service.Variety };
                comboBoxService.Items.Add(string.Join("", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxService.SelectedItem != null && textBoxDateStart.Text != "" && textBoxDateEnd.Text!="")
            {
                Orders orders = new Orders();
                orders.IdClients = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                orders.IdAgents = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                orders.IdService = Convert.ToInt32(comboBoxService.SelectedItem.ToString().Split('.')[0]);
                orders.DateStart = textBoxDateStart.Text;
                orders.DateEnd = textBoxDateEnd.Text;
                Program.росбизнессофт.Orders.Add(orders);
                Program.росбизнессофт.SaveChanges();
                ShowOrder();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowOrder()
        {
            listViewOrder.Items.Clear();
            foreach (Orders orders in Program.росбизнессофт.Orders)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                orders.IdClients.ToString(),
                orders.ClientsSet.FIO,
                orders.IdAgents.ToString(),
                orders.AgentsSet.FIO,
                orders.IdService.ToString(),
                orders.Service.Variety,
                orders.DateStart,
                orders.DateEnd
                });
                item.Tag = orders;
                listViewOrder.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                Orders orders = listViewOrder.SelectedItems[0].Tag as Orders;
                orders.IdClients = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                orders.IdAgents = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                orders.IdService = Convert.ToInt32(comboBoxService.SelectedItem.ToString().Split('.')[0]);
                orders.DateStart = textBoxDateStart.Text;
                orders.DateEnd = textBoxDateEnd.Text;
                Program.росбизнессофт.SaveChanges();
                ShowOrder();
            }
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                Orders orders = listViewOrder.SelectedItems[0].Tag as Orders;
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(orders.IdClients.ToString());
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(orders.IdAgents.ToString());
                comboBoxService.SelectedIndex = comboBoxService.FindString(orders.IdService.ToString());
            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                comboBoxService.SelectedItem = null;
                textBoxDateStart.Text = "";
                textBoxDateEnd.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    Orders orders = listViewOrder.SelectedItems[0].Tag as Orders;
                    Program.росбизнессофт.Orders.Remove(orders);
                    Program.росбизнессофт.SaveChanges();
                    ShowOrder();
                }
                comboBoxClients.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                comboBoxService.SelectedItem = null;
                textBoxDateStart.Text = "";
                textBoxDateEnd.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
