package app;

public class Person implements PersonInterface, Comparable<Person> {
	private String firstName = "Mark";
	private String lastName = "Reha";
	private boolean running;
	private Integer age = null;
	
	public Person(String firstName, String lastName, int age) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
	}
	
	public Person(Person person) {
		this.firstName = person.getFirstName();
		this.lastName = person.getLastName();
	}
	
	public String getFirstName() {
		return this.firstName;
	}
	
	public String getLastName() {
		return this.lastName;
	}
	
	
	@Override
	public boolean equals(Object other) {
		if (other == this) {
			System.out.println("I am here in other == this");
			return true;
		}
		if (other == null) {
			System.out.println("I am here in other == null");
			return false;
		}
		if (getClass() != other.getClass()) {
			System.out.println("I am here in getClass() != other.getClass()");
			return false;
		}
		Person person = (Person)other;
		return (this.firstName == person.firstName && this.lastName == person.lastName);
	}
	
	public String toString() {
		return "My class is " + getClass() + " " + this.firstName + " " + this.lastName + " " + this.age;
	}

	@Override
	public void walk() {
		System.out.println("I am walking");
		running = false;
	}

	@Override
	public void run() {
		System.out.println("I am running");
		running = true;
	}

	@Override
	public boolean isRunning() {
		return running;
	}

	@Override
	public int compareTo(Person p) {
		return this.age.compareTo(p.age);
	}
}
