﻿using Ales_lvl1_variant2.SimulateUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Interfaces.Implementation
{
    public class MoveInvert : IMovable
    {
        public void MoveTo(Vector3 direction, float speed)
        {
            // Если мы захотим сделать бонусный уровень или активировать антибонус то тут можно разместить инверсию движения право=лево лево=право
            throw new NotImplementedException();
        }
    }
}
