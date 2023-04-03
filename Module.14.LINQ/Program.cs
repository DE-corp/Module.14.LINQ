using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var newList = words.Select(w => new
            {
                Name = w,
                Count = w.Length
            }).OrderByDescending(w => w.Count);

            foreach (var word in newList)
                Console.WriteLine(word.Name + " " + word.Count);
        }
    }
}
