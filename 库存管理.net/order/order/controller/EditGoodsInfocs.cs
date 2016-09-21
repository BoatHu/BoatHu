using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order.Entity;
using order.model;
using System.Data;
namespace order.controller
{
    class EditGoodsInfocs
    {
        public bool saveEditGoodsInfo()
        {
            string sql = null;
            if (String.IsNullOrEmpty(GoodsInfoEntity.goodsId))
            {
                sql = "INSERT INTO goodsInfo (goodsName,goodsPrice,goodsVipPrice,goodsAmount)values('" +
                GoodsInfoEntity.goodsName + "','" + GoodsInfoEntity.goodsPrice + "','" + GoodsInfoEntity.goodsVipPrice + "','" + GoodsInfoEntity.goodsAmount + "')";
            }
            else
            {
                sql = "UPDATE goodsInfo SET goodsName = '" +
                    GoodsInfoEntity.goodsName + "',goodsPrice = '" +
                    GoodsInfoEntity.goodsPrice + "',goodsVipPrice ='" +
                    GoodsInfoEntity.goodsVipPrice + "',goodsAmount = '" +
                    GoodsInfoEntity.goodsAmount + "' WHERE goodsId = " +
                    GoodsInfoEntity.goodsId;
            }
            GoodsInfoEntity.reset();
            return new ExecuteSql().execute(sql);
        }
        public bool reduceGoodsAmount(string goodsName)
        {
            string sql = "select * from goodsInfo where  goodsName = '" + goodsName + "'";
            DataSet dataSet = new ExecuteSql().selectGoodInfo(sql);
            DataTable dataTable = dataSet.Tables[0];
            if (dataTable.Rows.Count == 0)
            {
                ShowMessage.showMessage("请确认有没有这件商品");
                return false;
            }
            else
            {
                DataRow row = dataTable.Rows[0];
                int amount = Convert.ToInt32((string)row[4]);
                if (amount > 0)
                {
                    sql = "update goodsInfo set goodsAmount = goodsAmount - 1 where  goodsName = '" + goodsName + "'";
                    if (new ExecuteSql().execute(sql))
                    {
                        ShowMessage.showMessage("删除成功");
                    }
                    else
                    {
                        ShowMessage.showMessage("删除失败");
                    }
                }
                else
                {
                    ShowMessage.showMessage("没库存啦");
                }
                return true;
            }      
        }
        public void deleteGoodsInfo()
        {
            if (!String.IsNullOrEmpty(GoodsInfoEntity.goodsId))
            {
                string sql = "delete from goodsInfo where goodsId =" + GoodsInfoEntity.goodsId;
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
