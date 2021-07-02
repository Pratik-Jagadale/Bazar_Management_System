using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Annapurna_Bazar_Mgt_System;

namespace Saii_Carving_Shop_Management_System
{
    public partial class UserManagement : Form
    {
        SqlDataReader dr;
        string username = "";
        string password = "";
        public UserManagement()
        {
            InitializeComponent();
        }
        public void function_Clear()
        {
            Common_Class obj = new Common_Class();
            obj.ClearTabControl(tp_Add_New_User);
           
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            try{
            if (tab_UserManagement.SelectedIndex == 0)
            {
                Common_Class obj = new Common_Class();
                int i = 0;
                i = obj.Auto_Increment("select count(ID) from tbl_Login", 100);
                tb_ID.Text = Convert.ToString(i);
            }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }
        private void tab_UserManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
        try{
            if (tab_UserManagement.SelectedIndex == 0)
            {
                Common_Class obj = new Common_Class();
                int i = 0;
                i = obj.Auto_Increment("select count(ID) from tbl_Login", 100);
                tb_ID.Text = Convert.ToString(i);
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try{
            if (tb_User.Text != "" && tb_Enter_Pass.Text != "" && tb_Conf_Pass.Text != "")
            {
                if (tb_Enter_Pass.Text == tb_Conf_Pass.Text)
                {
                    Common_Class obj = new Common_Class();
                    obj.openconnection();
                    obj.cmd = new SqlCommand("insert into tbl_login values(" + tb_ID.Text + ",'" + tb_User.Text + "','" + tb_Enter_Pass.Text + "')", obj.con);
                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Saved Successfully");
                        obj.ClearTabControl(tp_Add_New_User);
                        UserManagement_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Record are Not saved Successfully");
                    }
                    obj.cmd.Dispose();
                    obj.closeconnection();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Conform Password");
                }
            }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_NewPassClear_Click(object sender, EventArgs e)
        {
            Common_Class obj = new Common_Class();
            obj.ClearTabControl(tp_Add_New_User);
            UserManagement_Load(this, null);
        }

        private void btn_changepass_Search_Click(object sender, EventArgs e)
        {
        try{
            if (tbc_Current_Password.Text != "" && tbc_Username.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_login where User_name = '" + tbc_Username.Text + "' and Password = '" + tbc_Current_Password.Text + "'", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    username = Convert.ToString(dr["User_name"]);
                    password = Convert.ToString(dr["Password"]);
                    obj.cmd.Dispose();
                    if (tbc_Username.Text == username)
                    {
                        if (tbc_Current_Password.Text == password)
                        {
                            tbc_user_id.Text = Convert.ToString(dr["ID"]);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username");
                    }
                }
                else
                {
                    MessageBox.Show(" Recored Not Found");
                }
                dr.Dispose();
            }
            else
            {
                MessageBox.Show("Please Enter Username and password First..");
            }
        }
        catch (Exception ex)
        {
            //  Block of code to handle errors
            MessageBox.Show(ex.Message);
        }
        }

        private void btn_Update_Password_Click(object sender, EventArgs e)
        {
            try{
            if (tbc_Username.Text != "" && tbc_New_Password.Text != "" && tbc_Current_Password.Text != "")
            {
                Common_Class obj = new Common_Class();
                    obj.openconnection();
                    obj.cmd = new SqlCommand("update tbl_Login set Password ='" + tbc_New_Password.Text + "' where ID = " + tbc_user_id.Text + "", obj.con);
                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        obj.ClearTabControl(tab_change_pass);
                    }
                    else
                    {
                        MessageBox.Show("Record are Not Updated Successfully");
                    }
                    obj.cmd.Dispose();
                    obj.closeconnection();
            }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_changepass_Clear_Click(object sender, EventArgs e)
        {
            Common_Class obj = new Common_Class();
            obj.ClearTabControl(tab_change_pass);
        }

        private void btn_deleteusersearch_Click(object sender, EventArgs e)
        {
            try{
            if (tbd_Pass.Text != "" && tbd_Uname.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from tbl_Login where User_name = '" + tbd_Uname.Text + "' and Password = '" + tbd_Pass.Text + "'", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    username = Convert.ToString(dr["User_name"]);
                    password = Convert.ToString(dr["Password"]);
                    obj.cmd.Dispose();
                    if (tbd_Uname.Text == username)
                    {
                        if (tbd_Pass.Text == password)
                        {
                            tbd_U_ID.Text = Convert.ToString(dr["ID"]);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username");
                    }
                }
                else
                {
                    MessageBox.Show(" Recored Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Username and password First..");
            }
            dr.Dispose();
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try{
            if (tbd_Uname.Text != "" && tbd_Pass.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
                obj.cmd = new SqlCommand("Delete from tbl_Login where User_name = '" + tbd_Uname.Text + "' and Password = '" + tbd_Pass.Text + "' ", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    obj.ClearTabControl(tab_delete_user);
                }
                else
                {
                    MessageBox.Show("Record Are Not Deleted");
                }
            }
            else
            {
                MessageBox.Show("The Field IS Empty..");
            }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deletclear_Click(object sender, EventArgs e)
        {
            Common_Class obj = new Common_Class();
            obj.ClearTabControl(tab_delete_user);
        }
    }
}
