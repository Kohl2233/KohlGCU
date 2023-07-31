import java.util.Scanner;

public class ExerciseTwo {
    public static void main(String[] args) {
        /* Checklist
         * [x] Prompt user for temp in Fahrenheit
         * [x] Convert to degrees Celsius
         * [x] Output to user
         * [x] Prompt user for temp in Celsius
         * [x] Convert to degrees Fahrenheit
         * [x] Output to user
         */

        // Loom Video Link: https://www.loom.com/share/d566af8a354847fe913647d12072cd03?sid=66a4fa8d-48a0-4ada-8a45-44de2deef480

        // Variable Declarations
        double tempFahrenheit, tempCelsius, tempInput = 0;

        // Prompt for Fahrenheit Temp
        Scanner scan = new Scanner(System.in); // Create scanner object
        System.out.println("Enter a Fahrenheit Temperature: "); // User input prompt (Fahrenheit Temp)
        tempInput = scan.nextDouble(); // Scan the user input into tempInput

        // Convert to Celsius
        tempCelsius = (tempInput - 32) * (5.0f / 9.0f);
        System.out.printf("%.2fF is equivalent to %.2fC", tempInput, tempCelsius); // Output result

        // Prompt user for Celsius temp
        System.out.println("\nEnter a Celsius Temperature: "); // User input prompt (Celsius Temp)
        tempInput = scan.nextDouble(); // scan input into tempInput

        // Convert to Fahrenheit
        tempFahrenheit = (9.0f / 5.0f) * tempInput + 32; // Equation for calculate Fahrenheit
        System.out.printf("%.2fC is equivalent to %.2fF", tempInput, tempFahrenheit); // Output result

        scan.close(); // close the scanner
    }
}