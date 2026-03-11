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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            labelFIO.Text = "Добро пожаловать, " + Autorizaciya.sotrName;
            NameButton(Autorizaciya.sotrRole);
        }
        private void NameButton(string role)
        {
            if (role == "Administrator")
            {
                buttonMenu.Text = "Товары";
                labelRole.Text = "Администратор";
                Autorizaciya.sotrRole = "Администратор";
            }
            if (role == "Seller")
            {
                buttonMenu.Text = "Проданный товар";
                labelRole.Text = "Продавец";
                Autorizaciya.sotrRole = "Продавец";
            }
            if (role == "Director")
            {
                buttonMenu.Text = "Сотрудники";
                labelRole.Text = "Директор";
                Autorizaciya.sotrRole = "Директор";
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (Autorizaciya.sotrRole == "Администратор")
            {
                Goods_Form goods_form = new Goods_Form();
                goods_form.ShowDialog();
            }
            if (Autorizaciya.sotrRole == "Продавец")
            {
                SoldItem_Form soldItem = new SoldItem_Form();
                soldItem.ShowDialog();
            }
            if (Autorizaciya.sotrRole == "Директор")
            {
                Workers_Form workers_Form = new Workers_Form();
                workers_Form.ShowDialog();
            }
        }
    }
}
