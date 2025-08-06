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
            #region 2
            var filter = products.Where(p => p.UnitsInStock!=0 && p.UnitPrice > 3m);
            foreach (var product in filter) {
                Console.WriteLine(product);
            }
            #endregion
            #region 3
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result = Arr.Select((name, index) => new { Name = name, Index = index })
                .Where(x => x.Name.Length < x.Index)
                .Select(x => x.Index);
            foreach (var n in result) {
                Console.WriteLine(n);
            }
            #endregion
            #endregion
            #region Element Operators
            #region 1
            var firstOutOfStock = (from p in products
                                   where p.UnitsInStock == 0
                                   select p).FirstOrDefault(p => p.UnitsInStock ==0);
            if (firstOutOfStock != null)
                Console.WriteLine(firstOutOfStock);
            else
                Console.WriteLine("No out-of-stock products found.");
            #endregion
            #endregion
        }
    }
}
