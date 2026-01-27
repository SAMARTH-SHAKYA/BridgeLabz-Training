using System;

//adhar card class
public class AdharCard
{
    //encapsualted field
    public long AdharCardHolderNumber {get; private set;}
    public string AdharCardHolderName {get; private set;}

    //constructor
    public AdharCard(string name, long number){
        this.AdharCardHolderName = name;
        this.AdharCardHolderNumber = number;
        
    }

    //overriding the tostring method
    public override string ToString()
    {
        return $"Name : {AdharCardHolderName}, Adhar Number : {AdharCardHolderNumber}";
    }

}