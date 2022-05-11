using Ales_lvl1_variant2.SimulateUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Interfaces
{
    public interface IMovable
    {
        void MoveTo(Vector3 direction, float speed);
    }
}
