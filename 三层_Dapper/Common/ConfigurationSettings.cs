﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Common
{
  public  class ConfigurationSettings
    {
        public static string ConnectionString {
            get {
                return ConfigurationManager.ConnectionStrings["Learn"].ConnectionString;
            }
        }
    }
}
