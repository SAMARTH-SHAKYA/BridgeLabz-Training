public interface IFitness
{
    public Person[] EntryMembers(Person[] personDatabase,ref int currIdx);
    

    public void DisplayCurrentRankings(ref Person[] personDatabase,int currIdx);
}