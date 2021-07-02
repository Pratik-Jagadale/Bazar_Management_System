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
    public partial class frm_Stock_Report : Form
    {
        SqlDataReader dr;
        DataTable dt1 = new DataTable();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataAdapter adp;
        int Stock_id;
        public frm_Stock_Report()
        {
            InitializeComponent();
        }

        private void frm_Stock_Report_Load(object sender, EventArgs e)
        {
            Common_Class obj = new Common_Class();
            obj.openconnection();
           
                obj.cmd = new SqlCommand("select * from tbl_Product ", obj.con);
                adp = new SqlDataAdapter(obj.cmd);
                adp.Fill(dt);
                //obj.cmd.Dispose();

                obj.cmd = new SqlCommand("select * from tbl_Stock ", obj.con);
                adp = new SqlDataAdapter(obj.cmd);
                adp.Fill(dt1);
                //obj.cmd.Dispose();

                obj.cmd = new SqlCommand("select * from tbl_Stock_Added_Details ", obj.con);
                adp = new SqlDataAdapter(obj.cmd);
                adp.Fill(dt2);

           

            Rpt_Stock rpt = new Rpt_Stock();

            rpt.Database.Tables["tbl_Product"].SetDataSource(dt);
            rpt.Database.Tables["tbl_Stock"].SetDataSource(dt1);
            rpt.Database.Tables["tbl_Stock_Added_Details"].SetDataSource(dt2);
            crv_Stock_Report.ReportSource = null;
            crv_Stock_Report.ReportSource = rpt;
            obj.cmd.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Common_Class obj = new Common_Class();
            obj.openconnection();
            if (cb_by.Text == "Product_id")
            {
                obj.cmd = new SqlCommand("select * from tbl_Product where Product_id = " + cb_name_id.Text + " ", obj.con);
                adp = new SqlDataAdapter(obj.cmd);
                adp.Fill(dt);
                //obj.cmd.Dispose();

                obj.cmd = new SqlCommand("select * from tbl_Stock where Product_id = " + cb_name_id.Text + " ", obj.con);
                adp = new SqlDataAdapter(obj.cmd);
                adp.Fill(dt1);
                //obj.cmd.Dispose();
                /////////////////////////////////////////////////////////////////
                obj.cmd = new SqlCommand("select * from tbl_Stock where Product_id = " + cb_name_id.Text + " ", obj.con);
                dr = obj.cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    Stock_id = (int)dr["Stock_id"];

                }
                dr.Close();
               // obj.cmd.Dispose();
                ///////////////////////////////////////////////////////
                obj.cmd = new SqlCommand("select * from tbl_Stock_Added_Details where Stock_id = " + Stock_id + " ", obj.con);
                adp = new SqlDataAdapter(obj.cmd);
                adp.Fill(dt2);

            }
            else if (cb_by.Text == "Category")
            {
                obj.cmd = new SqlCommand("select * from Customer_Details where Cust_name = " + cb_name_id.Text + " ", obj.con);
            }
            else if (cb_by.Text == "Product_name")
            {

            }

            Rpt_Stock rpt = new Rpt_Stock();

            rpt.Database.Tables["tbl_Product"].SetDataSource(dt);
            rpt.Database.Tables["tbl_Stock"].SetDataSource(dt1);
            rpt.Database.Tables["tbl_Stock_Added_Details"].SetDataSource(dt2);
            crv_Stock_Report.ReportSource = null;
            crv_Stock_Report.ReportSource = rpt;
            obj.cmd.Dispose();
            // adp.Dispose();
        }
    }
}
