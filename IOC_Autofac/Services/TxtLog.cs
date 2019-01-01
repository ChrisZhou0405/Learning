using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOC_Autofac.Services.Interfaces;

namespace IOC_Autofac.Services
{
    public class TxtLog:ILog
    {
        public void Save(string message) {
            // save txtlog
        }
    }
}