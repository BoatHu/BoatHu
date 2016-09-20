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
    public partial class OutBussiness : Form
    {
        public OutBussiness()
        {
            InitializeComponent();
        }

        private void OutBussiness_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //创建DataTable对象
            DataTable dt = new DataTable();
            //创建列
            dt.Columns.Add("orderId", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("goodsName", typeof(string));
            dt.Columns.Add("price", typeof(string));
            dt.Columns.Add("orderAmount", typeof(string));
            dt.Columns.Add("receiveAdress", typeof(string));
            dt.Columns.Add("receiverName", typeof(string));
            dt.Columns.Add("receiverPhone", typeof(string));
            dt.Columns.Add("sendAdress", typeof(string));
            dt.Columns.Add("senderName", typeof(string));
            dt.Columns.Add("senderPhone", typeof(string));
            dt.Columns.Add("exchangeTime", typeof(string));
            dt.Columns.Add("orderOperator", typeof(string));
            DataRow row = dt.NewRow();
            //添加数据
            row["orderId"] = BusinessInfoEntity.orderId;
            row["status"] = BusinessInfoEntity.status;
            row["goodsName"] = BusinessInfoEntity.goodsName;
            row["price"] = BusinessInfoEntity.price;
            row["orderAmount"] = BusinessInfoEntity.orderAmount;
            row["receiveAdress"] = BusinessInfoEntity.receiveAdress;
            row["receiverName"] = BusinessInfoEntity.receiverName;
            row["receiverPhone"] = BusinessInfoEntity.receiverPhone;
            row["sendAdress"] = BusinessInfoEntity.sendAdress;
            row["senderName"] = BusinessInfoEntity.senderName;
            row["senderPhone"] = BusinessInfoEntity.senderPhone;
            row["exchangeTime"] = DateTime.Now.ToString();
            row["orderOperator"] = BusinessInfoEntity.orderOperator;
            dt.Rows.Add(row);
            this.reportViewer1.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            int amount =  Convert.ToInt32(BusinessInfoEntity.orderAmount);
            double price = Convert.ToDouble(BusinessInfoEntity.price);
            double totalMoney = amount * price;
            List<ReportParameter> para = new List<ReportParameter>();
            para.Add(new ReportParameter("totalMoney", totalMoney.ToString()));
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;

            
            // //this.reportViewer1.LocalReport.EnableExternalImages = true;

            // List<ReportParameter> para = new List<ReportParameter>();
            //// 这里是添加两个字段
            //para.Add(new ReportParameter("id", "fishkel"));
            //para.Add(new ReportParameter("name", "123"));
            //// 这里是添加两个数据源，两个list
            ////var list = new List<TestReport> { };
            ////list.Add(new TestReport() { a = "20100201", b = 0.1, c = 0.2, d = 0.1 });
            ////list.Add(new TestReport() { a = "20100202", b = 0.1, c = 0.2, d = 0.2 });
            ////list.Add(new TestReport() { a = "20100203", b = 0.1, c = 0.4, d = 0.2 });
            // //var test = new List<TestReport>() {new TestReport(){ a = "20100201", b = 0.33, c = 0.33, d = 0.33 }};
            // //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("id", "haha"));
            // this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            // this.reportViewer1.LocalReport.SetParameters(para);
            // this.reportViewer1.RefreshReport();


        }
    }
}
