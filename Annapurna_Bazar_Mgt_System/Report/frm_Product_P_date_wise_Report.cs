using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Annapurna_Bazar_Mgt_System.RPT;

namespace Annapurna_Bazar_Mgt_System.Report
{
    public partial class frm_Product_P_date_wise_Report : Form
    {
        public frm_Product_P_date_wise_Report()
        {
            InitializeComponent();
        }

        private void frm_Product_P_date_wise_Report_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            Common_Class obj = new Common_Class();
            obj.openconnection();


            obj.cmd = new SqlCommand("select * from tbl_Product", obj.con);
            SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt);

            obj.cmd = new SqlCommand("select * from tbl_Stock ", obj.con);
            adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt1);


            Rpt_Product_report rpt = new Rpt_Product_report();
            rpt.Database.Tables["tbl_Product"].SetDataSource(dt);
            rpt.Database.Tables["tbl_Stock"].SetDataSource(dt1);
            crv_Product_Report_date_wise.ReportSource = null;
            crv_Product_Report_date_wise.ReportSource = rpt;

            obj.cmd.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            Common_Class obj = new Common_Class();
            obj.openconnection();


            obj.cmd = new SqlCommand("select * from tbl_Product where Added_Date Between  '" + dtp_from.Text + "' and '" + dtp_to.Text + "'", obj.con);
            SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt);

            obj.cmd = new SqlCommand("select * from tbl_Stock where Stock_Added_Date Between  '" + dtp_from.Text + "' and '" + dtp_to.Text + "'", obj.con);
            adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt1);


            Rpt_Product_report rpt = new Rpt_Product_report();
            rpt.Database.Tables["tbl_Product"].SetDataSource(dt);
            rpt.Database.Tables["tbl_Stock"].SetDataSource(dt1);
            crv_Product_Report_date_wise.ReportSource = null;
            crv_Product_Report_date_wise.ReportSource = rpt;

            obj.cmd.Dispose();
        }
    }
}
