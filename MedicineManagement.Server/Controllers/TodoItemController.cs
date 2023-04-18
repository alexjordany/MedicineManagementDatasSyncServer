using Microsoft.AspNetCore.Datasync;
using Microsoft.AspNetCore.Datasync.EFCore;
using Microsoft.AspNetCore.Mvc;
using MedicineManagement.Server.Db;

namespace MedicineManagement.Server.Controllers
{
    [Route("tables/todoitem")]
    public class TodoItemController : TableController<TodoItem>
    {
        public TodoItemController(AppDbContext context)
            : base(new EntityTableRepository<TodoItem>(context))
        {
        }
    }
}
