using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
               1,
               "Сергей ",
               "Андрей ",
               300,
            };

            var names = objects.Where(n => n is string).OrderBy(n => n);

            foreach (string name in names)
                System.Console.WriteLine(name);
        }
    }
}
