import java.util.ArrayList;
import java.util.Random;

public class ExerciseEight {
    public static void main(String[] args){
        // Create ArrayList of 52 PlayingCards
        ArrayList<PlayingCard> playingCards = createDeck();

        
        Random randy = new Random();
        int randomIndexOne = randy.nextInt(52);
        int randomIndexTwo = randy.nextInt(52);
        
        PlayingCard mainCard = playingCards.get(randomIndexOne);
        PlayingCard compCard = playingCards.get(randomIndexTwo);

        boolean compareResult = mainCard.equals(compCard);
        if (compareResult){
            System.out.println("----- " + mainCard.toString() + " and " + compCard.toString() + " match!");
        } else {
            System.out.println(mainCard.toString() + " and " + compCard.toString() + " do not match.");
        }
    }

    public static ArrayList<PlayingCard> createDeck(){
        ArrayList<PlayingCard> playingCards = new ArrayList<PlayingCard>();
        for (int s = 1; s <= 4; s++){
            char suit;
            if (s == 1){
                suit = 'C'; // clubs
            } else if (s == 2){
                suit = 'S'; // spades
            } else if (s == 3){
                suit = 'H'; // hearts
            } else {
                suit = 'D'; // diamonds
            }
            for (int val = 1; val < 14; val++){
                PlayingCard newCard = new PlayingCard(suit, val + 1); // create card
                playingCards.add(newCard); // add card to playingCards ArrayList
                //System.out.println(newCard.toString() + " created and added."); // debug
            }
            //System.out.println("\n");
        }
        return playingCards;
    }
}