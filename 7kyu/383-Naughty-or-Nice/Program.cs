using System;
using System.Collections.Generic;

public class NaughtyOrNice
{
    public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people)
    {
        return people.Where(x=>x.WasNice == true).Select(x=>x.Name);
    }

    public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people)
    {
        return people.Where(x=>x.WasNice == false).Select(x=>x.Name);
    }
}

public class Person
{
    public string Name { get; set; }
    public bool WasNice { get; set; }
}