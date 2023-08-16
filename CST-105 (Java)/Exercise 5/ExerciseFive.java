import java.util.Scanner;
import java.io.FileNotFoundException;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;


class ExerciseFive {
    public static void main(String[] args){
        // Video Link: https://www.loom.com/share/43d8373cc7c344bbb588e1a0659da271?sid=f52b3647-6d64-4e63-985e-9729a27ea4bb
        // Variable Declarations
        String inputString = "";
        String currentWord = "";
        int numWords = 0;
        int numChars = 0;

        // Read Sentence from input.in File
        try {
            File inputFile = new File("input.in"); // create file object
            Scanner scan = new Scanner(inputFile); // create scanner object

            inputString = scan.nextLine(); // read sentence from input.in file
            String[] wordArray = inputString.split(" "); // split at whitespace into wordArray
            numWords = wordArray.length; // find how many words are inside wordArray
            String[] encryptionArray = new String[numWords]; // declare/create encryptionArray

            scan.close();

            // Debug Stuff
            System.out.printf("\nSentence from File: %s\n", inputString);
            System.out.printf("Total Number of Words: %d\n\n", numWords);

            // Encryption Word Loop
            for (int i = 0; i < numWords; i++){
                currentWord = wordArray[i]; // assign current word to string in wordArray at index i
                numChars = currentWord.length(); // figure out how many characters in word
                
                if (numChars > 1){
                    // Calculate 'Split' Index
                    int splitIndex = 0;
                    if ((numChars % 2) == 0){
                        // Use Formula (n / 2)
                        splitIndex = (numChars / 2) - 1; // offset by 1
                    } else {
                        // Use Formula ((n + 1) / 2)
                        splitIndex = ((numChars + 1) / 2) - 1; // offset by 1 
                    }

                    // Get First Half of Current Word
                    StringBuilder firstHalf = new StringBuilder("");
                    for (int c = 0; c <= splitIndex; c++){
                        char curChar = currentWord.charAt(c);
                        firstHalf.append(curChar);
                    }

                    // Get Last Half of Current Word
                    StringBuilder lastHalf = new StringBuilder("");
                    for (int c = splitIndex + 1; c < numChars; c++){
                        char curChar = currentWord.charAt(c);
                        lastHalf.append(curChar);
                    }

                    // Combine Both Halves to Create Encryption
                    StringBuilder encryptedWord = new StringBuilder(lastHalf); // start String with last half
                    encryptedWord.append(firstHalf); // append first half onto last half
                    String encryptedString = encryptedWord.toString(); // convert from StringBuilder to String
                    String encryptedStringUpper = encryptedString.toUpperCase(); // make all characters uppercase
                    encryptionArray[i] = encryptedStringUpper; // add encryption String to encryption array  
                    
                    // Output Results to output.out File
                    PrintWriter prWriter = null;
                    try {
                        prWriter = new PrintWriter("results.out");
                        for (int p = 0; p < encryptionArray.length; p++){
                            prWriter.printf("%-15s%-15s\n", wordArray[p], encryptionArray[p]);
                        }
                    } catch (IOException error) {
                        System.out.println("There has been an error...");
                        error.printStackTrace();
                    } finally {
                        prWriter.close();
                    }
                } else {
                    encryptionArray[i] = currentWord;
                } 
            }
        } catch (FileNotFoundException error){
            System.out.println("There has been an error...");
            error.printStackTrace();
        }
    }
}