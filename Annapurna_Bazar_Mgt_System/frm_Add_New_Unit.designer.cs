namespace APMS
{
    partial class frm_Add_New_Unit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Add_Unit = new System.Windows.Forms.Label();
            this.lbl_Unit_Name = new System.Windows.Forms.Label();
            this.lbl_Unit_Id = new System.Windows.Forms.Label();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.tb_Unit_ID = new System.Windows.Forms.TextBox();
            this.Pnl_AddUnit = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Pnl_AddUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Unit
            // 
            this.lbl_Add_Unit.AutoSize = true;
            this.lbl_Add_Unit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_Unit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Add_Unit.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Unit.ForeColor = System.Drawing.Color.Black;
            this.lbl_Add_Unit.Location = new System.Drawing.Point(429, 26);
            this.lbl_Add_Unit.Name = "lbl_Add_Unit";
            this.lbl_Add_Unit.Size = new System.Drawing.Size(252, 64);
            this.lbl_Add_Unit.TabIndex = 22;
            this.lbl_Add_Unit.Text = "Add Unit";
            // 
            // lbl_Unit_Name
            // 
            this.lbl_Unit_Name.AutoSize = true;
            this.lbl_Unit_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Name.Location = new System.Drawing.Point(219, 338);
            this.lbl_Unit_Name.Name = "lbl_Unit_Name";
            this.lbl_Unit_Name.Size = new System.Drawing.Size(171, 34);
            this.lbl_Unit_Name.TabIndex = 21;
            this.lbl_Unit_Name.Text = "Unit Name";
            // 
            // lbl_Unit_Id
            // 
            this.lbl_Unit_Id.AutoSize = true;
            this.lbl_Unit_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Id.Location = new System.Drawing.Point(219, 193);
            this.lbl_Unit_Id.Name = "lbl_Unit_Id";
            this.lbl_Unit_Id.Size = new System.Drawing.Size(123, 34);
            this.lbl_Unit_Id.TabIndex = 20;
            this.lbl_Unit_Id.Text = "Unit Id";
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(651, 346);
            this.tb_Category_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Category_Name.MaxLength = 80;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(333, 31);
            this.tb_Category_Name.TabIndex = 2;
            // 
            // tb_Unit_ID
            // 
            this.tb_Unit_ID.Enabled = false;
            this.tb_Unit_ID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit_ID.Location = new System.Drawing.Point(651, 201);
            this.tb_Unit_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Unit_ID.MaxLength = 5;
            this.tb_Unit_ID.Name = "tb_Unit_ID";
            this.tb_Unit_ID.Size = new System.Drawing.Size(333, 31);
            this.tb_Unit_ID.TabIndex = 1;
            // 
            // Pnl_AddUnit
            // 
            this.Pnl_AddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Pnl_AddUnit.Controls.Add(this.lbl_Add_Unit);
            this.Pnl_AddUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_AddUnit.ForeColor = System.Drawing.Color.Coral;
            this.Pnl_AddUnit.Location = new System.Drawing.Point(0, 0);
            this.Pnl_AddUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_AddUnit.Name = "Pnl_AddUnit";
            this.Pnl_AddUnit.Size = new System.Drawing.Size(1160, 119);
            this.Pnl_AddUnit.TabIndex = 23;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(459, 440);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(155, 49);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // frm_Add_New_Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 558);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Pnl_AddUnit);
            this.Controls.Add(this.lbl_Unit_Name);
            this.Controls.Add(this.lbl_Unit_Id);
            this.Controls.Add(this.tb_Category_Name);
            this.Controls.Add(this.tb_Unit_ID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Unit";
            this.Pnl_AddUnit.ResumeLayout(false);
            this.Pnl_AddUnit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Unit;
        private System.Windows.Forms.Label lbl_Unit_Name;
        private System.Windows.Forms.Label lbl_Unit_Id;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.TextBox tb_Unit_ID;
        private System.Windows.Forms.Panel Pnl_AddUnit;
        private System.Windows.Forms.Button btn_Save;
    }
}