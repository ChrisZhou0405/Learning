using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services
{
    class HongQiFactory:IFactory
    {
        public ICar CreateCar() {
            return new HongQiCar();
        }
    }
}
