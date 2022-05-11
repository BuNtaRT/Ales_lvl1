using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers.App
{
    public class Application
    {
        public Application(int size, string name) 
        {
            Size = size;
            Name = name;
        }
        public int    Size { get; private set; }
        public string Name { get; private set; }
    }
}
