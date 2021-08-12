using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Database_Final_Exam_Rehearsal
{
    class SQLHelper
    {
        string connectionString;
        SqlConnection connection = new SqlConnection();
        SQLText sqlText = new SQLText();
        SqlCommand command = new SqlCommand();
        //SqlConnection sqlConnection = new SqlConnection(connectionString);
        public SQLHelper()
        {            
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            connectionString = config.ConnectionStrings.ConnectionStrings["Quang"].ConnectionString;
            connection.ConnectionString = connectionString;
            command.Connection = connection;
            Console.WriteLine(config.ConnectionStrings.ConnectionStrings["Quang"].ConnectionString);
            Console.WriteLine(ConfigurationManager.ConnectionStrings["Quang"].ConnectionString);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public void getMusicOrigin(DataSet dataSet)
        {
            connection.Open();
            command.CommandType = System.Data.CommandType.Text; // "select * from ..."
            //command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sqlText.getMusic;

            SqlParameter sqlParameter = new SqlParameter();
            string employee = "1";
            sqlParameter.ParameterName = "@employee";
            sqlParameter.Value = employee;
            command.Parameters.Add(sqlParameter);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            //sqlDataAdapter.InsertCommand
            //sqlDataAdapter.DeleteCommand
            //sqlDataAdapter.UpdateCommand
            sqlDataAdapter.Fill(dataSet);

            Console.WriteLine(dataSet.Tables[0].Rows[0].Field<int>("ID"));
            command.CommandText = "select * from Projects";
            sqlDataAdapter.SelectCommand = command;            
            sqlDataAdapter.Fill(dataSet);
            Console.WriteLine(dataSet.Tables.Count);
            Console.WriteLine(dataSet.Tables[0].Rows[0].Field<string>("Name"));

            connection.Close();
        }
    }
}
