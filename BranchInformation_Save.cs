using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeInformationSystem
{
    class BranchInformation_Save
    {
        string em = System.Configuration.ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public void SaveBranchInformation(string s)
        {
            using (con = new SqlConnection(em))
            {
                con.Open();
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        internal void SaveBranchInformation()
        {
            throw new NotImplementedException();
        }
    }
}
