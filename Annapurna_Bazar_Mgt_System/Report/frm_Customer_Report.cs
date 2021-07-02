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
    public partial class frm_Customer_Report : Form
    {
        
        DataTable dt = new DataTable();
        SqlDataAdapter adp;
        public frm_Customer_Report()
        {
            InitializeComponent();
        }

        private void cb_by_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (cb_by.Text != "" && cb_name_id.Text != "")
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();

                Common_Class obj = new Common_Class();
                obj.openconnection();

                if (cb_by.Text == "Cust_id")
                {
                    obj.cmd = new SqlCommand("select * from Customer_Details where Cust_id = " + cb_name_id.Text + " ", obj.con);
                    SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
                    adp.Fill(dt);

                    obj.cmd = new SqlCommand("select * from Cust_P_Details where Cust_id - " + cb_name_id.Text + "  ", obj.con);
                    adp = new SqlDataAdapter(obj.cmd);
                    adp.Fill(dt1);
                }
                else if (cb_by.Text == "Cust_name")
                {
                    obj.cmd = new SqlCommand("select * from Customer_Details where Cust_name = " + cb_name_id.Text + " ", obj.con);
                    SqlDataAdapter adp = new SqlDataAdapter(obj.cmd);
                    adp.Fill(dt);

                    obj.cmd = new SqlCommand("select * from Cust_P_Details where Cust_name - " + cb_name_id.Text + "  ", obj.con);
                    adp = new SqlDataAdapter(obj.cmd);
                    adp.Fill(dt1);
                }

                Rpt_customer1 rpt = new Rpt_customer1();
                rpt.Database.Tables["tbl_Product"].SetDataSource(dt);
                rpt.Database.Tables["tbl_Stock"].SetDataSource(dt1);
                crv_Customer_Bill.ReportSource = null;
                crv_Customer_Bill.ReportSource = rpt;

                obj.cmd.Dispose();
                //adp.Dispose();
            }
            else{
                MessageBox.Show("Please fill All fields..");
            }
        }

        private void frm_Customer_Report_Load(object sender, EventArgs e)
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
            crv_Customer_Bill.ReportSource = null;
            crv_Customer_Bill.ReportSource = rpt;

            obj.cmd.Dispose();
        }
    }
}
