using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Services.Interfaces
{
    public interface IFactory
    {
         ICar CreateCar();
    }
}
