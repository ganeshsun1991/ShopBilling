using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Billing
{
    public partial class FromReport : Form
    {

        SqlConnection sqlcon = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
        ReportDocument rprt = new ReportDocument();

        public FromReport()
        {
            InitializeComponent();
        }

        private void FromReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
            rprt.Load(@"I:\project\ShopBilling\Shop Billing\Reports\Bill_Report.rpt");
            SqlCommand cmd = new SqlCommand("Dp_Get_Bill_Deatils_For_Report", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;
            cmd.Parameters.AddWithValue("@BillNo", 1000);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "ReportBill");
            rprt.SetDatabaseLogon("GANESHSUNDAR", "Sundar@123", "GANESHSUNDAR", "Shop_Billing_08042018");
            rprt.SetDataSource(ds);
            rprt.SetParameterValue(0, 1000);
            crystalReportViewer1.ReportSource = rprt;  
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
