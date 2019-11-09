using Microsoft.AspNetCore.Mvc;
using Consumer.Domain.Entities;
using Consumer.Repositories;

namespace consumer.Controllers
{

    public class ElectricController : Controller
    {
        private readonly IElectricRepository context;
        private readonly IImmobileRepository contextImmobile;
    
        public ElectricController(IElectricRepository electricRepository, IImmobileRepository immobile) {
            context = electricRepository;
            contextImmobile = immobile;
        }
        public IActionResult Index()
        {
            ViewElectric viewElectric = new ViewElectric();
            viewElectric.electrics = context.GetAll();
            viewElectric.maxConsumed = context.GetMax();
            viewElectric.minConsumed = context.GetMin();

            return View(viewElectric);
        }

        public IActionResult Create() {
            ViewBag.residences = contextImmobile.GetAll();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Electric electric)
        {
            electric.residence = contextImmobile.GetByID(electric.residence.id);
            context.Create(electric);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.residences = contextImmobile.GetAll();
            return View(context.GetByID(id));
        }

        [HttpPost]
        public RedirectToActionResult Edit(int id, Electric electric)
        {      
            electric.residence = contextImmobile.GetByID(electric.residence.id);
            context.Update(electric);
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