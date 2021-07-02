using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Annapurna_Bazar_Mgt_System;
using System.Data.SqlClient;

namespace APMS
{
    public partial class frm_Add_Stock : Form
    {
        int stock_id = 0;
        SqlDataReader dr,dr1;
        public frm_Add_Stock()
        {
            InitializeComponent();
        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            btn_add_stock.Enabled = false;
            //Common_Class obj = new Common_Class();

            //obj.openconnection();
            //cb_Category.Items.Clear();
            //obj.cmd = new SqlCommand("Select * from tbl_Product", obj.con);
            //dr = obj.cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    cb_Category.Items.Add((string)dr["Category"]);
            //}
            //dr.Dispose();
            //obj.cmd.Dispose();

            //tb_Product_Name.Text = "";
            //obj.cmd = new SqlCommand("select distinct Product_name from tbl_Product where Category = '" + cb_Category.SelectedValue + "' ", obj.con);
            //dr = obj.cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    tb_Product_Name.Items.Add((int)dr["Product_name"]);
            //}

            //dr.Dispose();
            //obj.cmd.Dispose();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
        try{
            Common_Class obj = new Common_Class();
            if (tb_Product_ID.Text != "")
            {
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_Stock where Product_id = " + tb_Product_ID.Text + "", obj.con);
                SqlCommand cmd2 = new SqlCommand("select * from tbl_Product where Product_id = " + tb_Product_ID.Text + "", obj.con);
                dr = obj.cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    tb_Product_ID.Text = Convert.ToString(dr["Product_id"]);
                    stock_id = Convert.ToInt32(dr["Stock_ID"]);
                    tb_Current_Stock.Text = Convert.ToString(dr["Current_Stock"]);
                    
                    dr.Close();
                    
                    dr1 = cmd2.ExecuteReader();   
                    if (dr1.Read())
                    {
                        cb_Category.Text = Convert.ToString(dr1["Category"]);
                        tb_Product_Name.Text = Convert.ToString(dr1["Product_name"]);

                        dr1.Close();
                        obj.cmd.Dispose();
                        tb_Current_Stock.Enabled = false;
                        btn_add_stock.Enabled = true;
                    }
                    else 
                    {
                        MessageBox.Show("Server Error...");
                    }
                }
                else
                {
                    MessageBox.Show("Server Error...");
                }

            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
        try{
            if (tb_Product_ID.Text != "" && tb_New_Stock.Text != "" && tb_Product_Name.Text != "" && cb_Category.Text != "")
            {
                int Sum = Convert.ToInt32(tb_Current_Stock.Text) + Convert.ToInt32(tb_New_Stock.Text);
                Common_Class obj = new Common_Class();
                int k = 0;
                k = obj.Auto_Increment("select count(Stock_id) from tbl_Stock_Added_Details", 1001);
               
                obj.openconnection();
                obj.cmd = new SqlCommand("Update tbl_Stock set  Current_Stock =  " + Sum + ",Stock_Added_Date = '" + dtp_Mfg.Text + "' where Stock_ID = " + stock_id + " ", obj.con);
                SqlCommand cmd1 = new SqlCommand("insert into tbl_Stock_Added_Details values (" + stock_id + " , " + tb_Current_Stock.Text + " ," + Sum + " , '" + dtp_Mfg.Text + "' )", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0 )
                {
                    btn_add_stock.Enabled = false;
                    tb_Product_ID.Text = "";
                    cb_Category.Text = "";
                    tb_New_Stock.Text = "";
                    tb_Product_ID.Text = "";
                    tb_Product_ID.Focus();
                    tb_Product_Name.Text = "";
                    tb_Current_Stock.Text = "";
                    MessageBox.Show("Record Saved Successfully..");
                }
                else
                {
                    MessageBox.Show("Record are Not saved Successfully..");
                }
                obj.cmd.Dispose();
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields..");
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void tb_Product_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }
    }
}
