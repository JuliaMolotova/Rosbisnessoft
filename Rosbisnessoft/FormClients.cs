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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowСlients();
        }

        void ShowСlients()
        {
            listViewClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.росбизнессофт.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.Id.ToString(), clientsSet.Business, clientsSet.FIO, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClients.Items.Add(item);
            }
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsSet clientsSet = new ClientsSet();
            clientsSet.Business = textBoxBusiness.Text;
            clientsSet.FIO = textBoxFIO.Text;
            clientsSet.Phone = textBoxPhone.Text;
            clientsSet.Email = textBoxEmail.Text;
            Program.росбизнессофт.ClientsSet.Add(clientsSet);
            Program.росбизнессофт.SaveChanges();
            ShowСlients();
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                textBoxBusiness.Text = clientsSet.Business;
                textBoxFIO.Text = clientsSet.FIO;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                textBoxBusiness.Text = "";
                textBoxFIO.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                clientsSet.Business = textBoxBusiness.Text;
                clientsSet.FIO = textBoxFIO.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.росбизнессофт.SaveChanges();
                ShowСlients();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                    Program.росбизнессофт.ClientsSet.Remove(clientsSet);
                    Program.росбизнессофт.SaveChanges();
                    ShowСlients();
                }
                textBoxBusiness.Text = "";
                textBoxFIO.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

