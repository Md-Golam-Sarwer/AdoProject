using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace EmployeeInformationSystem
{
    public partial class EmployeeInformation : Form
    {
        string em = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        EmployeeInformation_Save eSave = new EmployeeInformation_Save();
        EmployeeInformation_Update eUpdate = new EmployeeInformation_Update();
        
        public EmployeeInformation()
        {
            InitializeComponent();
        }

        private void btnEmployeeHome_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void EmployeeInformation_Load(object sender, EventArgs e)
        {
            EmployeeRecordShow();
        }
        public void EmployeeRecordShow()
        {
            using (con = new SqlConnection(em))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Employee", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmployeeInformation.DataSource = dt;

            }
        }

        private void btnEmployeeInformationInsert_Click(object sender, EventArgs e)
        {
            File.Copy(txtEmployeeImagePath.Text, Path.Combine(@"H:\ProjectEmployeeInformationSystem\Image", Path.GetFileName(txtEmployeeImagePath.Text)), true);
            eSave.SaveEmployeeInformation("INSERT INTO Employee VALUES(' " + txtEmployeeName.Text + " ',' " + txtPhoneNumber.Text + " ',' " + txtBasicSalary.Text + " ',' " + txtHouseRentRate.Text + " ',' " + txtEmployeeImagePath.Text + " ')");
            MessageBox.Show("Record Inserted Successfully!!!");
            EmployeeRecordShow();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*jpg; *jpeg; *gif; *bmp;)|*jpg; *jpeg; *gif; *bmp;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtEmployeeImagePath.Text = openFile.FileName;
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btnEmployeeInformationUpdate_Click(object sender, EventArgs e)
        {
            eUpdate.UpdateEmployeeInformation("UPDATE Employee SET EmployeeName='" + txtEmployeeName.Text + "' WHERE EmployeeId='" + txtEmployeeId.Text + "'  ");
            eUpdate.UpdateEmployeeInformation("UPDATE Employee SET PhoneNumber='" + txtPhoneNumber.Text + "' WHERE EmployeeId='" + txtEmployeeId.Text + "'  ");
            eUpdate.UpdateEmployeeInformation("UPDATE Employee SET BasicSalary='" + txtBasicSalary.Text + "' WHERE EmployeeId='" + txtEmployeeId.Text + "'  ");
            eUpdate.UpdateEmployeeInformation("UPDATE Employee SET HRentRate='" + txtHouseRentRate.Text + "' WHERE EmployeeId='" + txtEmployeeId.Text + "'  ");
            MessageBox.Show("Record Updated Successfully!!!");
            // For Show
            EmployeeRecordShow();
        }

        private void dataGridViewEmployeeInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewEmployeeInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeName.Text = this.dataGridViewEmployeeInformation.CurrentRow.Cells["EmployeeName"].Value.ToString();
            txtEmployeeId.Text = this.dataGridViewEmployeeInformation.CurrentRow.Cells["EmployeeId"].Value.ToString();
            txtPhoneNumber.Text = this.dataGridViewEmployeeInformation.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            txtBasicSalary.Text = this.dataGridViewEmployeeInformation.CurrentRow.Cells["BasicSalary"].Value.ToString();
            txtHouseRentRate.Text = this.dataGridViewEmployeeInformation.CurrentRow.Cells["HRentRate"].Value.ToString();
        }


    }
}
