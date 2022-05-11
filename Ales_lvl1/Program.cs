using Ales_lvl1.Computers;
using Ales_lvl1.Computers.App;
using System;
using System.Collections.Generic;

namespace Ales_lvl1
{
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
