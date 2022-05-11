using Ales_lvl1_variant2.Interfaces;
using Ales_lvl1_variant2.SimulateUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Car
{
    public class CarBase : ICar
    {
        //интерфейс перемещения
        protected IMovable _movable;
        protected float    _curentSpeed;
        protected float    _boostSpeedModificator;
        protected CarHealt _healt;

        // создаем класс здоровья для машины и задаем первоночальное значение
        protected void CreateHealt(int hp) 
        {
            _healt = new CarHealt(hp, this);
        }

        public virtual void AddSpeed(float speed)
        {
            _curentSpeed = speed * _boostSpeedModificator;
        }

        // направление нашего движения
        public virtual void Move(Vector3 direction)
        {
            _movable.MoveTo(direction, _curentSpeed);
        }

        public CarHealt GetHeal() => _healt;

        public virtual void DestroyCar()
        {
            throw new NotImplementedException();
        }
    }
}
