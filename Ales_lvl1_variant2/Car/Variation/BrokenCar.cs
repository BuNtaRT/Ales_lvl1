﻿using Ales_lvl1_variant2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Car.Variation
{
    public class BrokenCar : CarBase
    {
        public BrokenCar(IMovable movable, float speedModificator, int hp = 100)
        {
            CreateHealt(hp);
            _boostSpeedModificator = speedModificator;
            _movable = movable;
        }
    }
}
