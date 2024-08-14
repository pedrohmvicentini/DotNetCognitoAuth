using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DotNetCognitoAuthAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        public HttpStatusCode AuthorizeUser()
        {
            return HttpStatusCode.OK;
        }
    }
}
