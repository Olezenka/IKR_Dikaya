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
    public partial class SoldItem_Form : Form
    {
        public SoldItem_Form()
        {
            InitializeComponent();
        }

        private void SoldItem_Load(object sender, EventArgs e)
        {
            labelFIO.Text = Autorizaciya.sotrName;
            labelRole.Text = Autorizaciya.sotrRole;
            dataGridView1.DataSource = Autorizaciya.DB.Sold_item.ToList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
