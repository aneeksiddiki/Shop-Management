using Microsoft.AspNetCore.Mvc;
using Shop_Management.Models;

namespace Shop_Management.Controllers
{
    public class CatagoriesController : Controller
    {
        public IActionResult Index()
        {
            var catagories = CatagoriesRepository.GetCatagories();
            return View(catagories);
        }

        public IActionResult Edit(int? id) 
        {
            var catagory = new Catagory { CatagoryId = id.HasValue?id.Value:0 };
            
            return View(catagory);
        }
    }
}
