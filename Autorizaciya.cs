using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKR_Dikaya.FolderModel;

namespace IKR_Dikaya
{
    public partial class Autorizaciya : Form
    {
        public static Model1 DB = new Model1();
        public string sotrName = "";
        public string sotrRole = "";
        public Autorizaciya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            else
            {
                Workers worker = DB.Workers.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
                if (worker != null)
                {
                    sotrName = worker.First_Name;
                    sotrRole = worker.Role;
                    if (sotrRole == "Administrator")
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка в логине или пароле!");
                    return;
                }
            }
        }
    }
}
