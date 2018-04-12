using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private string birthDate;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }
    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }
    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }
    public override string ToString()
    {
        return $"{this.Name} {this.BirthDate}";
    }
}   

