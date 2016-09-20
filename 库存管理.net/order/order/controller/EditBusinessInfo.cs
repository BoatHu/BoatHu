using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order.Entity;
using order.model;
using order.common;
namespace order.controller
{
    class EditBusinessInfo
    {
        public bool saveOrderInfo()
        {
            string sql = null;
            if (String.IsNullOrEmpty(BusinessInfoEntity.orderId))
            {
                sql = "INSERT INTO orderInfo (goodsName,price,orderAmount,sendAdress,receiveAdress,senderName,receiverName, senderPhone,receiverPhone,exchangeTime,status,orderOperator)"
                   + "values('" + BusinessInfoEntity.goodsName + "','" + BusinessInfoEntity.price + "','" + BusinessInfoEntity.orderAmount
                   + "','" + BusinessInfoEntity.sendAdress + "','" + BusinessInfoEntity.receiveAdress + "','" + BusinessInfoEntity.senderName + "','" + BusinessInfoEntity.receiverName
                   + "','" + BusinessInfoEntity.senderPhone + "','" + BusinessInfoEntity.receiverPhone + "','" + ConvertTime.ConvertDataTimeLong(BusinessInfoEntity.exchangeTime) + "','"+BusinessInfoEntity.status.ToString()+"','" + BusinessInfoEntity.orderOperator + "')";

            }
            else
            {
                sql = "UPDATE orderInfo SET goodsName = '" +
                    BusinessInfoEntity.goodsName + "',price = '" +
                    BusinessInfoEntity.price + "',status ='" +
                    BusinessInfoEntity.status + "',orderAmount ='" +
                    BusinessInfoEntity.orderAmount + "',sendAdress = '" +
                    BusinessInfoEntity.sendAdress + "',receiveAdress = '" +
                    BusinessInfoEntity.receiveAdress + "',senderName = '" +
                    BusinessInfoEntity.senderName + "',receiverName = '" +
                    BusinessInfoEntity.receiverName + "',senderPhone = '" +
                    BusinessInfoEntity.senderPhone + "',receiverPhone = '" +
                    BusinessInfoEntity.receiverPhone + "',exchangeTime = '" +
                    ConvertTime.ConvertDataTimeLong(BusinessInfoEntity.exchangeTime) + "',orderOperator = '" +
                    BusinessInfoEntity.orderOperator + "' WHERE orderId = " +
                    BusinessInfoEntity.orderId.ToString();
            }
            BusinessInfoEntity.reset();
            return new ExecuteSql().execute(sql);
        }
        public void deleteOrderRecord()
        {
            if (!String.IsNullOrEmpty(BusinessInfoEntity.orderId))
            {
                string sql = "delete from orderInfo where orderId =" + BusinessInfoEntity.orderId;
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
        public void setListStatus(List<string> iteList)
        {
            foreach(string ite in iteList)
            {
                string sql = "UPDATE orderInfo SET status = 'True'" +
                   " WHERE orderId = " + ite;
                if (!new ExecuteSql().execute(sql))
                {
                    ShowMessage.showMessage("设置为已成交失败");
                }
            }
            ShowMessage.showMessage("设置为已成交成功");
        }
    }
}
