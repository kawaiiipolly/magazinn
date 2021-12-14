using InternetShop.Script;
using InternetShop.Client;
using InternetShop.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop.OtherForm
{
    public partial class Login : Form
    {
        sqlFunc sql = new sqlFunc();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length == 0 || textBoxPass.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else
            {
                if (sql.LoginUser(textBoxLogin.Text, textBoxPass.Text))
                {
                    Login.ActiveForm.Hide();
                     MainForm main = new MainForm(textBoxLogin.Text);
                     main.ShowDialog();
                    
                }
                else if (textBoxLogin.Text == "admin" && textBoxPass.Text == "admin")
                {
                     Login.ActiveForm.Hide();
                     MainAdminForm main = new MainAdminForm();
                     main.ShowDialog();
                    MessageBox.Show("Првиет админ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            if (reg.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Вы создали аккаунт!");
            }
            else
            {
                MessageBox.Show("Ошибка! Аккаунт не создан");
            }
        }
    }
}
