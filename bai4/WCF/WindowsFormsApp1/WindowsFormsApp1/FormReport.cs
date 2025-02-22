using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        Service1Client client = new Service1Client();

        private void FormReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!int.TryParse(textBox1.Text, out int result)) || result > 12 || result < 0)
            {
                MessageBox.Show("nhập vào số tháng từ 1 đến 12");
            }

            List<ServiceReference1.Report> data = client.data(textBox1.Text).ToList();

            reportViewer1.LocalReport.ReportPath = @"D:\LapTrinhService\MH3TVSWCF\bai4\WCF\WindowsFormsApp1\WindowsFormsApp1\Report1.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", data);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
