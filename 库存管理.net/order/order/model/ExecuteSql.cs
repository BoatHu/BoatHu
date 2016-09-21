using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using order.controller;
using System.Windows.Forms;
using order.common;
using order.Entity;
namespace order.model
{
    class ExecuteSql
    {
        private SQLiteConnection conn = null;
        public ExecuteSql()
        {
            string dbPath = "Data Source =" + Environment.CurrentDirectory + "\\pro_order_db.db";
            if (AdminInfo.userName == "huzhou")
            {
              dbPath  = "Data Source =" + Environment.CurrentDirectory + "\\order_db.db";
            }
             
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
        }
        public bool execute(string sql)
        {
            try
            {
                conn.Open();//打开数据库，若文件不存在会自动创建  
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                if (cmdCreateTable.ExecuteNonQuery() > -1)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                ShowMessage.showMessage("执行增、删、改语句出错");
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public DataSet selectUserInfo(string sql)
        {
            try
            {
                //创建DataSet对象
                conn.Open();
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmdCreateTable.ExecuteReader();
                DataSet ds = new DataSet();
                //创建DataTable对象
                DataTable dt = new DataTable();
                //创建列
                dt.Columns.Add("会员ID", typeof(string));
                dt.Columns.Add("会员名称", typeof(string));
                dt.Columns.Add("会员性别", typeof(string));
                dt.Columns.Add("会员电话", typeof(string));
                dt.Columns.Add("会员地址", typeof(string));
                dt.Columns.Add("微信号", typeof(string));
                while (reader.Read())
                {       
                    //创建行
                    DataRow row = dt.NewRow();
                    //添加数据
                    row[0] = reader["userId"];
                    row[1] = reader["userName"];
                    row[2] = reader["userSex"];
                    row[3] = reader["userPhone"];
                    row[4] = reader["userAddress"];
                    row[5] = reader["userWechat"];
                    //将行添加到数据表的行集合中
                    dt.Rows.Add(row);       
                }

                //将数据表添加到DataSet中 
                ds.Tables.Add(dt);
                return ds;
            }
            catch (Exception e)
            {
                ShowMessage.showMessage("执行查询语句出错");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public DataSet selectOrderInfo(string sql)
        {
            try
            {
                //创建DataSet对象
                conn.Open();
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmdCreateTable.ExecuteReader();
                DataSet ds = new DataSet();
                //创建DataTable对象
                DataTable dt = new DataTable();
                //创建列
                dt.Columns.Add("订单号", typeof(string));
                dt.Columns.Add("交易状态", typeof(string));
                dt.Columns.Add("商品名称", typeof(string));
                dt.Columns.Add("价格", typeof(string));
                dt.Columns.Add("数量", typeof(string));
                dt.Columns.Add("收件地址", typeof(string));
                dt.Columns.Add("收件人名称", typeof(string));
                dt.Columns.Add("收件人电话", typeof(string));
                dt.Columns.Add("发货地址", typeof(string));
                dt.Columns.Add("发件人名称", typeof(string));
                dt.Columns.Add("发件人电话", typeof(string));
                dt.Columns.Add("订单日期", typeof(string));
                dt.Columns.Add("操作者", typeof(string));
                while (reader.Read())
                {
                    //创建行
                    DataRow row = dt.NewRow();
                    //添加数据
                    row[0] = reader["orderId"];
                    row[1] = reader["status"];
                    row[2] = reader["goodsName"];
                    row[3] = reader["price"];
                    row[4] = reader["orderAmount"];
                    row[5] = reader["receiveAdress"];
                    row[6] = reader["receiverName"];
                    row[7] = reader["receiverPhone"];
                    row[8] = reader["sendAdress"];
                    row[9] = reader["senderName"];
                    row[10] = reader["senderPhone"];
                    row[11] = ConvertTime.ConvertLongDateTime(long.Parse(reader["exchangeTime"].ToString())).ToString();
                    row[12] = reader["orderOperator"];
                    //将行添加到数据表的行集合中
                    dt.Rows.Add(row);
                }
                //将数据表添加到DataSet中 
                ds.Tables.Add(dt);
                return ds;
            }
            catch (Exception e)
            {
                ShowMessage.showMessage("执行查询语句出错");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public DataSet selectGoodInfo(string sql)
        {
            try
            {
                //创建DataSet对象
                conn.Open();
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmdCreateTable.ExecuteReader();
                DataSet ds = new DataSet();
                //创建DataTable对象
                DataTable dt = new DataTable();
                //创建列
                dt.Columns.Add("商品Id", typeof(string));
                dt.Columns.Add("商品名称", typeof(string));
                dt.Columns.Add("正常价格", typeof(string));
                dt.Columns.Add("会员价格", typeof(string));
                dt.Columns.Add("库存数量", typeof(string));
                while (reader.Read())
                {
                    //创建行
                    DataRow row = dt.NewRow();
                    //添加数据
                    row[0] = reader["goodsId"];
                    row[1] = reader["goodsName"];
                    row[2] = reader["goodsPrice"];
                    row[3] = reader["goodsVipPrice"];
                    row[4] = reader["goodsAmount"];
                    //将行添加到数据表的行集合中
                    dt.Rows.Add(row);
                }
                //将数据表添加到DataSet中 
                ds.Tables.Add(dt);
                return ds;
            }
            catch (Exception e)
            {
                ShowMessage.showMessage("执行查询语句出错");
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool ifExist(string sql)
        {
            try
            {
                conn.Open();
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmdCreateTable.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                ShowMessage.showMessage("判断是否存在出错");
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
