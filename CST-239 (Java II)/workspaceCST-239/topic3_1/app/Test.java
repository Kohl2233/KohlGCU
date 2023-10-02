package app;

import java.util.Arrays;

public class Test {
	public static void main(String[] args) {
		// create new person objects
		Person person1 = new Person("Justine", "Reha", 20);
		Person person2 = new Person("Brianna", "Reha", 22);
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
		
		
		person1.walk();
		person1.run();
		System.out.println("Person 1 is running: " + person1.isRunning());
		person1.walk();
		System.out.println("Person 1 is running: " + person1.isRunning());
		
		
		Person[] persons = new Person[4];
		persons[0] = new Person("Justine", "Mark", 36);
		persons[1] = new Person("Brianna", "Reha", 18);
		persons[2] = new Person("Mary", "Reha", 42);
		persons[3] = new Person("Mark", "Reha", 43);
		Arrays.sort(persons);
		for (int x = 0; x < 4; x++) {
			System.out.println(persons[x]);
		}
	}
}
