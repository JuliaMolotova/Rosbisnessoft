﻿using System;
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
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }

    public partial class FormAuthorization : Form
    {
        public static User users = new User();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.росбизнессофт.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.login = user.Password;
                        users.type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Данные введены неверно", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }

            }
        }
    }
}
