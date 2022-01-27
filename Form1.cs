using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeInformation Emp = new EmployeeInformation();
            this.Hide();
            Emp.Show();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            BranchInformation br= new BranchInformation();
            this.Hide();
            br.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentInformation dp = new DepartmentInformation();
            this.Hide();
            dp.Show();
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            DesignationInformation de= new DesignationInformation();
            this.Hide();
            de.Show();
        }
    }
}
