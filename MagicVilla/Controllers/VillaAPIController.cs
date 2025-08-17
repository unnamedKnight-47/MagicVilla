using MagicVilla.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.Controllers
{
    // Specifies the URL to access this controller
    [Route("/VillaApi")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        // Specifies the HTTP Verb for the following action
        [HttpGet]
        public IEnumerable<VillaModel> GetVillas()
        {
            return new List<VillaModel>
            {
                new VillaModel { Id = 1, Name = "Pool View" },
                new VillaModel { Id = 2, Name = "Beach View" },
            };
        }
    }
}
