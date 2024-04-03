using Microsoft.AspNetCore.Mvc;

namespace DemoStoreEFCoreSidekick.WebIU.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;

        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult CategoryList()
        {
            var values = _dataContext.Categories.ToList();
            return View(values);
        }
    }
}
