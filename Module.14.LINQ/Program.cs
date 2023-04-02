using System;
using System.Collections.Generic;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
            var orderedList = new List<string>();
            foreach (string item in people)
            {
                if (item[0] != 'А')
                {
                    orderedList.Add(item);
                }
            }

            orderedList.Sort();

            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
