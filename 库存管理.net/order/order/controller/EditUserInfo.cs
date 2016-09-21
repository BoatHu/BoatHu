using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order.Entity;
using order.model;
namespace order.controller
{
    class EditUserInfo
    {
        public bool saveEditInfo()
        {
            string sql = null;
            if (String.IsNullOrEmpty(UserInfoEntity.userId))
            {
                sql = "insert into userinfo(userAddress,userName,userSex,userPhone,userWechat)values('" +
                UserInfoEntity.userAddress + "','" + UserInfoEntity.userName + "','" + UserInfoEntity.userSex + "','" + UserInfoEntity.userPhone +"','" +UserInfoEntity.userWechat+ "')";

            }
            else
            {
                sql = "UPDATE userInfo SET userName = '" +
                    UserInfoEntity.userName + "',userAddress = '" +
                    UserInfoEntity.userAddress + "',userSex ='" +
                    UserInfoEntity.userSex + "',userPhone = '" +
                    UserInfoEntity.userPhone + "',userWechat = '" +
                    UserInfoEntity.userWechat+"' WHERE userId = " +
                    UserInfoEntity.userId;
            }
            UserInfoEntity.reset();
            return new ExecuteSql().execute(sql);
        }
        public void deleteUserInfo()
        {
            if (!String.IsNullOrEmpty(UserInfoEntity.userId))
            {
                string sql = "delete from userinfo where userId =" + UserInfoEntity.userId;
                if (new ExecuteSql().execute(sql))
                {
                    ShowMessage.showMessage("删除成功");
                }
                else
                {
                    ShowMessage.showMessage("删除失败");
                }
            }
          
        }
    }
}
