using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using order.controller;
namespace order.model
{
    class Login
    {

        public bool login(string user, string password)
        {
            string sql = "select * from admin where userName = '" + user + "' and userPassword = '" + password + "'";
            return new ExecuteSql().ifExist(sql);
        }
    }

}
