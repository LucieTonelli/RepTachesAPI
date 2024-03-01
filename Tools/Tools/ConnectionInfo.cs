using RepTachesAPI.DAL.Interfaces;
using RepTachesAPI.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.DAL.Tools
{
    public class ConnectionInfo : IConnectionInfo
    {
        private static readonly string _connectionString = "Server=E6K-VDI20415\\TFTIC;Database=DbTicket;Trusted_Connection=True;TrustServerCertificate=True";

        public string ConnectionString => _connectionString;
    }
}

//dans l'app : 

//public class MyApplication
//{
//    public void Run()
//    {
//        ConnectionInfo connectionInfo = new ConnectionInfo();

//        // Utilisez maintenant la propriété ConnectionString de connectionInfo pour obtenir la chaîne de connexion
//        string actualConnectionString = connectionInfo.ConnectionString;
//    }
//}

