using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order.Entity
{
    class GoodsInfoEntity
    {
        public static string goodsId { get; set; }
        public static string goodsName { get; set; }
        public static string goodsPrice { get; set; }
        public static string goodsVipPrice { get; set; }
        public static string goodsAmount { get; set; }
        public static void reset()
        {
            goodsId = null;
            goodsName = null;
            goodsPrice = null;
            goodsVipPrice = null;
            goodsAmount = null;
        }
    }
}
