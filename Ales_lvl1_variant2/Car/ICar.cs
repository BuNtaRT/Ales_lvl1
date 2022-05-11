using Ales_lvl1_variant2.SimulateUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Car
{
    public interface ICar
    {
        CarHealt GetHeal();

        //предположим что мы можем получать список частей авто которые подлежат замене
        //сейчас для упрощения получаем hp автомобиля
        void   Move(Vector3 direction);
        void   AddSpeed(float speed);
    }
}
