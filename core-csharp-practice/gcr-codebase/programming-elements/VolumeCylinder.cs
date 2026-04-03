using System;

public class VolumeCylinder {
    static void Main() {
        
        int r = Convert.ToInt32(Console.ReadLine());
		
        int h = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(3.14*r*r*h);
    }
}
