using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers
{
    // Абстрактный класс описывающий идею компонента компьютера
    //      сделан виртуальным, так как мы не должны создавать обьект компонента отдельно 
    //          использование абстракции GetDataByModel() и SetData() немного упрощает расширение полей класса
    //  - такой подход не очень оптимален для расширения, при добавлении новых полей лучше создать струтуру данных или использовать 
    public abstract class ComputerComponent
    {
        public string Model { get; protected set; }
        public int    Scrap { get; protected set; }
        public int    Price { get; protected set; }
        public int    RequiredPower { get; protected set; }


        //*данные берутся откуда то*
        /// <summary>
        /// Оптимальное решение для одиночной реализации
        /// </summary>
        /// <param name="model">Модель видеокарты</param>
        public virtual void SetDataByModel(string model) 
        {
            Model = model;
            Random rand = new Random();
            SetData(rand.Next(2, 11), rand.Next(45000, 180001), 50);
            ExtentionDataField("some load data");
        }

        internal virtual void ExtentionDataField(object data) { }

        // При установки значений можно сделать обработку этих самых значений
        /// <summary>
        /// Оптимальное решение для множественной реализации
        /// </summary>
        /// <param name="scalp">Лом</param>
        /// <param name="price">Цена</param>
        /// <param name="model">Модель</param>
        public virtual void SetData(int scalp, int price, int requiredPower, string model = "") 
        {
            Scrap = scalp;
            Price = price;
            Model = model != "" ? model : Model;
        }
    }
}
