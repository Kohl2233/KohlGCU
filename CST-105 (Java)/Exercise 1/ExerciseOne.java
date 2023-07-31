import java.util.Scanner;

public class ExerciseOne {
    public static void main(String[] args){
        /* Checklist
         * [x] Prompt user for 5 digit integer
         * [x] Read input as integer
         * [x] Find last digit by digit = number % 10
         * [x] Add that digit to the sum
         * [x] Remove last digit by number = number / 10
         * [x] Return sum as output
         */

        // Loom Video Link: https://www.loom.com/share/c5e1dafd15e1484a9059aabfb27c7cd9?sid=45246615-af2d-4b26-9bc2-6d66a1026090
        
        // Variable Declarations
        int number = 0;
        int digit = 0;
        int sum = 0;
        int[] digitArray = new int[5];
        int counter = 0;

        Scanner scan = new Scanner(System.in); // Create the scanner object
        System.out.println("Enter 5 digit Integer: "); // Prompt user for input
        number = scan.nextInt(); // Scan user integer into number var
        scan.close(); // close the scanner

        // loop 
        while (number > 0){
            digit = number % 10; // Find last digit
            sum += digit; // Add that digit to sum
            number = number / 10; // Remove last digit
            digitArray[4 - counter] = digit; // Add digit to array
            counter++; // Increment Counter
        }

        // Output
        System.out.printf("The sum of the digits is %d + %d + %d + %d + %d = %d", digitArray[0], digitArray[1], digitArray[2], digitArray[3], digitArray[4], sum);
    }
}