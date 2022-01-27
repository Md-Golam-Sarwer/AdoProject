namespace EmployeeInformationSystem
{
    partial class DesignationInformation
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
            this.btnDesignationHome = new System.Windows.Forms.Button();
            this.dataGridViewDesignationInformation = new System.Windows.Forms.DataGridView();
            this.btnDesignationInformationDelete = new System.Windows.Forms.Button();
            this.btnDesignationInformationUpdate = new System.Windows.Forms.Button();
            this.btnDesignationInformationInsert = new System.Windows.Forms.Button();
            this.txtDesignatioInformationEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtDesignatioInformationDesinationName = new System.Windows.Forms.TextBox();
            this.lblDesignationName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesignationInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesignationHome
            // 
            this.btnDesignationHome.Location = new System.Drawing.Point(13, 13);
            this.btnDesignationHome.Name = "btnDesignationHome";
            this.btnDesignationHome.Size = new System.Drawing.Size(75, 23);
            this.btnDesignationHome.TabIndex = 0;
            this.btnDesignationHome.Text = "Home";
            this.btnDesignationHome.UseVisualStyleBackColor = true;
            this.btnDesignationHome.Click += new System.EventHandler(this.btnDesignationHome_Click);
            // 
            // dataGridViewDesignationInformation
            // 
            this.dataGridViewDesignationInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesignationInformation.Location = new System.Drawing.Point(294, 71);
            this.dataGridViewDesignationInformation.Name = "dataGridViewDesignationInformation";
            this.dataGridViewDesignationInformation.Size = new System.Drawing.Size(278, 136);
            this.dataGridViewDesignationInformation.TabIndex = 37;
            // 
            // btnDesignationInformationDelete
            // 
            this.btnDesignationInformationDelete.Location = new System.Drawing.Point(484, 225);
            this.btnDesignationInformationDelete.Name = "btnDesignationInformationDelete";
            this.btnDesignationInformationDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDesignationInformationDelete.TabIndex = 36;
            this.btnDesignationInformationDelete.Text = "Delete";
            this.btnDesignationInformationDelete.UseVisualStyleBackColor = true;
            // 
            // btnDesignationInformationUpdate
            // 
            this.btnDesignationInformationUpdate.Location = new System.Drawing.Point(393, 225);
            this.btnDesignationInformationUpdate.Name = "btnDesignationInformationUpdate";
            this.btnDesignationInformationUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDesignationInformationUpdate.TabIndex = 35;
            this.btnDesignationInformationUpdate.Text = "Update";
            this.btnDesignationInformationUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDesignationInformationInsert
            // 
            this.btnDesignationInformationInsert.Location = new System.Drawing.Point(298, 225);
            this.btnDesignationInformationInsert.Name = "btnDesignationInformationInsert";
            this.btnDesignationInformationInsert.Size = new System.Drawing.Size(75, 23);
            this.btnDesignationInformationInsert.TabIndex = 34;
            this.btnDesignationInformationInsert.Text = "Insert";
            this.btnDesignationInformationInsert.UseVisualStyleBackColor = true;
            // 
            // txtDesignatioInformationEmployeeId
            // 
            this.txtDesignatioInformationEmployeeId.Location = new System.Drawing.Point(102, 132);
            this.txtDesignatioInformationEmployeeId.Name = "txtDesignatioInformationEmployeeId";
            this.txtDesignatioInformationEmployeeId.Size = new System.Drawing.Size(159, 20);
            this.txtDesignatioInformationEmployeeId.TabIndex = 33;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(12, 135);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 32;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // txtDesignatioInformationDesinationName
            // 
            this.txtDesignatioInformationDesinationName.Location = new System.Drawing.Point(102, 95);
            this.txtDesignatioInformationDesinationName.Name = "txtDesignatioInformationDesinationName";
            this.txtDesignatioInformationDesinationName.Size = new System.Drawing.Size(159, 20);
            this.txtDesignatioInformationDesinationName.TabIndex = 31;
            // 
            // lblDesignationName
            // 
            this.lblDesignationName.AutoSize = true;
            this.lblDesignationName.Location = new System.Drawing.Point(12, 98);
            this.lblDesignationName.Name = "lblDesignationName";
            this.lblDesignationName.Size = new System.Drawing.Size(94, 13);
            this.lblDesignationName.TabIndex = 30;
            this.lblDesignationName.Text = "Designation Name";
            // 
            // DesignationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 291);
            this.Controls.Add(this.dataGridViewDesignationInformation);
            this.Controls.Add(this.btnDesignationInformationDelete);
            this.Controls.Add(this.btnDesignationInformationUpdate);
            this.Controls.Add(this.btnDesignationInformationInsert);
            this.Controls.Add(this.txtDesignatioInformationEmployeeId);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtDesignatioInformationDesinationName);
            this.Controls.Add(this.lblDesignationName);
            this.Controls.Add(this.btnDesignationHome);
            this.Name = "DesignationInformation";
            this.Text = "DesignationInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesignationInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesignationHome;
        private System.Windows.Forms.DataGridView dataGridViewDesignationInformation;
        private System.Windows.Forms.Button btnDesignationInformationDelete;
        private System.Windows.Forms.Button btnDesignationInformationUpdate;
        private System.Windows.Forms.Button btnDesignationInformationInsert;
        private System.Windows.Forms.TextBox txtDesignatioInformationEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtDesignatioInformationDesinationName;
        private System.Windows.Forms.Label lblDesignationName;
    }
}