using Microsoft.AspNetCore.Mvc;
using StockApp.Core.Application.Interfaces.Services;

namespace Presentation.StockApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices) 
        {
            _categoryServices = categoryServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryServices.getAllservice());
        }
    }
}
