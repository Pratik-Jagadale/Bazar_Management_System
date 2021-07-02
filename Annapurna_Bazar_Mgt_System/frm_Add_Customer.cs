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
    public partial class frm_Add_Customer : Form
    {
       // public Common_Class obj = new Common_Class();
        int p_id;
        public SqlDataReader dr;
        public int current_stock_val = 0;
        int stock_id;

      //  public int p_Stock_Array = new p_Stock_Array[100];
        public double Total;

        public frm_Add_Customer()
        {
            InitializeComponent();
        }

        private void frm_Add_Customer_Load(object sender, EventArgs e)
        {
           try{
            // TODO: This line of code loads data into the 'dataset_category.tbl_Product' table. You can move, or remove it, as needed.
            Common_Class obj = new Common_Class();
            obj.openconnection();
           //this.tbl_ProductTableAdapter.Fill(this.dataset_category.tbl_Product);int i = 0;
            int i = obj.Auto_Increment("select count(Cust_id) from Customer_Details", 1001);
            tb_Customer_ID.Text = Convert.ToString(i);


            
            obj.openconnection();
            obj.cmd = new SqlCommand("Select * from tbl_Product", obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Category.Items.Add((string)dr["Category"]);
            }
            dr.Close();
            obj.cmd.Dispose();
           }
           catch (Exception ex)
           {
               //  Block of code to handle errors
               MessageBox.Show(ex.Message);
           }
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
        try{
            Common_Class obj = new Common_Class();
            obj.openconnection();
            obj.cmd = new SqlCommand("select distinct Product_name from tbl_Product where Category='" + cb_Category.Text + "'", obj.con);
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Product_Name.Items.Add((String)dr["Product_name"]);
            }
            obj.cmd.Dispose();
            dr.Close();

        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void cb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
        try{
            if (cb_Category.Text != "" && cb_Product_Name.Text != "")
            {
                Common_Class obj = new Common_Class();
            obj.openconnection();

            obj.cmd = new SqlCommand("select *  from tbl_Product where Category ='" + cb_Category.Text + "' AND Product_name = '" + cb_Product_Name.Text + "'", obj.con);
      
            dr = obj.cmd.ExecuteReader();
            while (dr.Read())
            {
                p_id = Convert.ToInt32(dr["Product_id"]);
                cb_Unit.Text = Convert.ToString(dr["Unit"]);
                tb_Price.Text = Convert.ToString(dr["Sales_Price"]);
            }
            //obj.cmd.Dispose();
            dr.Close();
       

            //obj.cmd.Dispose();

            obj.cmd = new SqlCommand("select Current_Stock from tbl_Stock where Product_id=" + p_id + " ", obj.con);
            current_stock_val = (int)obj.cmd.ExecuteScalar();
            obj.cmd.Dispose();
            dr.Close();
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
        try
        {
            Common_Class obj = new Common_Class();
            if (tb_Quantity.Text != "" && tb_Price.Text != "" && tb_Total_Price.Text != "")
            {
                if (current_stock_val < int.Parse(tb_Quantity.Text))
                {
                    MessageBox.Show("There is no enough stock available... STOCK Available is = " + current_stock_val + " ");
                }
                else
                {
                    Total = double.Parse(tb_Total_Price.Text) + double.Parse(tb_Totalbill.Text);
                    tb_Totalbill.Text = Convert.ToString(Total);
                    tb_Final_Bill.Text = Convert.ToString(Total);
                    dgv_Add_Customer.Rows.Add(tb_Customer_ID.Text, D_T_P.Text, cb_Category.Text, cb_Product_Name.Text, tb_Quantity.Text, tb_Price.Text, tb_Total_Price.Text);
                    btn_Save.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Please First Fill All Fields...");
            }
            obj.ClearGroupBox(groupBox2);
            cb_Category.Text = "";
            cb_Product_Name.Text = "";
            cb_Unit.Text = "";

            if (tb_Totalbill.Text != "")
            {
                double dcnt;
                dcnt = double.Parse(tb_GST.Text) / 100;
                double val1 = double.Parse(tb_Totalbill.Text);
                double diff = val1 + (dcnt * val1);
                tb_gst_price.Text = Convert.ToString(dcnt * val1);
                tb_Final_Bill.Text = Convert.ToString(diff);
            }
            else if (tb_Discount.Text != "" && tb_Final_Bill.Text != "")
            {
                double dcnt;
                dcnt = double.Parse(tb_GST.Text) / 100;
                double val1 = double.Parse(tb_Final_Bill.Text);
                double diff = val1 + (dcnt * val1);
                tb_Final_Bill.Text = Convert.ToString(diff);
            }
            else if (tb_Discount.Text != "" && tb_GST.Text == "")
            {
                tb_Discount_TextChanged(this, null);
            }
            else if (tb_Discount.Text == "" && tb_GST.Text == "")
            {
                tb_Final_Bill.Text = tb_Totalbill.Text;
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void cb_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {   
        try
        {
            float sum;
            if (tb_Quantity.Text != "")
            {
                if (current_stock_val < Convert.ToInt32(tb_Quantity.Text))
                {
                    MessageBox.Show("There no enough Stock available...  Available Stock = " + current_stock_val + "");
                    tb_Quantity.Text = "";
                    tb_Quantity.Focus();
                }
                sum = float.Parse(tb_Quantity.Text) * float.Parse(tb_Price.Text);
                tb_Total_Price.Text = Convert.ToString(sum);
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void cb_Product_Name_Leave(object sender, EventArgs e)
        {
            
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = 0;
                if (tb_Discount.Text == "" && tb_Totalbill.Text != "")
                {

                    if (tb_Discount.Text == "") { temp = 0; }
                    double dcnt;
                    dcnt = temp / 100;
                    double val1 = double.Parse(tb_Final_Bill.Text);
                    double diff = val1 - (dcnt * val1);
                    tb_Final_Bill.Text = Convert.ToString(diff);
                }
                else if (tb_Discount.Text != "")
                {
                   // tb_Discount.Text = Convert.ToString('0');
                    double dcnt;
                    dcnt = double.Parse(tb_Discount.Text) / 100;
                    double val1 = double.Parse(tb_Final_Bill.Text);
                    double diff = val1 - (dcnt * val1);
                    tb_Final_Bill.Text = Convert.ToString(diff);
                }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                
                Common_Class obj = new Common_Class();
                 
                if (tb_Final_Bill.Text != "")
                {
    
                    obj.openconnection();
                    obj.cmd = new SqlCommand(" insert into Customer_Details values (" + tb_Customer_ID.Text + " , '" + tb_Customer_Name.Text + "' , '" + D_T_P.Text + "' ," + tb_GST.Text + " ," + tb_Mobile_No.Text + ", " + tb_Totalbill.Text + " , " + tb_Discount.Text + " , " + tb_Final_Bill.Text + " )", obj.con);

                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                        goto nxtquery;
                    }
                    else
                    {
                        MessageBox.Show("Record are Not saved Successfully");
                    }
                nxtquery: ;
                   // obj.cmd.Dispose();

                    int i = 0;
                    foreach (DataGridViewRow row in dgv_Add_Customer.Rows)
                    {
                        if (i == (dgv_Add_Customer.Rows.Count - 1))
                        {
                            goto nxt;
                        }
                       
                        obj.cmd = new SqlCommand(" Insert into Cust_P_Details values(" + dgv_Add_Customer.Rows[i].Cells[0].Value + ",'" + dgv_Add_Customer.Rows[i].Cells[1].Value + "','" + dgv_Add_Customer.Rows[i].Cells[2].Value + "','" + dgv_Add_Customer.Rows[i].Cells[3].Value + "'," + dgv_Add_Customer.Rows[i].Cells[4].Value + "," + dgv_Add_Customer.Rows[i].Cells[5].Value + "," + dgv_Add_Customer.Rows[i].Cells[6].Value + ")", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        
                       ////////////////////////////////Stock Manipulation//////////////////////////////
                        
                        obj.cmd = new SqlCommand("select Product_id from tbl_Product where Category = '" + dgv_Add_Customer.Rows[i].Cells[2].Value + "' and Product_name = '" + dgv_Add_Customer.Rows[i].Cells[3].Value + "'", obj.con);
                        int P_id = Convert.ToInt32(obj.cmd.ExecuteScalar());
                        if(P_id < 0){
                            MessageBox.Show("Error select query.......");
                        }
                                        
                                        SqlCommand cmd2 = new SqlCommand("select * from tbl_Stock where Product_id = " + P_id + "", obj.con);
                                        dr = cmd2.ExecuteReader();

                                        if (dr.Read())
                                        {
                                            current_stock_val = Convert.ToInt32(dr["Current_Stock"]);
                                            stock_id = Convert.ToInt32(dr["Stock_ID"]);
                                            dr.Close();
                                        }

                                        int k = 0;
                                        k = obj.Auto_Increment("select count(Stock_id) from tbl_Stock_Added_Details", 1001);

                        int Sum = Convert.ToInt32(current_stock_val) - Convert.ToInt32(dgv_Add_Customer.Rows[i].Cells[4].Value);
                        
                        obj.openconnection();
                        obj.cmd = new SqlCommand("Update tbl_Stock set  Current_Stock =  " + Sum + ",Stock_Added_Date = '" + D_T_P.Text + "' where Stock_ID = " + P_id + " ", obj.con);
                        SqlCommand cmd1 = new SqlCommand("insert into tbl_Stock_Added_Details values (" + stock_id + " , " + current_stock_val + " ," + Sum + " , '" + D_T_P.Text + "' )", obj.con);
                        if (obj.cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                        {

                        }
                        else 
                        {
                            MessageBox.Show("Insert query failed...");
                        }
                        
                       ///////////////////////////////////////////////////////////////////////////
                        i = i + 1;

                    }
                nxt: ;

                    if (i > 0)
                    {
                         MessageBox.Show("Record Added Successfully...");
                    }
                    else
                    {
                        MessageBox.Show("Server Error..");
                    }

                    obj.ClearGroupBox(groupBox1);
                    obj.ClearGroupBox(groupBox2);
                    tb_Totalbill.Text = "0";
                    tb_Discount.Text = "";
                    tb_Final_Bill.Text = "";
                    tb_gst_price.Text = "";
                    obj.cmd.Dispose();
                    obj.closeconnection();
                    if (this.dgv_Add_Customer.DataSource != null)
                    {
                        this.dgv_Add_Customer.DataSource = null;
                    }
                    else
                    {
                        this.dgv_Add_Customer.Rows.Clear();
                    }

                    int f = 0;
                    f = obj.Auto_Increment("select count(Cust_id) from Customer_Details", 1001);
                    tb_Customer_ID.Text = Convert.ToString(f);
                }
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {

                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.ClearGroupBox(groupBox1);
                obj.ClearGroupBox(groupBox2);
                tb_Totalbill.Text = "0";
                tb_Discount.Text = "";
                tb_Final_Bill.Text = "";
                tb_gst_price.Text = "";
                obj.cmd.Dispose();
                obj.closeconnection();
                if (this.dgv_Add_Customer.DataSource != null)
                {
                    this.dgv_Add_Customer.DataSource = null;
                }
                else
                {
                    this.dgv_Add_Customer.Rows.Clear();
                }

                int f = 0;
                f = obj.Auto_Increment("select count(Cust_id) from Customer_Details", 1001);
                tb_Customer_ID.Text = Convert.ToString(f);
                obj.closeconnection();
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_Discount_Enter(object sender, EventArgs e)
        {
           
        }

        
    }
}
