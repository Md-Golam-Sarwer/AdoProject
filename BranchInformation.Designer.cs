namespace EmployeeInformationSystem
{
    partial class BranchInformation
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
            this.btnBranchHome = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblBranchCity = new System.Windows.Forms.Label();
            this.btnBranchInformationDelete = new System.Windows.Forms.Button();
            this.btnBranchInformationUpdate = new System.Windows.Forms.Button();
            this.btnBranchInformationInsert = new System.Windows.Forms.Button();
            this.dataGridViewBranchInformation = new System.Windows.Forms.DataGridView();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.lblBranchId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranchInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBranchHome
            // 
            this.btnBranchHome.Location = new System.Drawing.Point(13, 13);
            this.btnBranchHome.Name = "btnBranchHome";
            this.btnBranchHome.Size = new System.Drawing.Size(75, 23);
            this.btnBranchHome.TabIndex = 0;
            this.btnBranchHome.Text = "Home";
            this.btnBranchHome.UseVisualStyleBackColor = true;
            this.btnBranchHome.Click += new System.EventHandler(this.btnBranchHome_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(102, 180);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(159, 20);
            this.txtEmployeeID.TabIndex = 12;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(12, 183);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 11;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(102, 145);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(159, 20);
            this.txtDivision.TabIndex = 10;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(12, 148);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 9;
            this.lblDivision.Text = "Division";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(102, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(159, 20);
            this.txtCity.TabIndex = 8;
            // 
            // lblBranchCity
            // 
            this.lblBranchCity.AutoSize = true;
            this.lblBranchCity.Location = new System.Drawing.Point(12, 113);
            this.lblBranchCity.Name = "lblBranchCity";
            this.lblBranchCity.Size = new System.Drawing.Size(24, 13);
            this.lblBranchCity.TabIndex = 7;
            this.lblBranchCity.Text = "City";
            // 
            // btnBranchInformationDelete
            // 
            this.btnBranchInformationDelete.Location = new System.Drawing.Point(480, 225);
            this.btnBranchInformationDelete.Name = "btnBranchInformationDelete";
            this.btnBranchInformationDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBranchInformationDelete.TabIndex = 18;
            this.btnBranchInformationDelete.Text = "Delete";
            this.btnBranchInformationDelete.UseVisualStyleBackColor = true;
            this.btnBranchInformationDelete.Click += new System.EventHandler(this.btnBranchInformationDelete_Click);
            // 
            // btnBranchInformationUpdate
            // 
            this.btnBranchInformationUpdate.Location = new System.Drawing.Point(389, 225);
            this.btnBranchInformationUpdate.Name = "btnBranchInformationUpdate";
            this.btnBranchInformationUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBranchInformationUpdate.TabIndex = 17;
            this.btnBranchInformationUpdate.Text = "Update";
            this.btnBranchInformationUpdate.UseVisualStyleBackColor = true;
            this.btnBranchInformationUpdate.Click += new System.EventHandler(this.btnBranchInformationUpdate_Click);
            // 
            // btnBranchInformationInsert
            // 
            this.btnBranchInformationInsert.Location = new System.Drawing.Point(294, 225);
            this.btnBranchInformationInsert.Name = "btnBranchInformationInsert";
            this.btnBranchInformationInsert.Size = new System.Drawing.Size(75, 23);
            this.btnBranchInformationInsert.TabIndex = 16;
            this.btnBranchInformationInsert.Text = "Insert";
            this.btnBranchInformationInsert.UseVisualStyleBackColor = true;
            this.btnBranchInformationInsert.Click += new System.EventHandler(this.btnBranchInformationInsert_Click);
            // 
            // dataGridViewBranchInformation
            // 
            this.dataGridViewBranchInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranchInformation.Location = new System.Drawing.Point(290, 71);
            this.dataGridViewBranchInformation.Name = "dataGridViewBranchInformation";
            this.dataGridViewBranchInformation.Size = new System.Drawing.Size(278, 136);
            this.dataGridViewBranchInformation.TabIndex = 19;
            this.dataGridViewBranchInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBranchInformation_CellContentClick);
            // 
            // txtBranchId
            // 
            this.txtBranchId.Location = new System.Drawing.Point(102, 71);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(159, 20);
            this.txtBranchId.TabIndex = 21;
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Location = new System.Drawing.Point(12, 74);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(55, 13);
            this.lblBranchId.TabIndex = 20;
            this.lblBranchId.Text = "Branch ID";
            // 
            // BranchInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 311);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.lblBranchId);
            this.Controls.Add(this.dataGridViewBranchInformation);
            this.Controls.Add(this.btnBranchInformationDelete);
            this.Controls.Add(this.btnBranchInformationUpdate);
            this.Controls.Add(this.btnBranchInformationInsert);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblBranchCity);
            this.Controls.Add(this.btnBranchHome);
            this.Name = "BranchInformation";
            this.Text = "BranchInformation";
            this.Load += new System.EventHandler(this.BranchInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranchInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBranchHome;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblBranchCity;
        private System.Windows.Forms.Button btnBranchInformationDelete;
        private System.Windows.Forms.Button btnBranchInformationUpdate;
        private System.Windows.Forms.Button btnBranchInformationInsert;
        private System.Windows.Forms.DataGridView dataGridViewBranchInformation;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label lblBranchId;
    }
}