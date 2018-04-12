using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private int age;

    public int Age {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public Person()
    {
        this.Age = 1;
        this.Name = "No name";
    }

    public Person(int age)
    {
        this.age = age;
        this.Name = "No name";
    }

    public Person(string name, int age)
    {
        this.age = age;
        this.name = name;
    }
}

