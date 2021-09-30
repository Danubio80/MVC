using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalMVC2.Models;
namespace AnimalMVC2.Controllers
{
    public class AnimalsController : Controller
    {
        private IData _tempData;
        public AnimalsController(IData tempData)
        {
            _tempData = tempData;
        }



        public IActionResult Index()
        {
            List<Animal> animals = _tempData.AnimalsInitializeData();
            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.Animals = animals;

            return View(indexViewModel);
        }


        public IActionResult Details(int? id)
        {
            var model = _tempData.GetAnimalByID(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        } 
        

    }
}
