using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using APMS;
using Saii_Carving_Shop_Management_System;

namespace Annapurna_Bazar_Mgt_System
{
    public partial class frm_Login : Form
    {
        Common_Class obj = new Common_Class();
        public SqlDataReader dr;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_login.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {

                obj.openconnection();
                SqlCommand cmd = new SqlCommand("select *  From tbl_login Where User_name = '" + this.tb_Username.Text + "' And Password = '" + this.tb_Password.Text + "' ", obj.con);
                //cmd.ExecuteScalar();
                //int i = Convert.ToInt32(cmd.ExecuteScalar());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successfull...");
                    this.Hide();
                    ABMS_MDI obj1 = new ABMS_MDI();
                    obj1.Show();
                }
                else
                {
                    MessageBox.Show("Login Filed..");
                    tb_Username.Text = "";
                    tb_Password.Text = "";
                    tb_Username.Focus();
                    tb_Password.Enabled = false;
                    btn_login.Enabled = false;
                }
                dr.Close();
                cmd.Dispose();
                obj.closeconnection();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UserManagement obj = new UserManagement();
            //obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
