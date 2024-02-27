using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepTachesAPI.BLL.Interfaces;
using System.Net.Sockets;

namespace RepTachesAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {
        private readonly ITacheService _tacheService;
        private readonly IUtilisateurService _userService;

        public TacheController(ITacheService tacheService, IUtilisateurService userService)
        {
            _tacheService = tacheService;
            _userService = userService;
        }





    }
}





//public ActionResult<IEnumerable<Ticket>> Get()
//{
//    List<Ticket> tickets = new List<Ticket>();

//    using (SqlConnection connection = new SqlConnection("connectionString"))
//    {
//        string sql = "SELECT * FROM Tickets";
//        SqlCommand command = new SqlCommand(sql, connection);

//        connection.Open();
//        SqlDataReader reader = command.ExecuteReader();

//        while (reader.Read())
//        {
//            Ticket ticket = new Ticket();
//            ticket.Id = (int)reader["Id"];
//            ticket.Name = (string)reader["Name"];
//            // Ajoutez d'autres propriétés de Ticket ici...
//            tickets.Add(ticket);
//        }

//        reader.Close();
//    }

//    return Ok(tickets);
