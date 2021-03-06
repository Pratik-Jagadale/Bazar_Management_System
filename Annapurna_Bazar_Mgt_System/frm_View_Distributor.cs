using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Annapurna_Bazar_Mgt_System
{
    public partial class frm_View_Distributor : Form
    {
        string str;
        public frm_View_Distributor()
        {
            InitializeComponent();
        }

        private void frm_View_Distributor_Load(object sender, EventArgs e)
        {
            try{
            // TODO: This line of code loads data into the 'aBMSDataSet.tbl_Distributor' table. You can move, or remove it, as needed.
            //this.tbl_DistributorTableAdapter.Fill(this.aBMSDataSet.tbl_Distributor);
            cb_e_name.Enabled = false;
            str = "select * from tbl_Distributor";
            Common_Class obj = new Common_Class();
            obj.datagridview(str, dgv_Distributor_Detail);
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Search_Distributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            cb_e_name.Enabled = true;
            if (cmb_Search_Distributor.SelectedIndex == 0)
            {
                cb_e_name.DisplayMember = "Employee_ID";
                cb_e_name.ValueMember = "Employee_ID";
            }
            else if (cmb_Search_Distributor.SelectedIndex == 1)
            {
                cb_e_name.DisplayMember = "Mobile_Number";
                cb_e_name.ValueMember = "Mobile_Number";
            }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try{
            if (cmb_Search_Distributor.SelectedIndex != -1 && cb_e_name.Text != "")
            {
                Common_Class obj = new Common_Class();
                obj.openconnection();
                if (cmb_Search_Distributor.SelectedIndex == 0)
                {
                    str = "select * from tbl_Distributor where Distributor_id = " + cb_e_name.Text + "";
                    //obj.cmd = new SqlCommand("select * from tbl_Add_New_Employee where Employee_ID = " + cb_e_name.Text + "", obj.con);
                }
                else if (cmb_Search_Distributor.SelectedIndex == 1)
                {
                    str = "select * from tbl_Distributor where Mobile_no = " + cb_e_name.Text + "";
                    //obj.cmd = new SqlCommand("select * from tbl_Add_New_Employee where Mobile_Number = " + cb_e_name.Text + "", obj.con);
                }

                obj.datagridview(str, dgv_Distributor_Detail);
            }
            else
            {
                MessageBox.Show("first select Employee type and Enter Employee Information");
            }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Refresh_Grid_Click(object sender, EventArgs e)
        {
            try{
            str = "select * from tbl_Distributor";
            Common_Class obj = new Common_Class();
            obj.datagridview(str, dgv_Distributor_Detail);
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_e_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
