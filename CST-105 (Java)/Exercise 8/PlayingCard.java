public class PlayingCard {
    // Class Variables
    char suit;
    int value;

    // Constructor
    PlayingCard(char suit, int value){
        this.suit = suit;
        this.value = value;
    }

    // Accessor (Getter) Methods
    public char getSuit(){
        return suit;
    }

    public int getValue(){
        return value;
    }

    public String toString(){
        String out; // string to return
        switch (value){
            case 11:
                // Jack Card
                out = "(J, " + suit + ")"; 
                break;
            case 12:
                // Queen Card
                out = "(Q, " + suit + ")";
                break;
            case 13: 
                // King Card
                out = "(K, " + suit + ")";
                break;
            case 14:
                // Ace Card
                out = "(A, " + suit + ")";
                break;
            default:
                // Any other Card
                out = "(" + value + ", " + suit + ")";
                break;
        }
        return out;
    }

    // Mutator (Setter) Methods
    public void setSuit(char suit){
        this.suit = suit;
    }

    public void setValue(int value){
        this.value = value;
    }

    // Other Methods
    public boolean isMatch(PlayingCard compCard){
        int compValue = compCard.getValue();
        char compSuit = compCard.getSuit();

        if((value == compValue) || (suit == compSuit)){
            return true;
        } else {
            return false;
        }
    }
}
