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
    public partial class GoodsTitle : UserControl
    {
        private Goods _goods;
        private Model1 model = new Model1();

        public void Fill(Goods goods)
        {
            _goods = goods;
            labelId.Text = "ID: " + _goods.ID.ToString();
            labelName.Text = _goods.Name;
            pictureBox1.Image = null;

            try
            {
                if (_goods.Image != null && _goods.Image.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(_goods.Image))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = IKR_Dikaya.Properties.Resources.Default;
                }
            }
            catch
            {
                pictureBox1.Image = IKR_Dikaya.Properties.Resources.Default;
            }
        }

        public GoodsTitle(Goods goods)
        {
            InitializeComponent();
            Fill(goods);
        }

        private void GoodsTitle_Load(object sender, EventArgs e)
        {

        }
    }
}
