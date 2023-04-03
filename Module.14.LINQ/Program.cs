using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var cities = russianCities.Where(c => c.Name.Length <= 10).OrderByDescending(c => c.Name.Length);

            foreach (var city in cities)
                System.Console.WriteLine(city.Name + " - " + city.Population);
        }

    }

    public class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public long Population { get; set; }
    }
}
