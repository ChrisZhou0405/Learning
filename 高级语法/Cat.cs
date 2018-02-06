using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 高级语法
{
    [Vip][Obsolete]
    class Cat
    {

        public string Name { get; set; }
        [Vip]
        public int Age { get; set; }
        public string Eat()
        {
            return "普通的吃";
        }

        public string EatNice()
        {
            return "优雅的吃";
        }
    }
}
