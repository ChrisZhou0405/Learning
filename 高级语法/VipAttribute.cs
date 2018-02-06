using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 高级语法
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Method,AllowMultiple =true,Inherited =false)]
  public  class VipAttribute:Attribute
    {
    }
}
