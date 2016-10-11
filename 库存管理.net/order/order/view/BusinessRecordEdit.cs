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
    public partial class BusinessRecordEdit : Form
    {
        class GoodInfo {
            public string price { get; set; }
            public string name { get; set; }
            public string VipPrice { get; set; }
        }
        DataSet goodRecordList;
        List<GoodInfo> goodsNameList;
        public BusinessRecordEdit(DataSet goodRecordList)
        {
            InitializeComponent();
            this.amount.Text = BusinessInfoEntity.orderAmount;
            this.sendAdress.Text = BusinessInfoEntity.sendAdress;
            this.receiveAdress.Text = BusinessInfoEntity.receiveAdress;
            this.senderName.Text = BusinessInfoEntity.senderName;
            this.receiverName.Text = BusinessInfoEntity.receiverName;
            this.senderPhone.Text = BusinessInfoEntity.senderPhone;
            this.receiverPhone.Text = BusinessInfoEntity.receiverPhone;
            this.goodRecordList = goodRecordList;
            goodsNameList = new List<GoodInfo>(); 
            if(BusinessInfoEntity.exchangeTime.Equals(DateTime.MinValue))
            {
                this.orderTime.Value = DateTime.Now;
            }
            else
            {
                this.orderTime.Value = BusinessInfoEntity.exchangeTime;
            }
            if (BusinessInfoEntity.status == null)
            {
                this.Status.Checked = false;
            }
            else
            {
                this.Status.Checked = bool.Parse(BusinessInfoEntity.status);
            }
            loadList();
        }
        public BusinessRecordEdit()
        {
            InitializeComponent();
            this.goodNameList.Text = BusinessInfoEntity.goodsName;
            this.businessPrice.Text = BusinessInfoEntity.price;
            this.amount.Text = BusinessInfoEntity.orderAmount;
            this.sendAdress.Text = BusinessInfoEntity.sendAdress;
            this.receiveAdress.Text = BusinessInfoEntity.receiveAdress;
            this.senderName.Text = BusinessInfoEntity.senderName;
            this.receiverName.Text = BusinessInfoEntity.receiverName;
            this.senderPhone.Text = BusinessInfoEntity.senderPhone;
            this.receiverPhone.Text = BusinessInfoEntity.receiverPhone;
            if (BusinessInfoEntity.exchangeTime.Equals(DateTime.MinValue))
            {
                this.orderTime.Value = DateTime.Now;
            }
            else
            {
                this.orderTime.Value = BusinessInfoEntity.exchangeTime;
            }
            if (BusinessInfoEntity.status == null || BusinessInfoEntity.status.Equals("未完成"))
            {
                this.Status.Checked = false;
            }
            else
            {
                this.Status.Checked = true;
            }
        }
        public void loadList()
        {
            AutoCompleteStringCollection goods = new AutoCompleteStringCollection();
            foreach (DataRow row in goodRecordList.Tables[0].Rows)
            {
                GoodInfo goodInfo = new GoodInfo();
                goodInfo.name = (string)row[1];
                goodInfo.price = (string)row[2];
                goods.Add(goodInfo.name);
                goodsNameList.Add(goodInfo);
                this.goodNameList.Items.Add(goodInfo.name);
            }
            goodNameList.AutoCompleteMode = AutoCompleteMode.Suggest;
            goodNameList.AutoCompleteSource = AutoCompleteSource.CustomSource;
            goodNameList.AutoCompleteCustomSource = goods;
            this.goodNameList.SelectedItem = 0;
            getVipPrice();
        }
        private void getVipPrice()
        {
            foreach (GoodInfo info in goodsNameList)
            {
                info.VipPrice = new EditGoodsInfocs().getvipPriceByGoodsName(info.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessInfoEntity.goodsName = this.goodNameList.Text;
            BusinessInfoEntity.price = this.businessPrice.Text;
            BusinessInfoEntity.orderAmount = this.amount.Text;
            BusinessInfoEntity.sendAdress = this.sendAdress.Text;
            BusinessInfoEntity.receiveAdress = this.receiveAdress.Text;
            BusinessInfoEntity.senderName = this.senderName.Text;
            BusinessInfoEntity.receiverName = this.receiverName.Text;
            BusinessInfoEntity.senderPhone = this.senderPhone.Text;
            BusinessInfoEntity.receiverPhone = this.receiverPhone.Text;
            BusinessInfoEntity.exchangeTime = this.orderTime.Value;
            BusinessInfoEntity.status = this.Status.Checked.ToString();
            if (new EditBusinessInfo().saveOrderInfo())
            {
                ShowMessage.showMessage("保存或者增加成功");
            }
            else
            {
                ShowMessage.showMessage("保存或者增加失败");
            }
            this.Close();
        }

        private void BusinessRecordEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.goodNameList.SelectedIndex;
            if (isVip.Checked)
            {
                this.businessPrice.Text = goodsNameList[index].VipPrice;
            }
            else
            {
                this.businessPrice.Text = goodsNameList[index].price;
            }
        }

        private void isVip_CheckedChanged(object sender, EventArgs e)
        {
            int index = this.goodNameList.SelectedIndex;
            if (isVip.Checked)
            {
                this.businessPrice.Text = goodsNameList[index].VipPrice;
            }
            else
            {
                this.businessPrice.Text = goodsNameList[index].price;
            }
        }
    }
}
