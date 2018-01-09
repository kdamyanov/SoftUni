import java.util.*;

public class FoldAndSum {
    public static void main(String[] args) {
        Scanner scanner =new Scanner(System.in);
        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int k = numbers.length / 4;

        int[] leftPart =new int[k];
        int[] rightPart =new int[k];

        System.arraycopy(numbers, 0, leftPart, 0, k);
        System.arraycopy(numbers, numbers.length - k, rightPart, 0, k);

        ArrayList<Integer> listLeftPart = new ArrayList<>();
        ArrayList<Integer> listRightPart = new ArrayList<>();

        for (int i = 0; i < leftPart.length; i++) {
            listLeftPart.add(leftPart[i]);
            listRightPart.add(rightPart[i]);
        }

        Collections.reverse(listLeftPart);
        Collections.reverse(listRightPart);

        List<Integer> topRow = new ArrayList<>();
        topRow.addAll(listLeftPart);
        topRow.addAll(listRightPart);

        for (int i = 0; i < 2*k; i++) {
            System.out.printf("%d ", topRow.get(i)+numbers[k+i]);
        }

    }
}

