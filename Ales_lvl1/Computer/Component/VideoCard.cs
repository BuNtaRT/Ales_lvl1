using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1.Computers
{
    // Компьютерный компонент описывающий видеокарту
    public class VideoCard : ComputerComponent
    {
        public int    Class   { get; private set; }
        public string AddData { get; private set; }

        public override void SetData(int scalp, int price, int requiredPower, string model = "")
        {
            Class = price / 1000;
            base.SetData(scalp, price, requiredPower , model);
        }

        protected override void ExtentionDataField(object data)
        {
            if(data != null)
                AddData = (string)data;
        }

    }
}
