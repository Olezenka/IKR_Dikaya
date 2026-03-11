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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IKR_Dikaya
{
    public partial class Goods_Form : Form
    {
        private enum SvipeType
        {
            Left,
            Right
        }
        private List<Goods> goods = new List<Goods>();
        private int SvipeID;
        private void Loadproducts()
        {
            goods.Clear();
            SvipeID = 0;
            goods = Autorizaciya.DB.Goods.ToList();
        }
        private void SetTextlabel()
        {
            if (goods.Count != 0)
            {
                labelCount.Text = goods.Count >= 6 ?
                $"c {SvipeID + 1} по {SvipeID + 6} из {goods.Count} Товаров" :
                $"c 1 по {goods.Count} Товаров";
            }   
            else
            {
                labelCount.Text = $"c 0 из {goods.Count} Товаров";
            }
        }
        private void CreateTitle()
        {
            flowLayoutPanel1.Controls.Clear();
            SetTextlabel();

            for (int i = 0; i < 6; i++)
            {
                int currentIndex = SvipeID + i;
                if (currentIndex < goods.Count)
                {
                    GoodsTitle tile = new GoodsTitle(goods[currentIndex]);
                    flowLayoutPanel1.Controls.Add(tile);
                }
            }
        }

        public Goods_Form()
        {
            InitializeComponent();
            Loadproducts();
            CreateTitle();
        }
        private void Svipe(SvipeType svipeType)
        {
            if (svipeType == SvipeType.Left && SvipeID != 0)
            {
                SvipeID--;
                CreateTitle();
            }
            if (svipeType == SvipeType.Right && SvipeID + 5 < goods.Count - 1)
            {
                SvipeID++;
                CreateTitle();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Goods_Form_Load(object sender, EventArgs e)
        {
            labelFIO.Text = Autorizaciya.sotrName;
            labelRole.Text = Autorizaciya.sotrRole;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Svipe(SvipeType.Left);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Svipe(SvipeType.Right);
        }
    }
}
