using System;
class Percentage
{
    public static void Main(string[] args)
    {
        double maths = Convert.ToDouble(Console.ReadLine());
        double phy = Convert.ToDouble(Console.ReadLine());
        double chem = Convert.ToDouble(Console.ReadLine());

        double percentage = (maths + phy + chem) / 3;

        if(percentage >= 80)
        {
            Console.WriteLine("Level 4");
        }
        else if(percentage >=70 && percentage < 80)
        {
            Console.WriteLine("Level 3");
        }
        else if(percentage >=60 && percentage < 70)
        {
            Console.WriteLine("Level 2");
        }
        else if(percentage >=50 && percentage < 60)
        {
            Console.WriteLine("Level 1");
        }
        else if(percentage >=40 && percentage < 50)
        {
            Console.WriteLine("Level 1 Below");
        }
        else
        {
            Console.WriteLine("Remedia standards");
        }

    }
}