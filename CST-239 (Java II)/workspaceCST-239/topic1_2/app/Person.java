package app;

public class Person {
	// Class Attributes
	private String name;
	private int age;
	private String occupation;
	private int numChildren;
	private String favHobby;
	
	// Constructor
	Person (String name, int age, String occupation, int numChildren, String favHobby){
		this.name = name;
		this.age = age;
		this.occupation = occupation;
		this.numChildren = numChildren;
		this.favHobby = favHobby;
	}
	
	// Setter Methods
	public void setName (String name) {
		this.name = name;
	}
	
	public void setAge (int age) {
		this.age = age;
	}
	
	public void setNumChildren(int numChildren) {
		this.numChildren = numChildren;
	}
	
	public void setFavHobby(String favHobby) {
		this.favHobby = favHobby;
	}
	
	// Getter Methods
	public String getName() {
		return name;
	}
	
	public int getAge() {
		return age;
	}
	
	public String getOccupation() {
		return occupation;
	}
	
	public int getNumChildren() {
		return numChildren;
	}
	
	public String getFavHobby() {
		return favHobby;
	}
	
	// 'Action' Methods
	public void doHobby() {
		System.out.println("I am inside doHobby()");
	}
	
	public void introduceSelf() {
		System.out.printf("Hi, my name is %s. I am %d years old and am a %s. I have %d children and my favorite thing to do is %s.", name, age, occupation, numChildren, favHobby);
	}
	
}
