using BroSBurgersApp.Models.Model.Mapper;
using BroSBurgersApp.Models.Model.ViewModel;
using BurgerApp.Models.Model.Domain;
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

            var newBurger = new BurgerPostViewModel
            {
                Burger = burger,
            };
            return View(newBurger);

        }

        [HttpGet]
        public IActionResult CreateBurger()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBurger(BurgerViewModel model)
        {
            var burger = BurgerMapper.CreateBurger(model);
            var resultId = DataBase.CreateBurger(burger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var burger = DataBase.BurgersBase.SingleOrDefault(x => x.Id == id);
            if (burger is null)
            {
                return new EmptyResult();
            }
            return View(burger);
        }
        [HttpPost]
        public IActionResult Edit(int id, Burger model)
        {
            if (model is null)
            {
                return BadRequest();
            }
            var burger = DataBase.BurgersBase.SingleOrDefault(x => x.Id == id);
            if (burger is null)
            {
                return new EmptyResult();
            }
            burger.Id = id;
            DataBase.EditBurger(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var burger = DataBase.BurgersBase.SingleOrDefault(x => x.Id == id);
            if (burger is null)
            {
                return new EmptyResult();
            }
            DataBase.RemoveBurgerModel(burger);
            return RedirectToAction("Index");
        }
    }
}
