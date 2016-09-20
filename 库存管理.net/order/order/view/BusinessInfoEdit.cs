using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using order.Entity;
using order.controller;
namespace order.view
{
    public partial class BusinessInfoEdit : Form
    {
        public BusinessInfoEdit()
        {
            InitializeComponent();
            this.goodsAmount.Text = GoodsInfoEntity.goodsAmount;
            this.goodsName.Text = GoodsInfoEntity.goodsName;
            this.goodsPrice.Text = GoodsInfoEntity.goodsPrice;
            this.goodsVipPrice.Text = GoodsInfoEntity.goodsVipPrice;
            this.goodsAmount.Text = GoodsInfoEntity.goodsAmount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoodsInfoEntity.goodsAmount = this.goodsAmount.Text;
            GoodsInfoEntity.goodsName = this.goodsName.Text;
            GoodsInfoEntity.goodsPrice = this.goodsPrice.Text;
            GoodsInfoEntity.goodsVipPrice = this.goodsVipPrice.Text;
            GoodsInfoEntity.goodsAmount = this.goodsAmount.Text;
            if (new EditGoodsInfocs().saveEditGoodsInfo())
            {
                ShowMessage.showMessage("增加或者更新成功");
            }
            else
            {
                ShowMessage.showMessage("增加或者更新成功");
            }
            this.Close();
        }

        private void BusinessInfoEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
