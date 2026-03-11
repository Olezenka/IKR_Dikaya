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
    public partial class Workers_Form : Form
    {
        public Workers_Form()
        {
            InitializeComponent();
        }

        private void Workers_Form_Load(object sender, EventArgs e)
        {
            LoadData();
            labelFIO.Text = Autorizaciya.sotrName;
            labelRole.Text = Autorizaciya.sotrRole;
        }
        private void LoadData()
        {
            dataGridView1.DataSource = Autorizaciya.DB.Workers.ToList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Autorizaciya.DB.SaveChanges();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Workers workers = Autorizaciya.DB.Workers.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            Autorizaciya.DB.Workers.Remove(workers);
            Autorizaciya.DB.SaveChanges();
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddWorkers_Form addWorkers_Form = new AddWorkers_Form();
            addWorkers_Form.ShowDialog();
            LoadData();
        }
    }
}
