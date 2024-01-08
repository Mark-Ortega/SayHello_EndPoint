
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SayHello___EndPoint.Controllers;

[ApiController]
[Route("Name")]
public class SayHelloController : ControllerBase
{
   
    [HttpGet]
    [Route("AddName/{userName}")]
    public string AddName(string userName)
    {
        return $"Hello {userName}";
    }

}
