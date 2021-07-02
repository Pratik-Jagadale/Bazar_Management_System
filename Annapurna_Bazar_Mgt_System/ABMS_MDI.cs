using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APMS;
using Saii_Carving_Shop_Management_System;
using Annapurna_Bazar_Mgt_System.Report;

namespace Annapurna_Bazar_Mgt_System
{
    public partial class ABMS_MDI : Form
    {
        

       // private int childFormNumber = 0;

        public ABMS_MDI()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Customer obj = new frm_Add_Customer();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addNewProdcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product obj = new frm_Add_New_Product();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Product obj = new frm_Update_Product();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewSearchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Product_Details obj = new frm_View_Product_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addUpdateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Stock obj = new frm_Add_Stock();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewSearchStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Stock_update obj = new frm_View_Stock_update();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Distributor obj = new frm_Add_Distributor();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void upadateDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Distributor obj = new frm_Update_Distributor();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewSearchDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Distributor obj = new frm_View_Distributor();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void userManagemnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement obj = new UserManagement();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void customerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Customer_Report obj = new frm_Customer_Report();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Customer_Date_wise_Report obj = new frm_Customer_Date_wise_Report();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void productWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Report obj = new Product_Report();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void dateWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Product_P_date_wise_Report obj = new frm_Product_P_date_wise_Report();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void productWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Stock_Report obj = new frm_Stock_Report();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        //private void dateWiseToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    frm_Stock_report_date_wise obj = new frm_Stock_report_date_wise();
        //    obj.MdiParent = this;
        //    obj.WindowState = FormWindowState.Maximized;
        //    obj.Show();
        //}

    }
}
