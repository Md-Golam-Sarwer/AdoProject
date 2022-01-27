namespace EmployeeInformationSystem
{
    partial class EmployeeInformation
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
            this.btnEmployeeHome = new System.Windows.Forms.Button();
            this.lblEmName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtHouseRentRate = new System.Windows.Forms.TextBox();
            this.lblHouseRentRate = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmployeeImagePath = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployeeInformation = new System.Windows.Forms.DataGridView();
            this.btnEmployeeInformationInsert = new System.Windows.Forms.Button();
            this.btnEmployeeInformationUpdate = new System.Windows.Forms.Button();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeHome
            // 
            this.btnEmployeeHome.Location = new System.Drawing.Point(13, 13);
            this.btnEmployeeHome.Name = "btnEmployeeHome";
            this.btnEmployeeHome.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeHome.TabIndex = 0;
            this.btnEmployeeHome.Text = "Home";
            this.btnEmployeeHome.UseVisualStyleBackColor = true;
            this.btnEmployeeHome.Click += new System.EventHandler(this.btnEmployeeHome_Click);
            // 
            // lblEmName
            // 
            this.lblEmName.AutoSize = true;
            this.lblEmName.Location = new System.Drawing.Point(12, 103);
            this.lblEmName.Name = "lblEmName";
            this.lblEmName.Size = new System.Drawing.Size(84, 13);
            this.lblEmName.TabIndex = 1;
            this.lblEmName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(102, 100);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(159, 20);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(102, 135);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(159, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 138);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtHouseRentRate
            // 
            this.txtHouseRentRate.Location = new System.Drawing.Point(102, 205);
            this.txtHouseRentRate.Name = "txtHouseRentRate";
            this.txtHouseRentRate.Size = new System.Drawing.Size(159, 20);
            this.txtHouseRentRate.TabIndex = 8;
            // 
            // lblHouseRentRate
            // 
            this.lblHouseRentRate.AutoSize = true;
            this.lblHouseRentRate.Location = new System.Drawing.Point(12, 208);
            this.lblHouseRentRate.Name = "lblHouseRentRate";
            this.lblHouseRentRate.Size = new System.Drawing.Size(90, 13);
            this.lblHouseRentRate.TabIndex = 7;
            this.lblHouseRentRate.Text = "House Rent Rate";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(102, 170);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(159, 20);
            this.txtBasicSalary.TabIndex = 6;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(12, 173);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(65, 13);
            this.lblBasicSalary.TabIndex = 5;
            this.lblBasicSalary.Text = "Basic Salary";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(6, 293);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(96, 23);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Browse Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 89);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmployeeImagePath
            // 
            this.txtEmployeeImagePath.Location = new System.Drawing.Point(124, 360);
            this.txtEmployeeImagePath.Name = "txtEmployeeImagePath";
            this.txtEmployeeImagePath.Size = new System.Drawing.Size(636, 20);
            this.txtEmployeeImagePath.TabIndex = 11;
            // 
            // dataGridViewEmployeeInformation
            // 
            this.dataGridViewEmployeeInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeInformation.Location = new System.Drawing.Point(310, 62);
            this.dataGridViewEmployeeInformation.Name = "dataGridViewEmployeeInformation";
            this.dataGridViewEmployeeInformation.Size = new System.Drawing.Size(450, 252);
            this.dataGridViewEmployeeInformation.TabIndex = 12;
            this.dataGridViewEmployeeInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeInformation_CellContentClick);
            // 
            // btnEmployeeInformationInsert
            // 
            this.btnEmployeeInformationInsert.Location = new System.Drawing.Point(124, 395);
            this.btnEmployeeInformationInsert.Name = "btnEmployeeInformationInsert";
            this.btnEmployeeInformationInsert.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeInformationInsert.TabIndex = 13;
            this.btnEmployeeInformationInsert.Text = "Insert";
            this.btnEmployeeInformationInsert.UseVisualStyleBackColor = true;
            this.btnEmployeeInformationInsert.Click += new System.EventHandler(this.btnEmployeeInformationInsert_Click);
            // 
            // btnEmployeeInformationUpdate
            // 
            this.btnEmployeeInformationUpdate.Location = new System.Drawing.Point(219, 395);
            this.btnEmployeeInformationUpdate.Name = "btnEmployeeInformationUpdate";
            this.btnEmployeeInformationUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeInformationUpdate.TabIndex = 14;
            this.btnEmployeeInformationUpdate.Text = "Update";
            this.btnEmployeeInformationUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeInformationUpdate.Click += new System.EventHandler(this.btnEmployeeInformationUpdate_Click);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(102, 74);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(159, 20);
            this.txtEmployeeId.TabIndex = 17;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(12, 77);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 16;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 466);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.btnEmployeeInformationUpdate);
            this.Controls.Add(this.btnEmployeeInformationInsert);
            this.Controls.Add(this.dataGridViewEmployeeInformation);
            this.Controls.Add(this.txtEmployeeImagePath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.txtHouseRentRate);
            this.Controls.Add(this.lblHouseRentRate);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmName);
            this.Controls.Add(this.btnEmployeeHome);
            this.Name = "EmployeeInformation";
            this.Text = "EmployeeInformation";
            this.Load += new System.EventHandler(this.EmployeeInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeHome;
        private System.Windows.Forms.Label lblEmName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtHouseRentRate;
        private System.Windows.Forms.Label lblHouseRentRate;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmployeeImagePath;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeInformation;
        private System.Windows.Forms.Button btnEmployeeInformationInsert;
        private System.Windows.Forms.Button btnEmployeeInformationUpdate;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
    }
}