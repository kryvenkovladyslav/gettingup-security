using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GettingUp.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public sealed class EndpointsController : ControllerBase
    {
        [HttpGet]
        [Route("secret")]
        public ActionResult<string> Secret()
        {
            return this.Ok("Secret Endpoint");
        }
    }
}