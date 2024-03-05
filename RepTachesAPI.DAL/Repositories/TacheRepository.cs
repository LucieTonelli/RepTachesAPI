using RepTachesAPI.Domain.Models;
using RepTachesAPI.DAL.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace RepTachesAPI.DAL.Repositories
{
    public class TacheRepository : ITacheRepository
    {
        public string ConnectionString { get; } = "Server=E6K-VDI20415\\TFTIC;Database=DbTicket;Trusted_Connection=True;TrustServerCertificate=True";


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

                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "dbo.SP_CreateTache";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@NomTache", tache.NomTache);
                    sqlCommand.Parameters.AddWithValue("@Recurrence", tache.Recurrence);
                    sqlCommand.Parameters.AddWithValue("@Priorite", tache.Priorite);
                    sqlCommand.Parameters.AddWithValue("@Description", tache.Description);
                    sqlCommand.Parameters.AddWithValue("@TachePartagee", tache.TachePartagee);

                    object result = sqlCommand.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out newId))
                    {
                        tache.IdTache = newId;
                        return tache;
                    }
                    else
                    {
                        // Gérer le cas où la création de la tâche a échoué
                        throw new Exception("Échec lors de la création de la tâche.");
                    }
                }
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
