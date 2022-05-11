using Ales_lvl1.Computers.Energy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers
{
    public static class ComputerPhysicalInteraction
    {
        public static bool TurnOn(Computer computer) 
        {
            if (computer.CheckRequiredComponents() && EnergyWeb.ConnectPC(computer))
                return true;
            return false;
        }

        public static void TurnOff(Computer computer) 
        {
            EnergyWeb.DisconnectPC(computer);
        }

        public static bool Restart(Computer computer) 
        {
            TurnOff(computer);
            return TurnOn(computer);
        }

        public static bool Sell(Computer computer) 
        {
            int price = computer.GetPCPrice();
            Console.WriteLine("Компьютер продан за " + price);
            return true;
        }
    }
}
