using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1semester.Model
{
    class DB
    {
        public static List<Employee> GetAllEmployees(List<Employee> empList)
        {
            //define the connection string of azure database.
            //string cnString = "Server=tcp:saasgamify-server.database.windows.net,1433;Initial Catalog=saasgamify-db;Persist Security Info=False;User ID=saasgamifylogin;Password=saasgamify12345.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            string cmdText = @"SELECT * FROM Employess";

            SqlCommand oCmd = new SqlCommand(cmdText, myConnection);

            myConnection.Open();

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    empList.Add(new Employee() { Fname = oReader["Fname"].ToString(), Lname = oReader["Lname"].ToString() });
                }
                myConnection.Close();
            }
            return empList;
        }
    }
}
