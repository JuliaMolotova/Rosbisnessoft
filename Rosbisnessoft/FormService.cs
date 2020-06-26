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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
            ShowService();
        }

        void ShowService()
        {
            listViewService.Items.Clear();
            foreach (Service service in Program.росбизнессофт.Service)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    service.Id.ToString(), service.Variety, service.Spectrum, service.Software, service.Level3, service.Price
                });
                item.Tag = service;
                listViewService.Items.Add(item);
            }
            listViewService.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Service Service = new Service();
            Service.Variety = textBoxVariety.Text;
            Service.Spectrum = textBoxSpectrum.Text;
            Service.Software = textBoxSoftware.Text;
            Service.Level3 = textBoxLevel3.Text;
            Service.Price = textBoxPrice.Text;
            Program.росбизнессофт.Service.Add(Service);
            Program.росбизнессофт.SaveChanges();
            ShowService();
        }

        private void listViewService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewService.SelectedItems.Count == 1)
            {
                Service service = listViewService.SelectedItems[0].Tag as Service;
                textBoxVariety.Text = service.Variety;
                textBoxSpectrum.Text = service.Spectrum;
                textBoxSoftware.Text = service.Software;
                textBoxLevel3.Text = service.Level3;
                textBoxPrice.Text = service.Price;
            }
            else
            {
                textBoxVariety.Text = "";
                textBoxSpectrum.Text = "";
                textBoxSoftware.Text = "";
                textBoxLevel3.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewService.SelectedItems.Count == 1)
            {
                Service service = listViewService.SelectedItems[0].Tag as Service;
                service.Variety = textBoxVariety.Text;
                service.Spectrum = textBoxSpectrum.Text;
                service.Software = textBoxSoftware.Text;
                service.Level3 = textBoxLevel3.Text;
                service.Price = textBoxPrice.Text;
                Program.росбизнессофт.SaveChanges();
                ShowService();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewService.SelectedItems.Count == 1)
                {
                    Service service = listViewService.SelectedItems[0].Tag as Service;
                    Program.росбизнессофт.Service.Remove(service);
                    Program.росбизнессофт.SaveChanges();
                    ShowService();
                }
                textBoxVariety.Text = "";
                textBoxSpectrum.Text = "";
                textBoxSoftware.Text = "";
                textBoxLevel3.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
