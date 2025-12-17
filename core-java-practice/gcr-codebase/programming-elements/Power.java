import java.util.Scanner;

public class Power {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();

        int pow = sc.nextInt();

        System.out.println(Math.pow(x, pow));
    }
}
