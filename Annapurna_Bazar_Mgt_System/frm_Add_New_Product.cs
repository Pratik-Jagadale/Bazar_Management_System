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
    public partial class frm_Add_New_Product : Form
    {
        
        SqlDataReader dr;
        public frm_Add_New_Product()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
        try{
            Annapurna_Bazar_Mgt_System.Common_Class obj = new Common_Class();
            obj.openconnection();
            int i;
            i = obj.Auto_Increment("select count(Product_id) from tbl_Product", 1001);
            tb_Product_Id.Text = Convert.ToString(i);

            obj.openconnection();
            cb_Category.Items.Clear();
            obj.cmd = new SqlCommand("Select * from tbl_Product", obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Category.Items.Add((string)dr["Category"]);
            }
            dr.Dispose();
            obj.cmd.Dispose();

            tb_Product_Name.Text = "";
            obj.cmd = new SqlCommand("select distinct Product_name from tbl_Product where Category = '" + cb_Category.SelectedValue + "' ", obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_Product_Name.Items.Add((int)dr["Product_name"]);
            }
            
            dr.Dispose();
            obj.cmd.Dispose();
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
         try{
            Annapurna_Bazar_Mgt_System.Common_Class obj = new Common_Class();
            obj.openconnection();
            int Stock_id = 0;
            Stock_id = obj.Auto_Increment("select count(Stock_ID) from tbl_Stock", 1001);

            if (cb_Category.Text != "" && tb_Product_Name.Text != "" && tb_Stock.Text != "" && tb_ManufacturePrice.Text != "" && tb_Sales_Price.Text != "")
                {
                obj.openconnection();
                obj.cmd = new SqlCommand(" Insert into tbl_Product values(" + tb_Product_Id.Text + ",'" + cb_Category.Text + "','" + tb_Product_Name.Text + "'," + tb_gst.Text + ",'" + cb_Unit.Text + "'," + txt_Distributor_Id.Text + "," + tb_ManufacturePrice.Text + " , " + tb_Sales_Price.Text + ",'" + txt_Description.Text + "','" + dtp.Text + "') ", obj.con);
                
                SqlCommand cmd2 = new SqlCommand("insert tbl_Stock Values( " + Stock_id + "," + tb_Product_Id.Text + " , '" + cb_Unit.Text + "'," + tb_Stock.Text + " , '" + dtp.Text + "' )", obj.con);
                SqlCommand cmd1 = new SqlCommand("insert into tbl_Stock_Added_Details values (" + Stock_id + " , " + 0 + " ," + tb_Stock.Text + " , '" + dtp.Text + "' )", obj.con);


                if (Convert.ToInt32(obj.cmd.ExecuteNonQuery()) > 0 && Convert.ToInt32(cmd2.ExecuteNonQuery()) > 0 && Convert.ToInt32(cmd1.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("New Product Added Successfully...");
                        obj.cmd.Dispose();
                        cmd2.Dispose();
                        obj.closeconnection();
                        obj.ClearTextBoxes(this);
                        obj.ClearAllCombobox(this);
                    }
                    else
                    {
                        MessageBox.Show("Server Error..");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert data first..");
                }
         }
         catch (Exception ex)
         {
             //  Block of code to handle errors
             MessageBox.Show(ex.Message);
         }
        }   
    }
}
