import java.util.Scanner;

public class VarHexFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine().substring(2);

        int output = Integer.parseInt(input, 16);
        System.out.println(output);
    }
}
