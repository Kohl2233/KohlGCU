import java.util.Scanner;
import java.io.FileNotFoundException;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;

public class ExerciseFour {
    public static void main(String[] args){
        /*
         * Checklist
         * [x] Read contributions from file
         * [x] Write findings to txt file
         */

        // Video Link: https://www.loom.com/share/f7f7af6d097846afa343498db606849a?sid=8b55d56a-6e9c-421c-baed-bc69706eb2fa

        // Variable Declarations
        int numContributions = 0; // keeps track of number contributions (for average calc)
        double smallestContribution = 10000000.00f; // holds smallest contribution
        double largestContribution = 0.0f; // holds largest contribution
        double sum = 0.0f; // running total of contributions
        double average = 0.0f; // holds average $ amount of contributions

        String rawContribution = ""; // holds the raw string of $ contribution
        double contribution = 0.0f; // holds contribution converted to double

        Boolean goalReached = false; // holds true/false as to wether the contribution goal was reached

        // File Reading
        try {
            File inputFile = new File("input.in");
            Scanner scan = new Scanner(inputFile);

            // Program Loop
            while(scan.hasNextLine()){
                rawContribution = scan.nextLine(); // read line from input file
                contribution = Double.valueOf(rawContribution); // convert string to double
                
                numContributions++;
                if (contribution < smallestContribution){
                    smallestContribution = contribution; // set smallest contribution
                }
                if (contribution > largestContribution){
                    largestContribution = contribution; // set largest contribution
                }

                sum += contribution; // add current contribution to sum

                System.out.printf("Current Contribution: $%,.2f\nCurrent Sum: $%,.2f\nTotal Contributions: %d\n\n", contribution, sum, numContributions); // test print

                if(sum > 10000000){
                    goalReached = true;
                    break; // break the loop if sum is greater than $10,000,000 (above goal)
                }
            }

            scan.close(); // close the scanner

            // Write Results to output.out
            average = sum / numContributions; // calculate the average contribution amount

            try {
                PrintWriter prWriter = new PrintWriter("results.out"); // create Print Writer object
                
                if (goalReached){
                    prWriter.printf("It took %d contributions to reach the goal.\n", numContributions);
                } else {
                    prWriter.printf("We recieved %d contributions toward our goal.\n", numContributions);
                }
                
                prWriter.printf("The maximum contribution recieved was $%,.2f.\n", largestContribution);
                prWriter.printf("The minimum contribution recieved was $%,.2f.\n", smallestContribution);
                prWriter.printf("The average contribution amount was $%,.2f.\n", average);
                prWriter.printf("A total of $%,.2f was collected.", sum);
                prWriter.close();
                
            } catch (IOException err) {
                System.out.println("An error occured..");
                err.printStackTrace();
            }


            // Print Completion Message
            if (goalReached){
                System.out.println("Contribution Goal Reached! No More Donations will be Accepted.");
            } else {
                System.out.println("End of Contributions, goal of $10,000,000.00 not reached.");
            }
            System.out.println("Results posted in results.out file.");

        } catch (FileNotFoundException err) {
            System.out.println("There has been an error..");
            err.printStackTrace();
        }

    }
}