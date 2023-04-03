using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Languages { get; set; }

        }

        public class Application
        {
            public string Name { get; set; }
            public int YearOfBirth { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };


            var selectedStudents = from s in students
                                   where s.Age < 27
                                   // временная переменная для генерации полного имени
                                   let yearOfBirth = DateTime.Now.Year - s.Age
                                   // проекция в новую сущность с использованием новой переменной
                                   select new Application
                                   {
                                       Name = s.Name,
                                       YearOfBirth = yearOfBirth
                                   };

            foreach (var stud in selectedStudents)
                Console.WriteLine(stud.Name + ", " + stud.YearOfBirth);
        }
    }
}
