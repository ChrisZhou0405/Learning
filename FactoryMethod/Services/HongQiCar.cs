using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services
{
    public class HongQiCar:ICar
    {
        public void Go() {
            Console.WriteLine("红旗汽车开始行驶啦~~~~~");
        }

    }
}
