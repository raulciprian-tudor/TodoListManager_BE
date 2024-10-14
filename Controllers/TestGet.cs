using Microsoft.AspNetCore.Mvc;

namespace Todo_List_Manager___BE.Controllers
{
    [ApiController]
    [Route("Test")]
    public class TestGet : ControllerBase
    {
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
    }
}