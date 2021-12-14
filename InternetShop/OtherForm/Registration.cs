using InternetShop.Script;
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
    public partial class Registration : Form
    {
        sqlFunc sql = new sqlFunc();
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string rndId = rnd.Next(1000,99999).ToString();
            if (textBoxLogin.Text.Length == 0 || textBoxPass.Text.Length == 0 || textBoxName.Text.Length == 0 || textBoxPhone.Text.Length == 0 )
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else if (sql.RegUser(rndId,textBoxLogin.Text, textBoxPass.Text, textBoxName.Text, textBoxPhone.Text))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }


        }
    }
}
