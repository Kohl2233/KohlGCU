import java.util.Random;

public class Die {
    private int faceValue; // face value after each roll
    private int numSides; // how many sides the die has
    
    // Constructor
    Die(int faceValue, int numSides){
        this.faceValue = faceValue;
        this.numSides = numSides;
    }

    // Setter Methods
    public void setFaceValue(int faceValue){
        this.faceValue = faceValue;
    }

    public void setNumSides(int numSides){
        this.numSides = numSides;
    }

    // Getter Methods
    public int getFaceValue(){
        return faceValue;
    }

    public int getNumSides(){
        return numSides;
    }

    // Other Methods
    public void rollDie(){
        Random randy = new Random(); // create random object
        int newFaceValue;
        while (true){
            newFaceValue = randy.nextInt(numSides + 1); // get random number between 1 and 6
            if (newFaceValue != 0) break;
        }
        setFaceValue(newFaceValue);
    }
}
