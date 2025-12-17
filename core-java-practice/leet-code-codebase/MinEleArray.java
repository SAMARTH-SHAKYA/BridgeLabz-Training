import java.util.Scanner;

public class MinEleArray {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();

        int arr[] = new int[x];

        for (int i = 0; i < x; i++) {
            arr[i] = sc.nextInt();
        }

        int min = arr[0];
        for (int j = 1; j < x; j++) {
            if (arr[j] < min) {
                min = arr[j];
            } else {
                continue;
            }
        }
        System.out.println(min);
    }
}
