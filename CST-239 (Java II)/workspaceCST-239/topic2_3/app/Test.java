package app;

public class Test {
	public static void main(String[] args) {
		// create new person objects
		Person person1 = new Person("Justine", "Reha");
		Person person2 = new Person("Brianna", "Reha");
		Person person3 = new Person(person1);
		
		// Test Object Equality
		if (person1 == person2) {
			System.out.println("These persons are identical using ==");
		} else {
			System.out.println("These persons are NOT identical using ==");
		}
		
		// Test Object Equality
		if (person1.equals(person2)) {
			System.out.println("These persons are identical using equals()");
		} else {
			System.out.println("These persons are NOT identitcal using equals()");
		}
		
		// Test Copy Constructor
		if (person1.equals(person3)) {
			System.out.println("These persons are identical using equals()");
		} else {
			System.out.println("These persons are NOT identical using equals()");
		}
		
		// Print Objects
		System.out.println(person1);
		System.out.println(person2.toString());
		System.out.println(person3);
	}
}
