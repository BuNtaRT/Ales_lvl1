using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers.Energy
{
    public static class EnergyWeb
    {
        private static int _limitPower = 500;
        public static int  CurentPower { get; private set; }

        private static List<Computer> _computers = new List<Computer>();

        /// <summary>
        /// Подключение пк к сети
        /// </summary>
        /// <param name="computer"></param>
        /// <returns></returns>
        public static bool ConnectPC(Computer computer) 
        {
            if (computer.GetPCPower() <= _limitPower - CurentPower)
            {
                _computers.Add(computer);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Отключение пк от сети
        /// </summary>
        /// <param name="computer"></param>
        public static void DisconnectPC(Computer computer) 
        {
            CurentPower -= computer.GetPCPower();
            _computers.Remove(computer);
        }

        /// <summary>
        /// Проверка пк на подлючение к сети
        /// </summary>
        public static bool CheckPCConnection(Computer computer) => _computers.Contains(computer);
    }
}
