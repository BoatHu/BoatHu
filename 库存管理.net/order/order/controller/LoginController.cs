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
        private LoginWindow loginWindow;
        public LoginController(LoginWindow loginWindow)
        {
            this.loginWindow = loginWindow;
        }
        public void login()
        {
            Login loginModel = new Login();
            if (loginModel.login(AdminInfo.userName, AdminInfo.userPassword))
            {
                loginWindow.Hide();
                BusinessInfoEntity.orderOperator = AdminInfo.userName;
                new Main().Show();
            }
            else
            {
                ShowMessage.showMessage("登录失败 账号或者密码错误");
            }
        }
    }
}
