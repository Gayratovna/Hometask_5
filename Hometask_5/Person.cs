using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_5
{
    public class Person: IPerson
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void GetData()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Age: {Age}");
        }
        public void ComparisonAge(int age)
        {
            Console.WriteLine($"{Name}ning yoshi {Age}da");
        }
        public bool IsHavePassport()
        {
            return true;
        }

    }
}
