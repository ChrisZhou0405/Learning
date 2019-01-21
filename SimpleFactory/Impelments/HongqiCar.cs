using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleFactory.Interfaces;

namespace SimpleFactory.Impelments
{
    public class HongqiCar:ICar
    {
        public string  ShowInfo()
        {
            return "我是红旗汽车 中国大佬的牛掰汽车。。。。";
        }
    }
}