namespace EmployeeInformationSystem
{
    partial class Form1
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.btnDesignation = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(61, 117);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(95, 23);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.Location = new System.Drawing.Point(61, 170);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(95, 23);
            this.btnBranch.TabIndex = 1;
            this.btnBranch.Text = "Branch";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // btnDesignation
            // 
            this.btnDesignation.Location = new System.Drawing.Point(61, 265);
            this.btnDesignation.Name = "btnDesignation";
            this.btnDesignation.Size = new System.Drawing.Size(95, 23);
            this.btnDesignation.TabIndex = 3;
            this.btnDesignation.Text = "Designation";
            this.btnDesignation.UseVisualStyleBackColor = true;
            this.btnDesignation.Click += new System.EventHandler(this.btnDesignation_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(61, 212);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(95, 23);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesignation);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnBranch);
            this.Controls.Add(this.btnEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnDesignation;
        private System.Windows.Forms.Button btnDepartment;
    }
}

