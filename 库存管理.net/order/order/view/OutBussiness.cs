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
        List<DataRow> dataList; 
        public OutBussiness(List<DataRow> dataList)
        {
            InitializeComponent();
            this.dataList = dataList;
        }
        public OutBussiness()
        {
            InitializeComponent();
        }
        private void OutBussiness_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //创建DataTable对象
            DataTable dt = new DataTable();
            //创建       
            dt.Columns.Add("orderId", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("goodsName", typeof(string));
            dt.Columns.Add("price", typeof(string));
            dt.Columns.Add("orderAmount", typeof(string));
            dt.Columns.Add("orderMoeny", typeof(string));
            dt.Columns.Add("receiveAdress", typeof(string));
            dt.Columns.Add("receiverName", typeof(string));
            dt.Columns.Add("receiverPhone", typeof(string));
            dt.Columns.Add("sendAdress", typeof(string));
            dt.Columns.Add("senderName", typeof(string));
            dt.Columns.Add("senderPhone", typeof(string));
            dt.Columns.Add("exchangeTime", typeof(string));
            dt.Columns.Add("orderOperator", typeof(string));
            double totalMoney = 0;
            foreach(DataRow ite in dataList)
            {
                DataRow row = dt.NewRow();
                //添加数据
                row["orderId"] = ite[0];
                row["status"] = ite[1];
                row["goodsName"] = ite[2];
                string price = (string)ite[3];
                row["price"] = price;
                string amount = (string)ite[4];
                row["orderAmount"] = amount;
                totalMoney += Convert.ToDouble(price) * Convert.ToDouble(amount);
                row["orderMoeny"] = Convert.ToDouble(price) * Convert.ToDouble(amount);
                row["receiveAdress"] = ite[5];
                row["receiverName"] = ite[6];
                row["receiverPhone"] = ite[7];
                row["sendAdress"] = ite[8];
                row["senderName"] = ite[9];
                row["senderPhone"] = ite[10];
                row["exchangeTime"] = ite[11];
                row["orderOperator"] = ite[12];
                dt.Rows.Add(row);
            }
            //this.reportViewer1.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            List<ReportParameter> para = new List<ReportParameter>();
            para.Add(new ReportParameter("totalMoney", totalMoney.ToString()));
            this.reportViewer1.LocalReport.SetParameters(para);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;

            //this.reportViewer1.ProcessingMode = ProcessingMode.Local;

            
            // //this.reportViewer1.LocalReport.EnableExternalImages = true;

            //List<ReportParameter> para = new List<ReportParameter>();
            // 这里是添加两个字段
            //para.Add(new ReportParameter("id", "fishkel"));
            //para.Add(new ReportParameter("name", "123"));
            //// 这里是添加两个数据源，两个list
            ////var list = new List<TestReport> { };
            ////list.Add(new TestReport() { a = "20100201", b = 0.1, c = 0.2, d = 0.1 });
            ////list.Add(new TestReport() { a = "20100202", b = 0.1, c = 0.2, d = 0.2 });
            ////list.Add(new TestReport() { a = "20100203", b = 0.1, c = 0.4, d = 0.2 });
            ////var test = new List<TestReport>() {new TestReport(){ a = "20100201", b = 0.33, c = 0.33, d = 0.33 }};
            ////this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("id", "haha"));
            ////this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            //this.reportViewer1.LocalReport.SetParameters(para);
            //this.reportViewer1.RefreshReport();


        }
    }
}
