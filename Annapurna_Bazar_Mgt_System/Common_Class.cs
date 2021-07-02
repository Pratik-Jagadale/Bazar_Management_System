using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Annapurna_Bazar_Mgt_System
{
    class Common_Class
    {                               
        //string connectionstring = (@"Data Source=.\SQLEXPRESS;Initial Catalog=ABMS;Integrated Security=True");
        string connectionstring = (@"Data Source=.\SQLEXPRESS;Initial Catalog=ABMS_log.LDF;Integrated Security=True");
                                       
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        public void openconnection()
        {
            con = new SqlConnection(connectionstring);
            con.Open();
        }
        public void closeconnection()
        {
            con.Close();
        }
        public int Auto_Increment(string get_current_id, int start_no)
        {
            openconnection();
            int cnt = 0;
            SqlCommand cmd = new SqlCommand(get_current_id, con);
            cnt = (int)(cmd.ExecuteScalar());
            cnt = cnt + start_no;
            cmd.Dispose();
            closeconnection();
            return cnt;
        }
        //public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        //{
        //    foreach (Control ctrl in ctrlCollection)
        //    {
        //        if (ctrl is TextBoxBase)
        //        {
        //            ctrl.Text = String.Empty;
        //        }
        //        else
        //        {
        //            ClearTextBoxes(ctrl.Controls);
        //        }
        //    }
        //}
        public void ClearAllCombobox(Form form)
        {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(ComboBox))
                {

                    control.Text = "";
                }

            }
        }
        public void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";

                }

            }
        }
        public void ClearTabControl(TabPage form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";
                }

            }
        }
        public void ClearGroupBox(GroupBox form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";
                }

            }
        }
        public void charlock(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public void numlock(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
        public void charforpoint(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        public void datagridview(string sqlcmd, DataGridView dgv)
        {
            openconnection();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv.DataSource = dt;
            da.Dispose();
            closeconnection();
        }
    }
}
