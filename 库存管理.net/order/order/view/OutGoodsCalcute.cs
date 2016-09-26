using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using order.Entity;
namespace order.view
{
    public partial class OutGoodsCalcute : Form
    {
        private DataSet goodsInfoList;
        public OutGoodsCalcute()
        {
            InitializeComponent();
        }
        public OutGoodsCalcute(DataSet goodsInfoList,int type)
        {
            InitializeComponent();
            this.goodsInfoList = goodsInfoList;
            List<ReportParameter> para = new List<ReportParameter>();
            if (type == 0)
            {
                para.Add(new ReportParameter("Title", "本日销售商品统计"));
            }
            else if (type == 1)
            {
                para.Add(new ReportParameter("Title", "本周销售商品统计"));
            }
            else
            {
                para.Add(new ReportParameter("Title", "本月销售商品统计"));
            }
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(para);
        }

        private void OutGoodsCalcute_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.LocalReport.ReportPath = Environment.CurrentDirectory + "\\GoodsReport.rdlc";
            if (goodsInfoList != null)
            {
                DataTable dt = new DataTable();
                //创建       
                dt.Columns.Add("goodsName", typeof(string));
                dt.Columns.Add("goodsPrice", typeof(string));
                dt.Columns.Add("goodsAmount", typeof(string));
                dt.Columns.Add("totalMoney", typeof(string));
                foreach (DataRow ite in goodsInfoList.Tables[0].Rows)
                {
                    DataRow row = dt.NewRow();
                    //添加数据
                    row["goodsName"] = ite[0];
                    string price = (string)ite[1];
                    string amount = (string)ite[2];
                    row["goodsPrice"] = price;
                    row["goodsAmount"] = amount;
                    if (!string.IsNullOrEmpty(price) && !string.IsNullOrEmpty(amount))
                    {
                        row["totalMoney"] = Convert.ToDouble(price) * Convert.ToDouble(amount);
                        dt.Rows.Add(row);
                    }
                }
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
                this.reportViewer1.RefreshReport();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            }
        }
    }
}
