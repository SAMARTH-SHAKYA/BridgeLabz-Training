using System;
public class Power {
    static void Main() {
        
        int x = Convert.ToInt32(Console.ReadLine());
        int pow = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(x, pow);
        Console.WriteLine(result);
    }
}
