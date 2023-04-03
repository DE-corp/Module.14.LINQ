using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        class Contact
        {
            public string Name { get; set; }
            public long Phone { get; set; }
        }

        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            while (true)
            {
                IEnumerable<Contact> page = null;

                Console.Write("Введи страницу: ");
                var isInt = int.TryParse(Console.ReadLine(), out int pageCount);
                Console.Clear();

                if (isInt)
                {
                    switch (pageCount)
                    {
                        case (1):
                            page = contacts.Take(2);
                            break;
                        case (2):
                            page = contacts.Skip(2).Take(2);
                            break;
                        case (3):
                            page = contacts.Skip(4).Take(2);
                            break;
                    }

                    if (page != null)
                    {
                        foreach (var item in page)
                            Console.WriteLine(item.Name + " " + item.Phone);
                    }
                }
                else
                    Console.WriteLine("Введи число!");

            }
        }
    }
}
