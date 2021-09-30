﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsMvc.Models
{
    interface IData
    {
        public interface IData
        {
            List<Animal> AnimalsList { get; set; }
            List<Animal> AnimalsInitializeData();
            Animal GetAnimalById(int? id);
        }


    }
}
