using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Services.Interfaces;
using FactoryMethod.Services;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory HongQiFac = new HongQiFactory();
            ICar Hongqi = HongQiFac.CreateCar();
            Console.WriteLine("红旗汽车：");
            Hongqi.Go();
            Console.ReadKey();
        }
    }
}
