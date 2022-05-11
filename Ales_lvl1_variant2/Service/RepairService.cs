using Ales_lvl1_variant2.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Service
{
    public static class RepairService
    {
        // цена за единицу урона
        private static int   _pricePerDamage = 5;
        // множитель бонусного хила
        private static float _overHealMod = 1.3f;

        /// <summary>
        /// Оценить урон нанаесенный транспорту
        /// </summary>
        /// <returns>стоймость ремонта</returns>
        public static int RateDamage(ICar car) 
        {
            int damage = (int)car.GetHeal().GetDefect();
            return damage * _pricePerDamage;
        }

        /// <summary>
        /// Восстановить повреждения
        /// </summary>
        public static void RepairDamage(ICar car) 
        {
            car.GetHeal().Repair(car.GetHeal().GetMaxHp());
        }

        /// <summary>
        /// Восстановить повреждения и добавить бонусное укрепление
        /// </summary>
        public static void OverRepairDamage(ICar car) 
        {
            car.GetHeal().Repair((int)(car.GetHeal().GetMaxHp() * _overHealMod));
        }
    }
}
