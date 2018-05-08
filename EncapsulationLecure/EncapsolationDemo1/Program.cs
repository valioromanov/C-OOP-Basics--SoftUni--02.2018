using SortPeople;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EncapsolationDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("My team");
            var lines = int.Parse(Console.ReadLine());

            //Create collection with Person
            //var people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();
                try
                {
                    var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                    team.AddPlayer(person);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }

            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");



            //var percantage = decimal.Parse(Console.ReadLine());

            //Order people by Name then by Age
            //people.OrderBy(p => p.Name)
            //    .ThenBy(p => p.Age)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p)); 


            //Increase Salary
            //people.ForEach(p => p.IncreaseSalary(percantage));

            //Print With New Salary
            //people.ForEach(p => Console.WriteLine(p));


            //Increase Salary and Print
            //people.ForEach(p =>
            //{
            //    p.IncreaseSalary(percantage);
            //    Console.WriteLine(p);
            //});
        }
    }
}
