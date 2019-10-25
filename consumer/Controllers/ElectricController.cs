using Microsoft.AspNetCore.Mvc;
using Consumer.Domain.Entities;
using Consumer.Repositories;

namespace consumer.Controllers
{

    public class ElectricController : Controller
    {
        private readonly IElectricRepository electric;
    
        public ElectricController(IElectricRepository electricRepository) {
            electric = electricRepository;
        }
        public IActionResult Index()
        {
            ViewElectric viewElectric = new ViewElectric();
            viewElectric.electrics = electric.GetAll();
            viewElectric.maxConsumed = electric.GetMax();
            viewElectric.minConsumed = electric.GetMin();

            return View(viewElectric);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public RedirectToActionResult Create(Electric person)
        {            
            electric.Create(person);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) => View(electric.GetByID(id));

        [HttpPost]
        public RedirectToActionResult Edit(int id, Electric person)
        {            
            electric.Update(person);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) => View(electric.GetByID(id));

        public RedirectToActionResult Delete(int id)
        {            
            electric.Delete(id);
            return RedirectToAction("Index");
        }
    }
}