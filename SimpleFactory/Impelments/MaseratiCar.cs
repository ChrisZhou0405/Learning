using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleFactory.Interfaces;

namespace SimpleFactory.Impelments
{
    public class MaseratiCar : ICar
    {
        public string ShowInfo()
        {
            return " 我是玛莎拉蒂汽车，来自意大利";
        }
    }
}