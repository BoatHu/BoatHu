using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order.Entity;
using order.model;
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
