using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalMVC2.Models
{
    public interface IData
    {
        List<Animal> AnimalList { get; set; }
        List<Animal> AnimalsInitializeData();
        Animal GetAnimalByID(int? id);
    }
}
