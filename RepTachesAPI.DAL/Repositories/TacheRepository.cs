using RepTachesAPI.Domain.Models;
using RepTachesAPI.DAL.Interfaces;
using System.Data;
using System.Data.SqlClient;
using Tools.Errors;

namespace RepTachesAPI.DAL.Repositories
{
    public class TacheRepository : ITacheRepository
    {
        public string ConnectionString { get; } = "Server=E6K-VDI20415\\TFTIC;Database=RepTachesAPI.DB;Trusted_Connection=True;TrustServerCertificate=True";


        public Tache? AddUtilisateurs(int tacheId, List<int> utilisateurIds)
        {
            throw new NotImplementedException();
        }

        public Tache Create(Tache tache)
        {
            int newId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM dbo.Tache WHERE NomTache = @NomTache";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@NomTache", tache.NomTache);
                    int existingCount = (int)checkCommand.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        return null;
                    }
                }
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "[dbo].[SP_CreateTache]";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@NomTache", tache.NomTache);
                    sqlCommand.Parameters.AddWithValue("@Recurrence", tache.Recurrence);
                    sqlCommand.Parameters.AddWithValue("@Priorite", tache.Priorite);
                    sqlCommand.Parameters.AddWithValue("@Description", tache.Description);
                    sqlCommand.Parameters.AddWithValue("@TachePartagee", tache.TachePartagee);
                    //sqlCommand.Parameters.AddWithValue("@Utilisateur", tache.IdUtilisateur);

                    newId = (int)sqlCommand.ExecuteScalar();
                    tache.IdTache = newId;

                }

                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "[dbo].[SP_CalculDateEcheance]";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@DateCreation", DateTime.Now); 
                    sqlCommand.Parameters.AddWithValue("@Priorite", tache.Priorite);
                    sqlCommand.Parameters.AddWithValue("@IdTache", newId);

                    sqlCommand.ExecuteNonQuery();
                }

                return tache;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tache> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tache? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Tache? Update(Tache tache)
        {
            throw new NotImplementedException();
        }

        public Tache? UpdateComplete(Tache tache)
        {
            throw new NotImplementedException();
        }

        public Tache? UpdatePriorite(Tache tache)
        {
            throw new NotImplementedException();
        }
    }
}
