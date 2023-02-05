﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayerInterfaces
{
    public interface IAnimalAccessor
    {
        AnimalVM SelectAnimalByAnimalId(int animalId);
        int UpdateAnimal(AnimalVM oldAnimal, AnimalVM newAnimal);
    }
}
