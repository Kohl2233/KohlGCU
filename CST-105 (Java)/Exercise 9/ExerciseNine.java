import java.util.ArrayList;

public class ExerciseNine {
    public static void main(String[] args){
        // Create Die ArrayList of 5 Die objects
        ArrayList<Die> dieArrayList = new ArrayList<Die>();
        for (int i = 0; i < 5; i++){
            Die die = new Die(1, 6);
            dieArrayList.add(die);
        } 

        // 100,000 Rounds
        int numThreeKind = 0;
        int numFourKind = 0;
        int numFiveKind = 0;
        for (int rollNum = 0; rollNum < 100000; rollNum++){
            // Roll each Die
            for (int i = 0; i < dieArrayList.size(); i++){
                Die die = dieArrayList.get(i);
                die.rollDie();
            }
            
            // Check each die's face value, use face value of Die 1
            int numReps = 1;
            for (int i = 1; i < dieArrayList.size(); i++){
                if (dieArrayList.get(0).getFaceValue() == dieArrayList.get(i).getFaceValue()){
                    numReps++;
                }
            }

            // Check for Five Kind, Four Kind, and lastly Three Kind
            if (numReps == 5){
                numFiveKind++;
            } else if (numReps == 4){
                numFourKind++;
            } else if (numReps == 3){
                numThreeKind++;
            }

            // Status Bar
            System.out.printf("\rRounds Played: %,d", rollNum + 1);
        }

        // Output Results
        System.out.printf("\nIn 100,000 Rolls, you rolled 3 of a kind %d times, 4 of a kind %d times, and 5 of a kind %d times.\n\n", numThreeKind, numFourKind, numFiveKind);

    }
}