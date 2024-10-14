using Microsoft.AspNetCore.Mvc;

namespace Todo_List_Manager___BE.Controllers
{
    [ApiController]
    [Route("todo")]
    public class TodoAPI : ControllerBase
    {

        [HttpPost]
        [Route("CreateNewTodoItem")]
        public IActionResult CreateNewTodoItem()
        {
            return Ok();
        }
    }
}