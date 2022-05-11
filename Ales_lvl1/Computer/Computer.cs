using Ales_lvl1.Computers.App;
using Ales_lvl1.Computers.Energy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers
{
    public class Computer
    {
        private List<ComputerComponent> _components   = new List<ComputerComponent>();
        private List<Application>       _applications = new List<Application>();

        /// <summary>
        /// Установка приложения
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public bool InitialApp(Application app) 
        {
            _applications.Add(app);
            return true;
        }
        /// <summary>
        /// Удаление приложения по обьекту
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public bool DeleteApp(Application app) 
        {
            _applications.Remove(app);
            return true;
        }
        /// <summary>
        /// Удаление приложения по индексу
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public bool DeleteApp(int app)
        {
            _applications.RemoveAt(app);
            return true;
        }
        /// <summary>
        /// Получение всех установленных приложений
        /// </summary>
        /// <returns></returns>
        public List<Application> GetApplications() => _applications;

        /// <summary>
        /// Добавить компонент в компьютер
        /// </summary>
        /// <param name="component"></param>
        /// <returns>true = успешное добавление</returns>
        public bool AddComponent(ComputerComponent component) 
        {
            if (!_components.Contains(component))
            {
                _components.Add(component);
                return true;
            }
            else 
            {
                throw new Exception("Component exist");
                //or return false;
            }
        }

        /// <summary>
        /// Удалить компонент из компьютера
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public bool RemoveComponent(ComputerComponent component) 
        {
            if (_components.Contains(component))
            {
                _components.Remove(component);
                return true;
            }
            else
            {
                throw new Exception("Component not exist");
                //or return false;
            }
        }

        /// <summary>
        /// Заменить компонент
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public ComputerComponent ReplaceComponent(ComputerComponent component)
        {
            if (EnergyWeb.CheckPCConnection(this))
            {
                Console.WriteLine("Компьютер подключен к сети");
                return null;
            }

            Type typeComponent = component.GetType();
            ComputerComponent oldComponent = _components.Where(x => x.GetType() == typeComponent).FirstOrDefault();
            if (oldComponent != null) 
            {
                _components.Remove(oldComponent);
                _components.Add(component);
            }

            return oldComponent;
        }


        /// <summary>
        /// Получить колличество лома в компьютере
        /// </summary>
        /// <returns></returns>
        public int GetScapCount() 
        {
            int scrap = 0;
            foreach (var item in _components)
            {
                scrap += item.Scrap;
            }
            return scrap;
        }

        /// <summary>
        /// Получить цену компьютера по общей цене комплектующих
        /// </summary>
        /// <returns></returns>
        public int GetPCPrice()
        {
            int price = 0;
            foreach (var item in _components)
            {
                price += item.Price;
            }
            return price;
        }

        /// <summary>
        /// Получить общую потребляемую мощность
        /// </summary>
        /// <returns></returns>
        public int GetPCPower()
        {
            int power = 0;
            foreach (var item in _components)
            {
                power += item.RequiredPower;
            }
            return power;
        }

        /// <summary>
        /// Проверка на компоненты необходимых для запуска
        /// </summary>
        /// <returns></returns>
        public bool CheckRequiredComponents() 
        {
            if (_components.Count != 0)
                return true;
            else
                return false;
        }

    }
}
