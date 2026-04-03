using System;
using System.Runtime.CompilerServices;
using System.Security;

class Person
{
    public string name = "Samarth";
    private int age = 21;

    protected string role = "Student";

    internal string city = "Delhi";

    public void ShowAge()
    {
        Console.WriteLine(age);
    }
}
class AccessModifiers
{       

    static void Main(string[] args)
    {
        Person p = new Person();

        Console.WriteLine(p.name);
        Console.WriteLine(p.city);

        // Console.WriteLine(p.age); this will show error beacause age is private
        // Console.WriteLine(p.role); this will show error beacuse city is protected

        p.ShowAge();

    }
}