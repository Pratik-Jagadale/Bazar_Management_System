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
    public partial class frm_Add_Distributor : Form
    {
        public frm_Add_Distributor()
        {
            InitializeComponent();
        }

        private void frm_Add_Distributor_Load(object sender, EventArgs e)
        {
            try{
            Common_Class obj = new Common_Class();
            obj.openconnection();
            int i;
            i = obj.Auto_Increment("select count(Distributor_id) from tbl_Distributor", 1001);
            txt_Distributor_Id.Text = Convert.ToString(i);
            txt_FirstName.Focus();
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
            if (txt_Aadhar_No.Text != "" && txt_Address.Text != "" && txt_FirstName.Text != "" && txt_Last_Name.Text != "" && txt_Middle_Name.Text != "" && txt_Mob_No.Text != "" && txt_Reg.Text != "")
            {
                int alt_mob = 0;
                if (txt_Alt_Con_No.Text != "")
                {
                    alt_mob = Convert.ToInt32(txt_Alt_Con_No.Text);
                }
                else
                {
                    alt_mob = 0;
                }
                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Insert into tbl_Distributor values ( " + txt_Distributor_Id.Text  + " , '" + txt_FirstName.Text + "' , '" + txt_Middle_Name.Text + "' , '" + txt_Last_Name.Text + "' , '" + txt_Address.Text + "' , '" + dtp_Tie_Up_Date.Text + "' , " + txt_Mob_No.Text + " , " + alt_mob + " , " + txt_Aadhar_No.Text + " , '" + txt_Pan_No.Text + "' , " + txt_Reg.Text + ") ",obj.con);
                
                if (Convert.ToInt32(obj.cmd.ExecuteNonQuery()) > 0 )
                {
                    MessageBox.Show("New Distributor Added Successfully...");
                    obj.ClearGroupBox(Gpb_Distributor_Detail);
                    obj.cmd.Dispose();
                    obj.closeconnection();
                    obj.ClearTextBoxes(this);
                    obj.ClearAllCombobox(this);
                }
                else
                {
                    MessageBox.Show("Server Error..");
                }

            }
            else {
                MessageBox.Show("Please insert the all required fileds...");
            
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
        try
        {
            Common_Class obj = new Common_Class();
            obj.ClearGroupBox(Gpb_Distributor_Detail);
            obj.cmd.Dispose();
            obj.closeconnection();
            obj.ClearTextBoxes(this);
            obj.ClearAllCombobox(this);

        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        
    }
}
