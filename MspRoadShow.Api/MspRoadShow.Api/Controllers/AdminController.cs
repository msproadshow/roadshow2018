using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MspRoadShow.Api.Models;

namespace MspRoadShow.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Admin")]
    public class WebController : Controller
    {

        [HttpPost]
        [Route("/add-city")]
        public async Task<IActionResult> AddCityRequest([FromBody]CityRequest cityRequest)
        {
            return Ok();
        }
    }
}
