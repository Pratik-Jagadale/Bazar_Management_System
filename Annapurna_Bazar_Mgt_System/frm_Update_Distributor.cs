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
    public partial class frm_Update_Distributor : Form
    {
        public SqlDataReader dr;
        public frm_Update_Distributor()
        {
            InitializeComponent();
        }

        private void frm_Update_Distributor_Load(object sender, EventArgs e)
        {
            txt_Distributor_Id.Focus();
        }

        private void txt_Distributor_Id_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Distributor_Id.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Select * from tbl_Distributor where Distributor_id =" + txt_Distributor_Id.Text + "", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Distributor_Id.Enabled = false;
                    txt_FirstName.Text = Convert.ToString(dr["F_Name"]);
                    //cmb_Category.Text = Convert.ToString(dr["F_Name"]);
                    txt_Middle_Name.Text = Convert.ToString(dr["M_Name"]);
                    txt_Last_Name.Text = Convert.ToString(dr["L_Name"]);
                    txt_Address.Text = Convert.ToString(dr["Address"]);
                    txt_Mob_No.Text = Convert.ToString(dr["Mobile_no"]);
                    txt_Alt_Con_No.Text = Convert.ToString(dr["Alt_Mobile_no"]);
                    txt_Adhaar_No.Text = Convert.ToString(dr["Adhar_no"]);
                    txt_Pan_No.Text = Convert.ToString(dr["Pan_no"]);
                    txt_Reg_No.Text = Convert.ToString(dr["Reg_no"]);

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
                MessageBox.Show("First enter Distributor ID...");
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try{
            if(txt_Address.Text != "")
            {
                Common_Class obj = new Common_Class();
               obj.openconnection();
               txt_Distributor_Id.Enabled = false;
                    
               obj.cmd = new SqlCommand("Update tbl_Distributor set F_Name ='"+ txt_FirstName.Text +"', M_Name ='"+ txt_Middle_Name.Text+"' ,L_Name= '"+ txt_Last_Name.Text +"', Address = '"+txt_Address.Text+"', Mobile_no = "+ txt_Mob_No.Text +" ,Alt_Mobile_no = "+ txt_Alt_Con_No.Text +",Adhar_no = "+ txt_Adhaar_No.Text +" ,Pan_no= '" + txt_Pan_No.Text +"' ,Reg_no = "+txt_Reg_No.Text +" where Distributor_id=" + txt_Distributor_Id.Text + "",obj.con);
               if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Updated Successfully...");
                    txt_Distributor_Id.Enabled = true;
                    txt_Distributor_Id.Focus();
                    btn_Search.Enabled = false;
                    btn_Update.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Records Not Updated Successfully...");
                }
               obj.ClearGroupBox(Gpb_Distributor_Detail);
                obj.cmd.Dispose();
                obj.ClearAllCombobox(this);
                obj.ClearTextBoxes(this);
                obj.closeconnection();
                    }
                    else
                    {
                        MessageBox.Show("First fill all fields...");
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
