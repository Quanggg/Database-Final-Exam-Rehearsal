using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Database_Final_Exam_Rehearsal
{
    class SQLHelper
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Quang"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection();
        //SqlConnection sqlConnection = new SqlConnection(connectionString);
        SQLHelper()
        {
            sqlConnection.ConnectionString = connectionString;
        }
    }
}
