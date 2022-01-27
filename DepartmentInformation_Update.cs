using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeInformationSystem
{
    class DepartmentInformation_Update
    {
        string em = System.Configuration.ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public void UpdateDepartmentInformation(string s)
        {
            using (con = new SqlConnection(em))
            {
                con.Open();
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


    }
}
