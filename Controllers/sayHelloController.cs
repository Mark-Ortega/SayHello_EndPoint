
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SayHello___EndPoint.Controllers;

[ApiController]
[Route("Name")]
public class SayHelloController : ControllerBase
{
   

public List<string> nameList = new();

    [HttpGet]
    [Route("AddName/{userName}")]
    public List<string> AddName(string userName)
    {
        nameList.Add("Hello " + userName);
        return nameList;
    }

}
