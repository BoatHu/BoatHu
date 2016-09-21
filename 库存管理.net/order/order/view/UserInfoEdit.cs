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
    public partial class UserInfoEdit : Form
    {
        public UserInfoEdit()
        {
            InitializeComponent();
            this.name.Text = UserInfoEntity.userName;
            this.phone.Text = UserInfoEntity.userPhone;
            this.sex.Text = UserInfoEntity.userSex;
            this.adress.Text = UserInfoEntity.userAddress;
            this.userWechat.Text = UserInfoEntity.userWechat;
        }
    
        private void UserInfoEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfoEntity.userName = this.name.Text;
            UserInfoEntity.userPhone = this.phone.Text;
            UserInfoEntity.userSex = this.sex.Text;
            UserInfoEntity.userAddress = this.adress.Text;
            UserInfoEntity.userWechat = this.userWechat.Text;
            if (new EditUserInfo().saveEditInfo())
            {
                this.Close();
                ShowMessage.showMessage("增加或者更新成功");
            }
            else
            {
                ShowMessage.showMessage("增加或者更新成功");
            }
        }
    }
}
