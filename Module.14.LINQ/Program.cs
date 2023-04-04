using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // Сортируем коллекцию сперва по имени, а затем по фамилии
            var sortedPhoneBook = phoneBook.OrderBy(c => c.FirstName).ThenBy(c => c.LastName);
            foreach (var contact in sortedPhoneBook)
                Console.WriteLine(contact.FirstName + " " + contact.LastName + ": " + contact.Phone);

            while (true)
            {
                // Читаем введенный с консоли символ
                Console.Write("\nВведите страницу: ");
                var input = Console.ReadKey().KeyChar;

                // проверяем, число ли это
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

                // если не соответствует критериям - показываем ошибку
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Страницы не существует");
                }
                // если соответствует - запускаем вывод
                else
                {
                    // пропускаем нужное количество элементов и берем 2 для показа на странице
                    var pageContent = sortedPhoneBook.Skip((pageNumber - 1) * 2).Take(2);
                    Console.WriteLine();

                    // выводим результат
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.FirstName + " " + entry.LastName + ": " + entry.Phone);

                    Console.WriteLine();
                }
            }
        }
    }
}
