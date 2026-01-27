using System;
public interface ISortAdhar
{
    //method to be implemented by the implementation class
    public void RadixSortAdhar(ref AdharCard[] database, ref int index);
    

    public void PrintDatabase(AdharCard[] database, int index);
    public void AddDetails(ref AdharCard[] database, ref int index,string name,long number);
}