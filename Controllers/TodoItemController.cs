using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Todo_List_Manager___BE.Data;
using Todo_List_Manager___BE.Entities;

namespace Todo_List_Manager___BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly IMongoCollection<TodoItem>? _todoItems;
        public TodoItemController(MongoDbService mongoDbService)
        {
            _todoItems = mongoDbService.Database.GetCollection<TodoItem>("TodoItems");
        }

        [HttpGet]
        public async Task<IEnumerable<TodoItem>> Get()
        {
            return await _todoItems.Find(FilterDefinition<TodoItem>.Empty).ToListAsync();
        }
    }
}
