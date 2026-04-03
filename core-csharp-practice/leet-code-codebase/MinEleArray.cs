using System;

public class MinEleArray {
    static void Main() {
      
        int x = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[x];

        for (int i = 0; i < x; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = arr[0];
        for (int j = 1; j < x; j++) {
            if (arr[j] < min) {
                min = arr[j];
            } 
        }
        Console.WriteLine(min);
    }
}
