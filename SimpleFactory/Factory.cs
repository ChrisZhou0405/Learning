using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleFactory.Interfaces;
using SimpleFactory.Impelments;

namespace SimpleFactory
{
    public class Factory
    {
        public ICar CreateCar(string carType)
        {
            switch (carType.ToLower())
            {
                case "hongqi":
                    return new HongqiCar();
                case "maserati":
                    return new MaseratiCar();
                default:
                    throw new Exception("sorry ,没有你想要的车子");
            }
        }

    }
}