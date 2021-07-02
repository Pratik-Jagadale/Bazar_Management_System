using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Annapurna_Bazar_Mgt_System
{
    public partial class frm_Update_Product : Form
    {
        public SqlDataReader dr;
        public frm_Update_Product()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
         try{   
            if (txt_Product_Id.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Select * from tbl_Product where Product_id =" + txt_Product_Id.Text + "", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Product_Name.Text = Convert.ToString(dr["Product_id"]);
                    cmb_Category.Text = Convert.ToString(dr["Category"]);
                    txt_Product_Name.Text = Convert.ToString(dr["Product_name"]);
                    txt_GST_Applied.Text = Convert.ToString(dr["GST"]);
                    tb_unit.Text = Convert.ToString(dr["Unit"]);
                    cmb_Distributor_Name.Text = Convert.ToString(dr["Distributor_id"]);
                    txt_Purchase_Rate.Text = Convert.ToString(dr["Manufacture_price"]);
                    txt_Sales_Rate.Text = Convert.ToString(dr["Sales_Price"]);
                    txt_Description.Text = Convert.ToString(dr["Description"]);
                    
                }
                else
                {
                    MessageBox.Show("Record Not Found..");
                }
                dr.Close();
                obj.cmd.Dispose();
                obj.closeconnection();
            }
            else
            {
                MessageBox.Show("First enter Employee ID...");
            }

         }
         catch (Exception ex)
         {
             //  Block of code to handle errors
             MessageBox.Show(ex.Message);
         }
        }

        private void txt_Product_Id_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try{
            if (cmb_Category.Text != "" && txt_Product_Name.Text != "" && tb_unit.Text != "" && txt_Purchase_Rate.Text != "" && txt_GST_Applied.Text != "" && txt_Sales_Rate.Text != "" && txt_Description.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
              // obj.cmd = new SqlCommand("update tbl_Product set Category='" + cmb_Category.Text + "',Prouduct_name = '" + txt_Product_Name.Text + "', GST = "+ txt_GST_Applied.Text +",Unit = '" + tb_unit.Text + "' , Distributor_id = " + cmb_Distributor_Name.Text  + " , Manufacture_price = "+ txt_Purchase_Rate.Text +" , Sales_Price = "+ txt_Sales_Rate.Text +" ,Description = '" + txt_Description.Text + '" where Product_id=" + txt_Product_Id.Text +" ",obj.con);
               obj.cmd = new SqlCommand("Update tbl_Product set Category ='"+ cmb_Category.Text +"', Product_name ='"+ txt_Product_Name.Text+"' ,GST= "+ txt_GST_Applied.Text +",  Unit = '"+tb_unit.Text + "', Distributor_id = "+ cmb_Distributor_Name.Text +" ,Manufacture_price = "+ txt_Purchase_Rate.Text +",Sales_Price = "+ txt_Sales_Rate.Text +" ,Description= '" + txt_Description.Text +"'  where Product_id=" + txt_Product_Id.Text + "",obj.con);
              
                
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Updated Successfully..");
                    obj.closeconnection();
                    obj.ClearGroupBox(Gpb_Product_Detail);
                    cmb_Distributor_Name.Text = "";
                    cmb_Category.Text = "";
                }


            }
            else
            {
                MessageBox.Show("Please Enter Valid Product ID");
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
