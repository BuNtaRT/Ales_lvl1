using Ales_lvl1_variant2.Car;
using Ales_lvl1_variant2.Market;
using Ales_lvl1_variant2.Service;
using Ales_lvl1_variant2.SimulateUtils;
using System;

namespace Ales_lvl1_variant2
{
    /*
     Тут в отличии от первого примера используется патерн стратегия, который позволяет нам переключать передвижение машинки в Runtime при необходимости 
        но основная цель минимизировать повторение кода и ослабить связанность, конечно при разрастании системы этот пример справится по лучше
    + более гибкая настройка отдельных компонентов движения
    + хорошо поставленное строение приложения, для операций таких как работа с хп присутствует отдельный класс(CarHealt) и Repair service, везде класс выполняет свои обязанности и не выходит за них, принцип single responsibility
        вроде проглядывается
    - более долгое написание кода при данном подходе
    - не все классы можно инкапсулировать под интрефейс для стратегии
    - при усложнении всей системы и добавлени новых интерфейсов может наблюдаться ухудшение читаймости
     
    В этом примере в отличии от первого пристутсвует инкапсуляция, и все еще есть полиморфизм, так же как и в прошлом примере наследования и переопределение никуда не ушло.
                                                                                                                                                                    
     */
    public class Program
    {
        private static Catalog _catalog = new Catalog();
        private static ICar    _curCar = null; 
        private static void Main(string[] args)
        {
            // покупка машины
            ShowItem(_catalog.GetAllItems());

            //управление
            _curCar.AddSpeed(2);
            _curCar.Move(new Vector3(10,0,10));

            // повреждение автомобиля
            _curCar.GetHeal().TakeDamage(20);

            //диагностика авто
            int priceForRepair = RepairService.RateDamage(_curCar);
            //ремонт авто
            RepairService.RepairDamage(_curCar);


            Console.WriteLine("Hello World!");
        }

        #region MoveCar
        /*---------------------Управление---------------------*/
        public static void Speed(int speed) 
        {
            speed = -1;
            _curCar.AddSpeed(speed);
        }
        public static void SetDirection(Vector3 direction) 
        {
            _curCar.Move(direction);
        }
        /*----------------------------------------------------*/
        #endregion
        private static void ShowItem(MarketItem[] items) 
        {
            //нам понравился предмет под номером 0
            BuyItem(items[0]);
        }

        private static void BuyItem(MarketItem item) 
        {
            if (Ballance.MinusBallance(item.Price)) 
            {
                _curCar = item.Car;
            }
            //.............
        }
    }

    internal class Ballance
    {
        public static bool MinusBallance(int count) 
        {
            return true;
        }
    }
}
