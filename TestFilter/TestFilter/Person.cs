using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFilter
{
    public class Person
    {
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public string Name { get; set; }
        public int Money { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Money})";
        }
    }
}
