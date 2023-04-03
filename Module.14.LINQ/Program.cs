using System;
using System.Collections.Generic;
using System.Linq;

namespace Module._14.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            var comp = from c in companies
                       from t in c.Value
                       where t.Contains("Mobile")
                       orderby c.Key descending
                       select c.Key;

            foreach (var c in comp)
                Console.WriteLine(c);
        }
    }
}
