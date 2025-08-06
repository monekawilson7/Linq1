using ASSLINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1
            List<Product> products= ListGenerators.ProductList;
            var OutOfStock = products.Where(p => p.UnitsInStock==0);
            foreach (var product in OutOfStock) {
                Console.WriteLine(product);
            }
            #endregion
            #endregion
        }
    }
}
