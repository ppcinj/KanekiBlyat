using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>
            {
                new Person("Michael", 1000),
                new Person("Kaneki", 100),
                new Person("Michael Slaivon", 1),
                new Person("Suka", 1000000)
            };
            
            var result = FilterListOf<Person>
                .WithFilterMode.And
                .SetSource(list)
                .UseCriterium(p => p.Name.Contains("Michael"))
                .UseCriterium(p => p.Money < 900)
                .Execute();

            result.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
