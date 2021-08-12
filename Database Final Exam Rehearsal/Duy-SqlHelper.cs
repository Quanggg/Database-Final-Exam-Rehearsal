
using Database_Final_Exam_Rehearsal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale
{
    public class SQLHelper
    {
        private SqlConnection connection;
        private SQLText sqlText;
        public SQLHelper()
        {
            connection = new SqlConnection
                (System.Configuration.ConfigurationManager.ConnectionStrings["Authentication"].ConnectionString);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connectionString = config.ConnectionStrings.ConnectionStrings["Quang"].ConnectionString;

            sqlText = new SQLText();
        }
        public DataTable QueryToServer(string query)
        {
            if (ConnectToServer())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);

                        return dataTable;
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public DataTable StoredProcedureForResult(string procName, SqlParameter[] paramArr = null)
        {
            if (ConnectToServer())
            {
                using (SqlCommand command = new SqlCommand(procName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    if (paramArr != null)
                    {
                        foreach (var param in paramArr)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);
                        return dataTable;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        // SQLHelper sqlHelper = new SQLHelper();
        // sqlHelper.getEmployeeName(id = 10);
        // sqlHelper.S
        private bool StoredProcedureToPerform(string procName, SqlParameter[] paramArr = null)
        //insert delete update
        {
            if (ConnectToServer())
            {
                using (SqlCommand command = new SqlCommand(procName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    if (paramArr != null)
                    {
                        foreach (var param in paramArr)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private bool ConnectToServer()
        {
            Disconnect();            

            connection.Open();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                Disconnect();
                return false;
            }
            else
                return true;
        }

        private void Disconnect()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }
        public string[] getEmployeeName(int id)
        {
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName= "@id";
            param1.Value = id;
            DataTable dataTable = StoredProcedureForResult(sqlText.getMusic);
            return null;
        }
    }
}
