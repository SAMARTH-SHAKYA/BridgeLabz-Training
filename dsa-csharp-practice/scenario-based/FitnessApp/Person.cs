using System;
public class Person
{
    public string PersonName {get; private set;}
    public double PersonCurrentSteps {get; private set;}

    public Person(string name)
    {
        this.PersonName = name;
        this.PersonCurrentSteps = 0;
    }

    public void SetSteps(double steps)
    {
        this.PersonCurrentSteps = steps;
    }

}