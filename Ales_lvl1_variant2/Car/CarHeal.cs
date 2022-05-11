using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Car
{
    // содержит и работает со здоровьем транспорта
    public class CarHealt
    {
        // максимально здоровье
        private int     _hpBase;
        // текущее хп
        private int     _curHp;
        // базовый класс для callback (конечно это делается событием но для упрощение можно пока и так наверно)
        private CarBase _carBase;

        public CarHealt(int hp, CarBase car) 
        {
            _carBase = car;
            _curHp = hp;
            _hpBase = hp;
        }
        
        public object GetDefect() 
        {
            if (_curHp > _hpBase)
                return 0;

            return _hpBase - _curHp;
        }

        public int GetMaxHp() => _hpBase;
        
        public void Repair(int hp) => _curHp = hp;     // опять же, тут может находиться список деталей которые мы починили/или получаем бонусный overHeal
       
        public void TakeDamage(int damage)
        {
            if (damage > _curHp)
            {
                _curHp = 0;
                _carBase.DestroyCar();
            }
            else
            {
                _curHp -= damage;
            }
        }
    }
}
