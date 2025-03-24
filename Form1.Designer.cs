namespace CRUDSYSTEM_SYSARCH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
#pragma warning disable CS0649  // Suppress unused field warning
        private System.ComponentModel.IContainer components;
#pragma warning restore CS0649


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
            this.lblCRUDSYSTEM = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.DepartmentID = new System.Windows.Forms.Label();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.DepartmentCode = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.DepartmentName = new System.Windows.Forms.Label();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.txtCollegeCode = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.CollegeID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.CollegeCode = new System.Windows.Forms.Label();
            this.CollegeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCRUDSYSTEM
            // 
            this.lblCRUDSYSTEM.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCRUDSYSTEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCRUDSYSTEM.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRUDSYSTEM.ForeColor = System.Drawing.Color.Gold;
            this.lblCRUDSYSTEM.Location = new System.Drawing.Point(421, 33);
            this.lblCRUDSYSTEM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCRUDSYSTEM.Name = "lblCRUDSYSTEM";
            this.lblCRUDSYSTEM.Size = new System.Drawing.Size(426, 91);
            this.lblCRUDSYSTEM.TabIndex = 0;
            this.lblCRUDSYSTEM.Text = "\r\nCRUD SYSTEM\r\n";
            this.lblCRUDSYSTEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 496);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 366);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.txtDepartmentID);
            this.panel2.Controls.Add(this.DepartmentID);
            this.panel2.Controls.Add(this.txtDepartmentCode);
            this.panel2.Controls.Add(this.DepartmentCode);
            this.panel2.Controls.Add(this.txtDepartmentName);
            this.panel2.Controls.Add(this.DepartmentName);
            this.panel2.Controls.Add(this.txtCollegeID);
            this.panel2.Controls.Add(this.txtCollegeCode);
            this.panel2.Controls.Add(this.chkIsActive);
            this.panel2.Controls.Add(this.txtCollegeName);
            this.panel2.Controls.Add(this.CollegeID);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.CollegeCode);
            this.panel2.Controls.Add(this.CollegeName);
            this.panel2.Location = new System.Drawing.Point(16, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 867);
            this.panel2.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(795, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 33);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(975, 16);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 33);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.Location = new System.Drawing.Point(566, 365);
            this.txtDepartmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentID.Multiline = true;
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(331, 34);
            this.txtDepartmentID.TabIndex = 33;
            // 
            // DepartmentID
            // 
            this.DepartmentID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DepartmentID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DepartmentID.Location = new System.Drawing.Point(270, 361);
            this.DepartmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(246, 38);
            this.DepartmentID.TabIndex = 32;
            this.DepartmentID.Text = "Department ID:";
            this.DepartmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentCode.Location = new System.Drawing.Point(566, 314);
            this.txtDepartmentCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentCode.Multiline = true;
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(331, 34);
            this.txtDepartmentCode.TabIndex = 31;
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DepartmentCode.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DepartmentCode.Location = new System.Drawing.Point(264, 310);
            this.DepartmentCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.Size = new System.Drawing.Size(294, 38);
            this.DepartmentCode.TabIndex = 30;
            this.DepartmentCode.Text = "Department Code:";
            this.DepartmentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(566, 262);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentName.Multiline = true;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(331, 34);
            this.txtDepartmentName.TabIndex = 29;
            // 
            // DepartmentName
            // 
            this.DepartmentName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DepartmentName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DepartmentName.Location = new System.Drawing.Point(271, 258);
            this.DepartmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(287, 38);
            this.DepartmentName.TabIndex = 28;
            this.DepartmentName.Text = "Department Name:";
            this.DepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeID.Location = new System.Drawing.Point(566, 177);
            this.txtCollegeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCollegeID.Multiline = true;
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(331, 34);
            this.txtCollegeID.TabIndex = 27;
            // 
            // txtCollegeCode
            // 
            this.txtCollegeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeCode.Location = new System.Drawing.Point(566, 121);
            this.txtCollegeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCollegeCode.Multiline = true;
            this.txtCollegeCode.Name = "txtCollegeCode";
            this.txtCollegeCode.Size = new System.Drawing.Size(331, 34);
            this.txtCollegeCode.TabIndex = 26;
            // 
            // chkIsActive
            // 
            this.chkIsActive.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chkIsActive.Location = new System.Drawing.Point(810, 407);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(97, 30);
            this.chkIsActive.TabIndex = 35;
            this.chkIsActive.Text = "is active";
            this.chkIsActive.UseVisualStyleBackColor = false;
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeName.Location = new System.Drawing.Point(566, 66);
            this.txtCollegeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCollegeName.Multiline = true;
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(331, 34);
            this.txtCollegeName.TabIndex = 22;
            // 
            // CollegeID
            // 
            this.CollegeID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CollegeID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CollegeID.Location = new System.Drawing.Point(270, 173);
            this.CollegeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CollegeID.Name = "CollegeID";
            this.CollegeID.Size = new System.Drawing.Size(246, 38);
            this.CollegeID.TabIndex = 19;
            this.CollegeID.Text = "College ID:\r\n";
            this.CollegeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(416, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Location = new System.Drawing.Point(207, 446);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Location = new System.Drawing.Point(20, 446);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CollegeCode
            // 
            this.CollegeCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CollegeCode.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CollegeCode.Location = new System.Drawing.Point(270, 121);
            this.CollegeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CollegeCode.Name = "CollegeCode";
            this.CollegeCode.Size = new System.Drawing.Size(275, 38);
            this.CollegeCode.TabIndex = 5;
            this.CollegeCode.Text = "College Code:\r\n";
            this.CollegeCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CollegeName
            // 
            this.CollegeName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CollegeName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CollegeName.Location = new System.Drawing.Point(270, 62);
            this.CollegeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CollegeName.Name = "CollegeName";
            this.CollegeName.Size = new System.Drawing.Size(288, 38);
            this.CollegeName.TabIndex = 4;
            this.CollegeName.Text = "College Name:";
            this.CollegeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1260, 1029);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCRUDSYSTEM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CRUD SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCRUDSYSTEM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CollegeName;
        private System.Windows.Forms.Label CollegeCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CollegeID;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.Label DepartmentName;
        private System.Windows.Forms.TextBox txtCollegeID;
        private System.Windows.Forms.TextBox txtCollegeCode;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label DepartmentID;
        private System.Windows.Forms.TextBox txtDepartmentCode;
        private System.Windows.Forms.Label DepartmentCode;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
    }
}

