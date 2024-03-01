using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepTachesAPI.API.DTOs;
using RepTachesAPI.API.Mappers;
using RepTachesAPI.BLL.Interfaces;
using RepTachesAPI.Domain.Models;
using Tools.CustomExceptions;
using Tools.Errors;

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

        [HttpPost]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(TacheViewModelDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TacheViewModelDTO> Insert([FromBody] TacheFormDTO ticket)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

           
            Tache tacheToAdd = Tache.DTOToDomain();

            if (utilisateur is not null)
            {
                tacheToAdd.Utilisateur = utilisateur;
                TacheViewModelDTO tacheCreated = _tacheService.Create(tacheToAdd).DomainToInfoDTO();

                return CreatedAtAction(nameof(Get), new { id = tacheCreated.IdTache }, tacheCreated);
            }

            return BadRequest();

        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TacheViewModelDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponse))]
        public ActionResult<Tache> Get([FromRoute] int id)
        {

            try
            {
                Tache tache = _tacheService.GetById(IdTache);
                return Ok(tache.DomainToInfoDTO());
            }
            catch (NotFoundException ex)
            {
                return NotFound(new ErrorResponse(StatusCodes.Status404NotFound, ex.Message));
            }

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
