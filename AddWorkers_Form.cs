using IKR_Dikaya.FolderModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKR_Dikaya
{
    public partial class AddWorkers_Form : Form
    {
        public AddWorkers_Form()
        {
            InitializeComponent();
        }

        private void AddWorkers_Form_Load(object sender, EventArgs e)
        {
            var roles = Autorizaciya.DB.Roles.ToList();
            comboBox1.DisplayMember = "Role";
            comboBox1.DataSource = roles;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (first_NameTextBox.Text == "" || second_NameTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "" || comboBox1.Text == "" || middle_NameTextBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            else
            {
                Workers workers = Autorizaciya.DB.Workers.SingleOrDefault(x => x.Login == loginTextBox.Text);
                if (workers != null)
                {
                    MessageBox.Show("Пользователь с данным логином уже существует!");
                    return;
                }
                else
                {
                    workers = new Workers();
                    workers.Login = loginTextBox.Text;
                    workers.Password = passwordTextBox.Text;
                    workers.First_Name = first_NameTextBox.Text;
                    workers.Second_Name = second_NameTextBox.Text;
                    workers.Middle_Name = middle_NameTextBox.Text;
                    workers.Role = comboBox1.Text;

                    Autorizaciya.DB.Workers.Add(workers);
                    MessageBox.Show("Сотрудник успешно добавлен!");
                    Autorizaciya.DB.SaveChanges();
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    first_NameTextBox.Text = "";
                    second_NameTextBox.Text = "";
                    middle_NameTextBox.Text = "";
                    comboBox1.DataSource = null;
                    return;

                }
            }
        }

        private void rolesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void second_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
