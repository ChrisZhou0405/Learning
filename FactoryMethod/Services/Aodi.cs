using FactoryMethod.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod.Services
{
   public class Aodi:ICar
    {
        public void Go()
        {
            Console.WriteLine("奥迪车哟！");
        }
    }
}
