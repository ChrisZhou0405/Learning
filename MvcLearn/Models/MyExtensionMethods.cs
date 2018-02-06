using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLearn.Models
{
    public static class MyExtensionMethods
    {
        public static decimal GetTotalPrice(this ShoppingCart cart)
        {
            decimal total = 0;
            foreach (Product item in cart.Products)
            {
                total += item.Price;
            }
            return total;
        }

        public static int ToInt(this string str,DateTime date)
        {
            int res;
            int.TryParse(str,out res);
            return res;
        }

    }
}