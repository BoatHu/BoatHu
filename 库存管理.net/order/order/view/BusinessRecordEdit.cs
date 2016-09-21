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
        public BusinessRecordEdit()
        {
            InitializeComponent();
            this.goodname.Text = BusinessInfoEntity.goodsName;
            this.price.Text = BusinessInfoEntity.price;
            this.amount.Text = BusinessInfoEntity.orderAmount;
            this.sendAdress.Text = BusinessInfoEntity.sendAdress;
            this.receiveAdress.Text = BusinessInfoEntity.receiveAdress;
            this.senderName.Text = BusinessInfoEntity.senderName;
            this.receiverName.Text = BusinessInfoEntity.receiverName;
            this.senderPhone.Text = BusinessInfoEntity.senderPhone;
            this.receiverPhone.Text = BusinessInfoEntity.receiverPhone;
            if(BusinessInfoEntity.exchangeTime.ToString().Equals("0001/1/1 0:00:00"))
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessInfoEntity.goodsName = this.goodname.Text;
            BusinessInfoEntity.price = this.price.Text;
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
    }
}
