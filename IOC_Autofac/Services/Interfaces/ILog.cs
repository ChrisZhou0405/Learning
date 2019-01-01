using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Autofac.Services.Interfaces
{
   public interface ILog
    {
        void Save(string message);
    }
}
