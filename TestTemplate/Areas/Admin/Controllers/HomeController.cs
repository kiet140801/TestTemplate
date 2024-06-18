using Microsoft.AspNetCore.Mvc;
using TestTemplate.Areas.Admin.Models;
using TestTemplate.Models.Entities;

namespace TestTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class HomeController : Controller
    {
        // DI
        private readonly ToDoTaskDbContext _dbContext;
        public HomeController(ToDoTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDto product)
        {
            _dbContext.ToDoTasks.Add(new ToDoTask
            {
                Name = product.Name
            });

            return Ok();
        }
    }
}
