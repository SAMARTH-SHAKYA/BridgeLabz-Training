
import java.util.Scanner;
public class ReverseArray {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int size = sc.nextInt();
        int arr[] = new int[size];

        for(int i=0;i<size;i++){
            arr[i] = sc.nextInt();
        }
        
        for(int j=0;j<size/2;j++){
            int temp = arr[j];
            arr[j] = arr[size-j-1];
            arr[size-j-1] = temp;
        }

        for(int k=0;k<size;k++){
            System.out.println(arr[k]);
        }
    }

}
