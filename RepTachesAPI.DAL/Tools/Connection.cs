using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Data.Common;

namespace RepTachesAPI.DAL.Tools
{
    public sealed class Connection
    {
        private string DefaultConnection = "Server=E6K-VDI20415\\TFTIC;Database=DbTicket;Trusted_Connection=True;TrustServerCertificate=True";

        //occurance de connexion
        public SqlConnection sqlCon;
        public SqlCommand sqlCmd;
        protected SqlDataReader sqlDr;
        private SqlParameter sqlPr;
        public SqlDataAdapter sda;
        public DataSet ds;
        public Connection()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection();
                sqlCon.ConnectionString = DefaultConnection;
            }
            ConOpen();
        }
        public void ConOpen()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        public void ConClose()
        {
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }
        public static string typeUser;
        //------------------------------------------------//
        public SqlCommand ObjectCommand(string procName)
        {
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = procName;
            sqlCmd.Connection = sqlCon;
            return sqlCmd;
        }
        //----------------------------------------------//
        public void PassageColletionParameter(SqlCommand sqlCmd, string nomp, SqlDbType typeP, int longP, ParameterDirection dirP, Object valP)
        {
            SqlParameter sqlPr;
            sqlPr = new SqlParameter();
            sqlPr.ParameterName = nomp;
            sqlPr.SqlDbType = typeP;
            sqlPr.Size = longP;
            sqlPr.Value = valP;
            sqlCmd.Parameters.Add(sqlPr);

        }
    }
}
