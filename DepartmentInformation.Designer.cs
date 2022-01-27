namespace EmployeeInformationSystem
{
    partial class DepartmentInformation
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
            this.btnDepartmentHome = new System.Windows.Forms.Button();
            this.dataGridViewDepartmentInformation = new System.Windows.Forms.DataGridView();
            this.btnDepartmentInformationDelete = new System.Windows.Forms.Button();
            this.btnDepartmentInformationUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentInformationInsert = new System.Windows.Forms.Button();
            this.txtDepartmentInformationEmployeeId = new System.Windows.Forms.TextBox();
            this.lblDepartmentInformationEmployeeId = new System.Windows.Forms.Label();
            this.txtDepartmentInformationDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepartmentHome
            // 
            this.btnDepartmentHome.Location = new System.Drawing.Point(13, 13);
            this.btnDepartmentHome.Name = "btnDepartmentHome";
            this.btnDepartmentHome.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentHome.TabIndex = 0;
            this.btnDepartmentHome.Text = "Home";
            this.btnDepartmentHome.UseVisualStyleBackColor = true;
            this.btnDepartmentHome.Click += new System.EventHandler(this.btnDepartmentHome_Click);
            // 
            // dataGridViewDepartmentInformation
            // 
            this.dataGridViewDepartmentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentInformation.Location = new System.Drawing.Point(299, 39);
            this.dataGridViewDepartmentInformation.Name = "dataGridViewDepartmentInformation";
            this.dataGridViewDepartmentInformation.Size = new System.Drawing.Size(278, 184);
            this.dataGridViewDepartmentInformation.TabIndex = 29;
            this.dataGridViewDepartmentInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmentInformation_CellContentClick);
            // 
            // btnDepartmentInformationDelete
            // 
            this.btnDepartmentInformationDelete.Location = new System.Drawing.Point(489, 241);
            this.btnDepartmentInformationDelete.Name = "btnDepartmentInformationDelete";
            this.btnDepartmentInformationDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentInformationDelete.TabIndex = 28;
            this.btnDepartmentInformationDelete.Text = "Delete";
            this.btnDepartmentInformationDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentInformationDelete.Click += new System.EventHandler(this.btnDepartmentInformationDelete_Click);
            // 
            // btnDepartmentInformationUpdate
            // 
            this.btnDepartmentInformationUpdate.Location = new System.Drawing.Point(398, 241);
            this.btnDepartmentInformationUpdate.Name = "btnDepartmentInformationUpdate";
            this.btnDepartmentInformationUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentInformationUpdate.TabIndex = 27;
            this.btnDepartmentInformationUpdate.Text = "Update";
            this.btnDepartmentInformationUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentInformationUpdate.Click += new System.EventHandler(this.btnDepartmentInformationUpdate_Click);
            // 
            // btnDepartmentInformationInsert
            // 
            this.btnDepartmentInformationInsert.Location = new System.Drawing.Point(303, 241);
            this.btnDepartmentInformationInsert.Name = "btnDepartmentInformationInsert";
            this.btnDepartmentInformationInsert.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentInformationInsert.TabIndex = 26;
            this.btnDepartmentInformationInsert.Text = "Insert";
            this.btnDepartmentInformationInsert.UseVisualStyleBackColor = true;
            this.btnDepartmentInformationInsert.Click += new System.EventHandler(this.btnDepartmentInformationInsert_Click);
            // 
            // txtDepartmentInformationEmployeeId
            // 
            this.txtDepartmentInformationEmployeeId.Location = new System.Drawing.Point(118, 148);
            this.txtDepartmentInformationEmployeeId.Name = "txtDepartmentInformationEmployeeId";
            this.txtDepartmentInformationEmployeeId.Size = new System.Drawing.Size(159, 20);
            this.txtDepartmentInformationEmployeeId.TabIndex = 25;
            // 
            // lblDepartmentInformationEmployeeId
            // 
            this.lblDepartmentInformationEmployeeId.AutoSize = true;
            this.lblDepartmentInformationEmployeeId.Location = new System.Drawing.Point(17, 151);
            this.lblDepartmentInformationEmployeeId.Name = "lblDepartmentInformationEmployeeId";
            this.lblDepartmentInformationEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblDepartmentInformationEmployeeId.TabIndex = 24;
            this.lblDepartmentInformationEmployeeId.Text = "Employee ID";
            // 
            // txtDepartmentInformationDepartmentName
            // 
            this.txtDepartmentInformationDepartmentName.Location = new System.Drawing.Point(118, 111);
            this.txtDepartmentInformationDepartmentName.Name = "txtDepartmentInformationDepartmentName";
            this.txtDepartmentInformationDepartmentName.Size = new System.Drawing.Size(159, 20);
            this.txtDepartmentInformationDepartmentName.TabIndex = 21;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(17, 114);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmentName.TabIndex = 20;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(118, 73);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(159, 20);
            this.txtDepartmentId.TabIndex = 31;
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.Location = new System.Drawing.Point(17, 76);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(76, 13);
            this.lblDepartmentId.TabIndex = 30;
            this.lblDepartmentId.Text = "Department ID";
            // 
            // DepartmentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 305);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.lblDepartmentId);
            this.Controls.Add(this.dataGridViewDepartmentInformation);
            this.Controls.Add(this.btnDepartmentInformationDelete);
            this.Controls.Add(this.btnDepartmentInformationUpdate);
            this.Controls.Add(this.btnDepartmentInformationInsert);
            this.Controls.Add(this.txtDepartmentInformationEmployeeId);
            this.Controls.Add(this.lblDepartmentInformationEmployeeId);
            this.Controls.Add(this.txtDepartmentInformationDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnDepartmentHome);
            this.Name = "DepartmentInformation";
            this.Text = "DepartmentInformation";
            this.Load += new System.EventHandler(this.DepartmentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmentHome;
        private System.Windows.Forms.DataGridView dataGridViewDepartmentInformation;
        private System.Windows.Forms.Button btnDepartmentInformationDelete;
        private System.Windows.Forms.Button btnDepartmentInformationUpdate;
        private System.Windows.Forms.Button btnDepartmentInformationInsert;
        private System.Windows.Forms.TextBox txtDepartmentInformationEmployeeId;
        private System.Windows.Forms.Label lblDepartmentInformationEmployeeId;
        private System.Windows.Forms.TextBox txtDepartmentInformationDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.Label lblDepartmentId;
    }
}