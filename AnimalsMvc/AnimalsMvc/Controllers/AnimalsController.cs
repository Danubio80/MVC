using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalsMvc.Models;

namespace AnimalsMvc.Controllers
{
    public class AnimalsController : Controller
   
    
    {
        private IData _tempData;

    
        public AnimalsController(IData tempdata)
        {
            _tempData = tempData;
        }

    

        public IActionResult Index()
        {
            return View();
        }
        

        

        public IActionResult Index()
        {
            List<Animal> animals = _tempData.AnimalsIni
        }
    }



   


}
