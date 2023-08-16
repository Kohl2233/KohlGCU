import java.util.Scanner;
import java.util.Random;

public class ExerciseThree {
    public static void main(String[] args){
        /*
         * Checklist
         * [x] Generate Random Number between 1 and 10000
         * [x] Get User Guess until Correct
         */

        // Video Link: https://www.loom.com/share/53f98132c9364d528c8a01718b876f46?sid=ac268a4a-0780-4239-a515-d92d4a950100

        // Variable Declarations
        Random randy = new Random(); // create Random object
        Scanner scan = new Scanner(System.in); // create Scanner object
        int randomNum = randy.nextInt(10000) + 1; // random number between 1 and 10000
        int userGuess = 0; // will hold user guess
        int upperRange = 10000; // holds upper tange of eligilbe values
        int lowerRange = 1; // holds lower range of eligible values
        boolean isSolved = false; // control variable for loop

        // Enter Program Loop
        while(!isSolved){
            // Get User Guess
            System.out.printf("Please enter a value between %d and %d:\n", lowerRange, upperRange); // input prompt
            userGuess = scan.nextInt(); // scan input into userGuess

            // Value Checking
            if(userGuess < randomNum){
                System.out.println("HIGHER"); // print a hint
                lowerRange = userGuess; // update lowerRange
            } else if (userGuess > randomNum){
                System.out.println("LOWER"); // print a hint
                upperRange = userGuess; // update upperRange
            } else if (userGuess == randomNum){
                System.out.println("WINNER"); // win message
                isSolved = true; // terminate loop
            }
        }

        scan.close(); // close scanner
    }
}