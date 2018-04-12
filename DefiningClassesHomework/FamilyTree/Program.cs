using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var familyTree = new List<Person>();
        string personInput = Console.ReadLine();
        Person mainPerson = new Person();

        if (isBirthday(personInput))
        {
            mainPerson.BirthDate = personInput;
        }
        else
        {
            mainPerson.Name = personInput;
        }

        string command;
        while ((command = Console.ReadLine())!= "End")
        {
            string[] tokens = command.Split("-");
            if (tokens.Length > 1)
            {
                string firstPerson = tokens[0];
                string secondPerson = tokens[1];

                Person currentPerson;
                if (isBirthday(firstPerson))
                {
                    currentPerson = familyTree.FirstOrDefault(p => p.BirthDate == firstPerson);
                    if (currentPerson == null)
                    {
                        var newPerson = new Person();
                        newPerson.BirthDate = firstPerson;
                        familyTree.Add(currentPerson);
                    }
                   
                }
                else
                {
                    currentPerson = familyTree.FirstOrDefault(p => p.Name == firstPerson);
                    if (currentPerson == null)
                    {
                        var newPerson = new Person();
                        newPerson.Name = firstPerson;
                        familyTree.Add(currentPerson);
                    }
                    SetChild(familyTree, currentPerson, secondPerson);
                }
            }
            else
            {
                tokens = tokens[0].Split();
                string name = $"{tokens[0]} {tokens[1]}";
                string birthday = tokens[2];

                var person = familyTree.FirstOrDefault(p => p.Name == name || p.BirthDate == birthday);
                if (person == null)
                {
                    person = new Person();
                    familyTree.Add(person);
                }
                person.Name = name;
                person.BirthDate = birthday;

                int index = familyTree.IndexOf(person);
                int count = familyTree.Count - index;
                Person[] copy = new Person[count];
                familyTree.CopyTo(index, copy, 0,count);

                Person copyPerson = copy.FirstOrDefault(p => p.Name == name || p.BirthDate == birthday);

                if (copyPerson != null)
                {
                    familyTree.Remove(copyPerson);
                    person.Parents.AddRange(copyPerson.Parents);
                    person.Parents = person.Parents.Distinct().ToList();

                    person.Children.AddRange(copyPerson.Parents);
                    person.Children = person.Parents.Distinct().ToList();
                }
            }
        }
        Console.WriteLine(mainPerson);
        Console.WriteLine("Parents:");
        foreach (var p in mainPerson.Parents)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("Children:");
        foreach (var p in mainPerson.Children)
        {
            Console.WriteLine(p);
        }
    }

    private static void SetChild(List<Person> familyTree, Person parentPerson, string child)
    {
        var childPerson = new Person();
        if (isBirthday(child))
        {
            if (!familyTree.Any(p=>p.BirthDate == child))
            {
                
                childPerson.BirthDate = child;
            }
            else
            {
                childPerson = familyTree.First(p => p.BirthDate == child);
            }
           
        }
        else
        {
            if (!familyTree.Any(p => p.Name == child))
            {

                childPerson.BirthDate = child;
            }
            else
            {
                childPerson = familyTree.First(p => p.Name == child);
            }
        }
        parentPerson.Children.Add(childPerson);
        familyTree.Add(childPerson);
        childPerson.Parents.Add(parentPerson);
    }

    static bool isBirthday(string input) {
        return Char.IsDigit(input[0]);
    }

}

