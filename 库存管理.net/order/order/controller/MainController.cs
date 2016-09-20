using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using order.view;
using order.model;
using System.Windows.Forms;
using System.Data.SQLite;
using order.common;
namespace order.controller
{
    class MainController
    {
        private Main mainWindow;
        public MainController(Main mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public DataSet selectUserInfoList(string name, string phone)
        {
            string sql = "select * from userinfo ";
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(phone))
            {
                sql += "where userPhone = '" + phone + "' and userName = '" + name + "'";
            }
            else if (!String.IsNullOrEmpty(phone))
            {
                sql += "where userPhone = '" + phone + "'";
            }
            else if (!String.IsNullOrEmpty(name))
            {
                sql += "where userName = '" + name + "'";
            }
            return new ExecuteSql().selectUserInfo(sql);
        }
        public DataSet selectBusinessRecordList(string receiverName ,string orderId, DateTime startTime, DateTime endTime, bool isLoadTime)
        {
            string sql = null;
            if (isLoadTime)
            {
                sql = "select * from orderInfo  " +
                    "where exchangeTime > " + ConvertTime.ConvertDataTimeLong(startTime) + " and  exchangeTime< " + ConvertTime.ConvertDataTimeLong(endTime);
                if(!String.IsNullOrEmpty(orderId)&&!String.IsNullOrEmpty(receiverName))
                {
                    sql += " and receiverName like '%";
                    sql += receiverName;
                    sql += "%'";
                    sql += " and orderId like '%";
                    sql += orderId;
                    sql += "%'";
                }
                else if(!String.IsNullOrEmpty(orderId))
                {
                    sql += " and orderId like '%";
                    sql += orderId;
                    sql += "%'";
                }
                else if (!String.IsNullOrEmpty(receiverName))
                {
                    sql += " and receiverName like '%";
                    sql += receiverName;
                    sql += "%'";
                }
            }
            else
            {
                sql = "select * from orderInfo ";
                if (!String.IsNullOrEmpty(orderId) && !String.IsNullOrEmpty(receiverName))
                {
                    sql += " where receiverName like '%";
                    sql += receiverName;
                    sql += "%'";
                    sql += " and orderId like '%";
                    sql += orderId;
                    sql += "%'";
                }
                else if (!String.IsNullOrEmpty(orderId))
                {
                    sql += " where orderId like '%";
                    sql += orderId;
                    sql += "%'";
                }
                else if (!String.IsNullOrEmpty(receiverName))
                {
                    sql += " where receiverName like '%";
                    sql += receiverName;
                    sql += "%'";
                }
            }
            return new ExecuteSql().selectOrderInfo(sql);
        }
        public DataSet selectGoodInfoList(string goodsId,string goodsName)
        {
            string sql = "select * from goodsInfo ";
            if (!String.IsNullOrEmpty(goodsId) && !String.IsNullOrEmpty(goodsName))
            {
                sql += "where goodsId = '" + goodsId + "' and goodsName = '" + goodsName + "'";
            }
            else if (!String.IsNullOrEmpty(goodsId))
            {
                sql += "where goodsId = '" + goodsId + "'";
            }
            else if (!String.IsNullOrEmpty(goodsName))
            {
                sql += "where goodsName = '" + goodsName + "'";
            }
            else
            {
 
            }
            return new ExecuteSql().selectGoodInfo(sql);
        }
    }
}
