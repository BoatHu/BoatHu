using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using order.model;
using order.common;
namespace order.controller
{
    class GoodsCalculate
    {
        private long endTime;
        public GoodsCalculate()
        {
            this.endTime = ConvertTime.ConvertDataTimeLong(DateTime.Now);
        }
        public DataSet selectGoodsInfo(int index)
        {
            long startTime = endTime;
            if (index == 0)
            {
                startTime = ConvertTime.ConvertDataTimeLong(DateTime.Now.AddDays(-1));
            }
            else if (index == 1)
            {
                startTime = ConvertTime.ConvertDataTimeLong(DateTime.Now.AddDays(-7));
            }
            else
            {
                startTime = ConvertTime.ConvertDataTimeLong(DateTime.Now.AddYears(-1));
            }
            string sql = "select goodsName,price,sum(orderAmount) as orderAmount from orderInfo where exchangeTime > '" +
                startTime + "' and exchangeTime < '" + endTime + "' group by goodsName ";
            return new ExecuteSql().calculateGoodsInfoList(sql);
        }
    }
}
