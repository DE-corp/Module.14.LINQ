using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
               new[] {2, 3, 7, 1},
               new[] {45, 17, 88, 0},
               new[] {23, 32, 44, -6},
            };

            var newList = numsList.SelectMany(s => s).OrderBy(s => s);

            foreach (var num in newList)
                Console.WriteLine(num);
        }
    }
}
