using System;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)    
            {
                Person person = new Person();
                var personInfo = Console.ReadLine().Split(" ");
                person.Name = personInfo[0];
                person.Age = int.Parse(personInfo[1]);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
