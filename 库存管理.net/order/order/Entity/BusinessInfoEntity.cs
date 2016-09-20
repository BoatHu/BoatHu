using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order.Entity
{
    class BusinessInfoEntity
    {
        public static string orderId { get; set; }
        public static string goodsName { get; set; }
        public static string price { get; set; }
        public static string orderAmount { get; set; }
        public static string sendAdress { get; set; }
        public static string receiveAdress { get; set; }
        public static string senderName { get; set; }
        public static string receiverName { get; set; }
        public static string senderPhone { get; set; }
        public static string receiverPhone { get; set; }
        public static DateTime exchangeTime { get; set; }
        public static string status { get; set; }
        public static string orderOperator { get; set; }
        public static void reset()
        {
            orderId = null;
            goodsName = null;
            price = null;
            orderAmount = null;
            sendAdress = null;
            receiveAdress = null;
            senderName = null;
            receiverName = null;
            senderPhone = null;
            receiverPhone = null;
            exchangeTime = DateTime.MinValue;
            status = null;
        }

    }
}
