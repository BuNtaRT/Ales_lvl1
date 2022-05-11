using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers
{
    public class MotherBoard : ComputerComponent
    {
        public int    PCExSlots { get; private set; }
        public string Color     { get; private set; }

        protected override void ExtentionDataField(object data)
        {
            if (data != null) 
            {
                // тут должен быть тип данных с бд или структа данных из Json например, что бы получать поля и ставить их вариативно
                PCExSlots = ((MotherBoard)data).PCExSlots;
                Color     = ((MotherBoard)data).Color;
            }
        }
    }
}
