using Ales_lvl1.Computers;
using Ales_lvl1.Computers.App;
using System;
using System.Collections.Generic;

namespace Ales_lvl1
{
    /*
    В данном вариатне используется реализация с помощью наследования и переопределения методов 
    + очень проста в исполнении
        отлично подойдет для таких маленьких систем, в зависимости от условий (конечно по тз немного не понятно какое приложение должно получиться в общем)
    + можно применять если скажем компьютер в данной задачи простой обьект и не будет развиваться, если будут развиваться только операции с ним то можно будет добавить классы или 
        методы в классы где происходит взавимодействие
    - вытекает из плюсов, если система будет усложняться и скажем это элемент важной и частой игровой механики то лучше поискать другой подход 
        так как такую систему со временем будет очень сложно поддерживать, а она при таких условиях точно будет развиваться
     
    тут не демонстрируется инкапсуляция, зато есть полиморфизм в чистом виде
     
     */
    public class Program
    {
        public static List<Computer> Computers = new List<Computer>();
        static void Main(string[] args)
        {
            Computer comp1 = new Computer();
            var videoCard = new VideoCard();
            videoCard.SetDataByModel("RTX 3050");
            comp1.AddComponent(videoCard);
            var motherBoard = new MotherBoard();
            motherBoard.SetDataByModel("Asus strix b450");
            comp1.AddComponent(motherBoard);

            Computers.Add(comp1);

            //включение
            ComputerPhysicalInteraction.TurnOn(Computers[0]);

            //перезагрука
            ComputerPhysicalInteraction.Restart(Computers[0]);

            //продажа
            if (ComputerPhysicalInteraction.Sell(Computers[0]))
                Computers.RemoveAt(0);

            //Замена
            var motherBoardReplace = new MotherBoard();
            motherBoard.SetDataByModel("Asus strix H350");
            ComputerComponent oldMatherBoard = Computers[0].ReplaceComponent(motherBoardReplace);

            //Сбор металлолома
            int scrap = Computers[0].GetScapCount();
            Computers.RemoveAt(0);

            //Установка приложений
            Computers[0].InitialApp(new Application(500,"Google chome"));
            Computers[0].InitialApp(new Application(2585, "Visual studio"));

            //удаление приложения
            Computers[0].DeleteApp(Computers[0].GetApplications()[0]);
        }
    }
}
