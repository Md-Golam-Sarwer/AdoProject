using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationSystem
{
    public partial class DepartmentInformation : Form
    {
        string em = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;
        DepartmentInformation_Save dSave = new DepartmentInformation_Save();
        DepartmentInformation_Update dUpdate = new DepartmentInformation_Update();
        DepartmentInformation_Delete dDelete = new DepartmentInformation_Delete();
        public DepartmentInformation()
        {
            InitializeComponent();
        }

        private void btnDepartmentHome_Click(object sender, EventArgs e)
        {
            Form1 dp= new Form1();
            this.Hide();
            dp.Show();
        }

        private void dataGridViewDepartmentInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewDepartmentInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepartmentId.Text = this.dataGridViewDepartmentInformation.CurrentRow.Cells["DepartmentID"].Value.ToString();
            txtDepartmentInformationEmployeeId.Text = this.dataGridViewDepartmentInformation.CurrentRow.Cells["EmployeeId"].Value.ToString();
            txtDepartmentInformationDepartmentName.Text = this.dataGridViewDepartmentInformation.CurrentRow.Cells["DepartmentName"].Value.ToString();
            
        }


        private void DepartmentInformation_Load(object sender, EventArgs e)
        {
            DepartmentRecordShow();
        }
        public void DepartmentRecordShow()
        {
            using (con = new SqlConnection(em))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Department", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewDepartmentInformation.DataSource = dt;

            }
        }

        private void btnDepartmentInformationInsert_Click(object sender, EventArgs e)
        {
            dSave.SaveDepartmentInformation("INSERT INTO Department VALUES(' " + txtDepartmentInformationEmployeeId.Text + " ',' " + txtDepartmentInformationDepartmentName.Text + " ')");
            MessageBox.Show("Record Saved Successfully!!!");
            DepartmentRecordShow();
        }

        private void btnDepartmentInformationUpdate_Click(object sender, EventArgs e)
        {
            dUpdate.UpdateDepartmentInformation("UPDATE Department SET DepartmentName='" + txtDepartmentInformationDepartmentName.Text + "' WHERE DepartmentID='" + txtDepartmentId.Text + "'  ");
            dUpdate.UpdateDepartmentInformation("UPDATE Branch SET EmployeeId='" + txtDepartmentInformationEmployeeId.Text + "' WHERE DepartmentID='" + txtDepartmentId.Text + "'  ");
            MessageBox.Show("Record Updated Successfully!!!");
            // For Show
            DepartmentRecordShow();
        }

        private void btnDepartmentInformationDelete_Click(object sender, EventArgs e)
        {
            dDelete.DeleteDepartmentInformation("Delete Department WHERE DepartmentID='" + txtDepartmentId.Text + "'  ");
            MessageBox.Show("Record Deleted Successfully!!!");
        }
    }
}
