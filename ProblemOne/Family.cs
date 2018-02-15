﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Family
{
    private List<Person> people;
    public List<Person> People {
        get
        {
            return this.people;
        }
        set
        {
            this.people = value;
        }
    }

    public Family()
    {
        this.people = new List<Person>();
    }
    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {
        return People.OrderByDescending(x => x.Age).FirstOrDefault();
    }

}

