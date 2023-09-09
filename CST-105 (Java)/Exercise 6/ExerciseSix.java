import java.util.Scanner;
import java.io.FileNotFoundException;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;

public class ExerciseSix {
    public static void main(String args[]){
        // Video Link: https://www.loom.com/share/1cb024bb24554fa39dd9dee23cad7763?sid=c06b8511-9c09-4d7e-87ec-aae56a71814b
        // Variable Declaration
        int numRows, numColumns; // holds number of rows and columns
        String inputLine; // holds the input string

        // Create 2D Char Array
        numColumns = 8; // set numColumns
        numRows = 4; // set numRows
        char[][] grid = new char[4][8]; // create 2D array

        // Input Reading
        try {
            File inputFile = new File("input.in"); // create inputFile
            Scanner scan = new Scanner(inputFile); // create Scanner
            inputLine = scan.nextLine(); // read in input line
            scan.close(); // close the scanner

            // Grid Populating Loop
            int stringLength = inputLine.length(); // find the length of input string
            int stringIndex = 0; // set starting string index to 0
            int row, col; // declare row and col (to control the for loop)
            for (row = 0; row < numRows; row++){
                if ((row % 2 == 0) || (row == 0)){ // even numbered row
                    // set col index to 0, assign char's left to right in grid
                    for (col = 0; col < numColumns; col++){
                        if (stringIndex < stringLength){ // check to make sure we still have chars left in input string
                            grid[row][col] = inputLine.charAt(stringIndex); // assign grid value to char
                            stringIndex++; // increase string index
                        } else {
                            grid[row][col] = '*'; // if we run out of input, assign grid point to *
                        }
                    }
                } else { // odd numbered row
                    // set col index to numColumns - 1, assign char's right to left in grid
                    for (col = numColumns - 1; col > -1; col--){ 
                        if (stringIndex < stringLength){ // check to make sure we still have chars left in input string
                            grid[row][col] = inputLine.charAt(stringIndex); // assign grid value to char
                            stringIndex++; // increase string index
                        } else {
                            grid[row][col] = '*'; // if we run out of input, assign grid point to *
                        }
                    }
                }   
            }  
            
            // Debug Stuff
            System.out.println("----- Grid Layout -----");
            for (row = 0; row < numRows; row++){
                for (col = 0; col < numColumns; col++){
                    char gridData = grid[row][col];
                    System.out.printf("%c", gridData);
                    if (col == numColumns - 1){
                        System.out.print("\n");
                    }
                }
            }

            System.out.println("\n----- Output Layout -----");
            for (col = 0; col < numColumns; col++){
                for (row = 0; row < numRows; row++){
                    char gridData = grid[row][col];
                    System.out.printf("%c", gridData);
                }
            }

            // Output File Writing
            PrintWriter prWriter = null;
            try {
                prWriter = new PrintWriter("results.out"); // create printWriter object
                for (col = 0; col < numColumns; col++){
                    for (row = 0; row < numRows; row++){
                        char gridData = grid[row][col]; // grab the grid data at point (row, col)
                        prWriter.printf("%c", gridData); // write the char to output file
                    }
                }
            } catch (IOException err){
                System.out.println("There has been an error..."); // for insurance purposes lol
                err.printStackTrace();
            } finally {
                prWriter.close(); // close print writer
            }
        } catch (FileNotFoundException err){
            System.out.println("There has been an error...");
            err.printStackTrace();
        }
    }
}