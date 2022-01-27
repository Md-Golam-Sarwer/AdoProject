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
    public partial class BranchInformation : Form
    {
        string em = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;
        BranchInformation_Save bSave = new BranchInformation_Save();
        BranchInformation_Update bUpdate = new BranchInformation_Update();
        BranchInformation_Delete bDelete = new BranchInformation_Delete();
        public BranchInformation()
        {
            InitializeComponent();
        }
        //public void GetEmployeeIdFromDatabase()
        //{
        //    using (con = new SqlConnection(em))
        //    {
        //        con.Open();
        //        cmd = new SqlCommand("SELECT * FROM Employee", con);
        //        adapter = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        adapter.Fill(dt);

        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "Choose Course ID" };
        //        dt.Rows.InsertAt(dr, 0);

        //        cmbBoxEmployeeId.ValueMember = "CourseID";
        //        cmbBoxEmployeeId.DisplayMember = "CourseName";

        //        cmbBoxEmployeeId.DataSource = dt;

        //        con.Close();
        //    }
        //}

        private void btnBranchHome_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void BranchInformation_Load(object sender, EventArgs e)
        {
            BranchRecordShow();
        }
        public void BranchRecordShow()
        {
            using (con = new SqlConnection(em))
            {
                adapter = new SqlDataAdapter("SELECT * FROM Branch", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewBranchInformation.DataSource = dt;

            }
        }

        private void btnBranchInformationInsert_Click(object sender, EventArgs e)
        {
            bSave.SaveBranchInformation("INSERT INTO Branch VALUES(' " + txtDivision.Text + " ',' " + txtEmployeeID.Text + " ',' " + txtCity.Text + " ')");
            MessageBox.Show("Record Saved Successfully!!!");
            BranchRecordShow();
        }

        private void dataGridViewBranchInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ddataGridViewBranchInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCity.Text = this.dataGridViewBranchInformation.CurrentRow.Cells["City"].Value.ToString();
            txtDivision.Text = this.dataGridViewBranchInformation.CurrentRow.Cells["DivisionName"].Value.ToString();
            txtEmployeeID.Text = this.dataGridViewBranchInformation.CurrentRow.Cells["EmployeeId"].Value.ToString();
            txtBranchId.Text = this.dataGridViewBranchInformation.CurrentRow.Cells["BranchId"].Value.ToString();
        }

        private void btnBranchInformationUpdate_Click(object sender, EventArgs e)
        {
            bUpdate.UpdateBranchInformation("UPDATE Branch SET City='" + txtCity.Text + "' WHERE BranchId='" + txtBranchId.Text + "'  ");
            bUpdate.UpdateBranchInformation("UPDATE Branch SET DivisionName='" + txtDivision.Text + "' WHERE BranchId='" + txtBranchId.Text + "'  ");
            bUpdate.UpdateBranchInformation("UPDATE Branch SET EmployeeId='" + txtEmployeeID.Text + "' WHERE BranchId='" + txtBranchId.Text + "'  ");
            MessageBox.Show("Record Updated Successfully!!!");
            // For Show
            BranchRecordShow();
        }

        private void btnBranchInformationDelete_Click(object sender, EventArgs e)
        {
            bDelete.DeleteBranchInformation("Delete Branch WHERE BranchId='" + txtBranchId.Text + "'  ");
            MessageBox.Show("Record Deleted Successfully!!!");
        }
    }
}
