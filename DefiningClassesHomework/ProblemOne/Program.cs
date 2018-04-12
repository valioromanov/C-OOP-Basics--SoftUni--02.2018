using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                Person person = new Person();
                var info = Console.ReadLine().Split(' ');
                person.Name = info[0];
                person.Age = int.Parse(info[1]);
                if (person.Age > 30)
                {
                    people.Add(person);
                }
            }
            foreach (var person in people.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            
        }
    }
}
