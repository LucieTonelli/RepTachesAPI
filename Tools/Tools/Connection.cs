using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using RepTachesAPI.DAL.Interfaces;
using System.Data;
using System.Data.Common;

namespace RepTachesAPI.DAL.Tools
{
    public class Connection : IConnection
    {
     
        private readonly string ConnectionString;

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public int ExecuteNonQuery(Command command)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command.Query, connection))
                {
                    sqlCommand.CommandType = command.IsStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    foreach (var parameter in command.Parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value.Value ?? DBNull.Value).Direction = parameter.Value.Direction;
                    }
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataRecord, TResult> selector)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command.Query, connection))
                {
                    sqlCommand.CommandType = command.IsStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    foreach (var parameter in command.Parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value.Value ?? DBNull.Value).Direction = parameter.Value.Direction;
                    }
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return selector(reader);
                        }
                    }
                }
            }
        }

        public object ExecuteScalar(Command command)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command.Query, connection))
                {
                    sqlCommand.CommandType = command.IsStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    foreach (var parameter in command.Parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value.Value ?? DBNull.Value).Direction = parameter.Value.Direction;
                    }
                    return sqlCommand.ExecuteScalar();
                }
            }
        }

        public DataSet GetDataSet(Command command)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command.Query, connection))
                {
                    sqlCommand.CommandType = command.IsStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    foreach (var parameter in command.Parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value.Value ?? DBNull.Value).Direction = parameter.Value.Direction;
                    }
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
        }

        public DataTable GetDataTable(Command command)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command.Query, connection))
                {
                    sqlCommand.CommandType = command.IsStoredProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    foreach (var parameter in command.Parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value.Value ?? DBNull.Value).Direction = parameter.Value.Direction;
                    }
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}




//public class Connection
//{
//    private string DefaultConnection = "Server=E6K-VDI20415\\TFTIC;Database=DbTicket;Trusted_Connection=True;TrustServerCertificate=True";

//    //occurance de connexion
//    public SqlConnection sqlCon;
//    public SqlCommand sqlCmd;
//    protected SqlDataReader sqlDr;
//    private SqlParameter sqlPr;
//    public SqlDataAdapter sda;
//    public DataSet ds;
//    public Connection()
//    {
//        if (sqlCon == null)
//        {
//            sqlCon = new SqlConnection();
//            sqlCon.ConnectionString = DefaultConnection;
//        }
//        ConOpen();
//    }
//    public void ConOpen()
//    {
//        if (sqlCon.State == ConnectionState.Closed)
//            sqlCon.Open();
//    }
//    public void ConClose()
//    {
//        if (sqlCon.State == ConnectionState.Open)
//            sqlCon.Close();
//    }
//    public static string typeUser;
//    //------------------------------------------------//
//    public SqlCommand ObjectCommand(string procName)
//    {
//        sqlCmd = new SqlCommand();
//        sqlCmd.CommandType = CommandType.StoredProcedure;
//        sqlCmd.CommandText = procName;
//        sqlCmd.Connection = sqlCon;
//        return sqlCmd;
//    }
//    //----------------------------------------------//
//    public void PassageColletionParameter(SqlCommand sqlCmd, string nomp, SqlDbType typeP, int longP, ParameterDirection dirP, Object valP)
//    {
//        SqlParameter sqlPr;
//        sqlPr = new SqlParameter();
//        sqlPr.ParameterName = nomp;
//        sqlPr.SqlDbType = typeP;
//        sqlPr.Size = longP;
//        sqlPr.Value = valP;
//        sqlCmd.Parameters.Add(sqlPr);

//    }