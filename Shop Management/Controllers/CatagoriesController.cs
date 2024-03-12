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

        public IActionResult Edit([FromRoute] int? id)
        {
            //var catagory = new Catagory { CatagoryId = id.HasValue?id.Value:0 };
            var catagory = CatagoriesRepository.GetCatagoryById(id.HasValue ? id.Value : 0);

            return View(catagory);
        }

        [HttpPost]
        public IActionResult Edit(Catagory catagory)
        {
            if (ModelState.IsValid)
            {
                CatagoriesRepository.UpdateCatagory(catagory.CatagoryId, catagory);
                return RedirectToAction(nameof(Index));
            }

            return View(catagory);
        }

        [HttpPost]
        public IActionResult Add(Catagory catagory)
        {
            if (ModelState.IsValid)
            {
                CatagoriesRepository.AddCatagory(catagory);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var catagory = CatagoriesRepository.GetCatagoryById(id);
            return View(catagory);
        }
    }
}
