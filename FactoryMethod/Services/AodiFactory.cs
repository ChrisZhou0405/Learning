using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Services.Interfaces;
namespace FactoryMethod.Services
{
    public class AodiFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new Aodi();
        }
    }
}
