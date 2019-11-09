using Microsoft.AspNetCore.Mvc;
using Consumer.Domain.Entities;
using Consumer.Repositories;

namespace consumer.Controllers
{

    public class ImmobileController : Controller
    {
        private readonly IImmobileRepository context;
    
        public ImmobileController(IImmobileRepository immobileRepository) {
            context = immobileRepository;
        }

        public IActionResult Index() => View(context.GetAll());

        public IActionResult Create() => View();

        [HttpPost]
        public RedirectToActionResult Create(Immobile immobile)
        {            
            context.Create(immobile);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) => View(context.GetByID(id));

        [HttpPost]
        public RedirectToActionResult Edit(int id, Immobile immobile)
        {            
            context.Update(immobile);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) => View(context.GetByID(id));

        public RedirectToActionResult Delete(int id)
        {            
            context.Delete(id);
            return RedirectToAction("Index");
        }
    }
}