using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order.model;
using order.Entity;
using order.view;
namespace order.controller
{
    class LoginController
    {
        private AdminInfo adminInfo;
        private LoginWindow loginWindow;
        public LoginController(AdminInfo adminInfo, LoginWindow loginWindow)
        {
            this.adminInfo = adminInfo;
            this.loginWindow = loginWindow;
        }
        public void login()
        {
            Login loginModel = new Login();
            if (loginModel.login(adminInfo.userName, adminInfo.userPassword))
            {
                loginWindow.Hide();
                BusinessInfoEntity.orderOperator = adminInfo.userName;
                new Main().Show();
            }
            else
            {
                ShowMessage.showMessage("登录失败 账号或者密码错误");
            }
        }
    }
}
