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
            dt.Columns.Add("goodsId", typeof(string));
            dt.Columns.Add("goodsName", typeof(string));
                DataRow row = dt.NewRow();
                //添加数据
                row["goodsId"] = "fada";
                row["goodsName"] = "hha";
                dt.Rows.Add(row);
            //将数据表添加到DataSet中 
            ds.Tables.Add(dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            //List<ReportParameter> para = new List<ReportParameter>();
            //para.Add(new ReportParameter("id", "fishkel"));
            //para.Add(new ReportParameter("name", "123"));
            //this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
           // //this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
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
        public class TestReport
        {
            public string a { get; set; }
            public double b { get; set; }
            public double c { get; set; }
            public double d { get; set; }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
