using System;

public class EvenOdd {
    static void Main() {
        
        int num = Convert.ToInt32(Console.ReadLine());

        if(num/2 * 2 == num){
            Console.WriteLine("even");
        }
        else{
            Console.WriteLine("odd");
        }

    }
}
