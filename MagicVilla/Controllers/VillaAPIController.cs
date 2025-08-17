using MagicVilla.DataStore;
using MagicVilla.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.Controllers
{
    // Specifies the URL to access this controller
    [Route("/[controller]")]
    // When we use [Route("/[controller]")] then the route will
    // take the name from the VillaAPIController class and exclude the Controller part
    // So ultimately it will look like [Route("/[VillaAPI]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        // Specifies the HTTP Verb for the following action
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
    }
}
