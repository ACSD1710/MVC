using BroSBurgersApp.Models.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var burgers = DataBase.BurgersBase.ToList();
            var model = new BurgerIndexViewModel
            {
                Burgers = burgers
            };
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var burger = DataBase.BurgersBase.SingleOrDefault(x => x.Id == id);
            if (burger is null)
            {
                return NotFound();
            }
            return View(burger);

        }
        public IActionResult CreateOrder()
        {
            return View();
        }
    }
}
