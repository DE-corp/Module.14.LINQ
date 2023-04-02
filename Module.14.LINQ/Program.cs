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

            var names = from p in objects // промежуточная переменная p 
                        where p.GetType() == typeof(string) // фильтрация по условию
                        orderby p // сортировка по возрастанию (дефолтная)
                        select p; // выбираем объект и сохраняем в выборку

            foreach (string name in names)
                System.Console.WriteLine(name);
        }
    }
}
