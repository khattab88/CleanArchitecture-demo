using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture_Demo.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {

    }
}
