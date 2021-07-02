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
    public partial class frm_Customer_Date_wise_Report : Form
    {
        public frm_Customer_Date_wise_Report()
        {
            InitializeComponent();
        }

        private void frm_Customer_Date_wise_Report_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            Common_Class obj = new Common_Class();
            obj.openconnection();


            obj.cmd = new SqlCommand("select * from Customer_Details", obj.con);
            SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt);

            obj.cmd = new SqlCommand("select * from Cust_P_Details ", obj.con);
            adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt1);


            Rpt_customer1 rpt = new Rpt_customer1();
            rpt.Database.Tables["Customer_Details"].SetDataSource(dt);
            rpt.Database.Tables["Cust_P_Details"].SetDataSource(dt1);
            crv_Customer_Bill_date_wise.ReportSource = null;
            crv_Customer_Bill_date_wise.ReportSource = rpt;

            obj.cmd.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            Common_Class obj = new Common_Class();
            obj.openconnection();


            obj.cmd = new SqlCommand("select * from Customer_Details where Bill_Date Between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' ", obj.con);
            SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt);

            obj.cmd = new SqlCommand("select * from Cust_P_Details where Bill_date Between  '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' ", obj.con);
            adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt1);


            Rpt_customer1 rpt = new Rpt_customer1();
            rpt.Database.Tables["Customer_Details"].SetDataSource(dt);
            rpt.Database.Tables["Cust_P_Details"].SetDataSource(dt1);
            crv_Customer_Bill_date_wise.ReportSource = null;
            crv_Customer_Bill_date_wise.ReportSource = rpt;

            obj.cmd.Dispose();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            Common_Class obj = new Common_Class();
            obj.openconnection();


            obj.cmd = new SqlCommand("select * from Customer_Details", obj.con);
            SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt);

            obj.cmd = new SqlCommand("select * from Cust_P_Details ", obj.con);
            adp = new SqlDataAdapter(obj.cmd);
            adp.Fill(dt1);


            Rpt_customer1 rpt = new Rpt_customer1();
            rpt.Database.Tables["Customer_Details"].SetDataSource(dt);
            rpt.Database.Tables["Cust_P_Details"].SetDataSource(dt1);
            crv_Customer_Bill_date_wise.ReportSource = null;
            crv_Customer_Bill_date_wise.ReportSource = rpt;

            obj.cmd.Dispose();
        }
    }
}
