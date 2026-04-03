
using System;
public class ReverseArray {
    static void Main() {
        
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for(int i=0;i<size;i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for(int j=0;j<size/2;j++){
            int temp = arr[j];
            arr[j] = arr[size-j-1];
            arr[size-j-1] = temp;
        }

        for(int k=0;k<size;k++){
            Console.WriteLine(arr[k]);
        }
    }

}
