using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepTachesAPI.BLL.Interfaces;

namespace RepTachesAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurService _userService;

        public UtilisateurController()
        {
        }
    }
}
