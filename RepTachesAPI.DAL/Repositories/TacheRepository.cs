using Microsoft.Extensions.Configuration;
using RepTachesAPI.DAL.Interfaces;
using RepTachesAPI.DAL.Tools;
using RepTachesAPI.Domain.Models;

namespace RepTachesAPI.DAL.Repositories
{
    public class TacheRepository : ITacheRepository
    {
        private readonly string _connectionString;

        private IConnection _connection;
        public TacheRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");
            _connection = new Connection(_connectionString);
        }

        public Tache? Create(Tache tache)
        {
            Command cmd = new Command("CreateTache", true);
            cmd.AddParameter("NomTache", tache.NomTache);
            cmd.AddParameter("Recurrence", tache.Recurrence);
            cmd.AddParameter("Priorite", tache.Priorite);
            cmd.AddParameter("Description", tache.Description);
            cmd.AddParameter("DateCreation", tache.DateCreation);
            cmd.AddParameter("DateDebut", tache.DateDebut);
            cmd.AddParameter("DateFin", tache.DateFin);
            cmd.AddParameter("DateEcheance", tache.DateEcheance);
            cmd.AddParameter("TachePartagee", tache.TachePartagee);
            cmd.AddParameter("EstComplete", tache.EstComplete);
            // open
            int newId = (int)_connection.ExecuteScalar(cmd);

            tache.IdTache = newId;
            // close
            return tache;

        }
        //{
        //    SqlCommand cmd = ObjectCommand("CreateTache");
        //    ConOpen();
        //    using (var sqlcmd = _connection.ObjectCommand("CreateTache"))
        //    {
        //        sqlcmd.CommandType = CommandType.StoredProcedure;
        //        sqlcmd.Parameters.AddWithValue("@NomTache", tache.NomTache);
        //        sqlcmd.Parameters.AddWithValue("@Description", tache.Description);
        //        sqlcmd.Parameters.AddWithValue("@DateCreation", tache.DateCreation);
        //        sqlcmd.Parameters.AddWithValue("@DateDebut", tache.DateDebut);
        //        sqlcmd.Parameters.AddWithValue("@DateFin", tache.DateFin);
        //        sqlcmd.Parameters.AddWithValue("@DateEcheance", tache.DateEcheance);
        //        sqlcmd.Parameters.AddWithValue("@EstComplete", tache.EstComplete);
        //        sqlcmd.Parameters.AddWithValue("@EstPartagee", tache.TachePartagee);
        //        sqlcmd.Parameters.AddWithValue("@IdAuteur", tache.Utilisateur);

        //        int id = (int)sqlcmd.ExecuteScalar();
        //        tache.IdTache = id;
        //    }

        //    ConClose();
        //}

        public Tache Complete(Tache tache)
        {
            throw new NotImplementedException();
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

        //public Tache Create(Tache tache):
        //{
        //    _connection.ConOpen();
        //    using (var sqlcmd = _connection.ObjectCommand("CreateTache"))
        //    {
        //        sqlcmd.CommandType = CommandType.StoredProcedure;
        //        sqlcmd.Parameters.AddWithValue("@NomTache", tache.NomTache);
        //        sqlcmd.Parameters.AddWithValue("@Description", tache.Description);
        //        sqlcmd.Parameters.AddWithValue("@DateCreation", tache.DateCreation);
        //        sqlcmd.Parameters.AddWithValue("@DateDebut", tache.DateDebut);
        //        sqlcmd.Parameters.AddWithValue("@DateFin", tache.DateFin);
        //        sqlcmd.Parameters.AddWithValue("@DateEcheance", tache.DateEcheance);
        //        sqlcmd.Parameters.AddWithValue("@EstComplete", tache.EstComplete);
        //        sqlcmd.Parameters.AddWithValue("@EstPartagee", tache.TachePartagee);
        //        sqlcmd.Parameters.AddWithValue("@IdAuteur", tache.Utilisateur);

        //        int id = (int)sqlcmd.ExecuteScalar();
        //        tache.IdTache = id;
        //    }
        //    _connection.ConClose();
        //    return tache;
        //}

    }

 
    
}
