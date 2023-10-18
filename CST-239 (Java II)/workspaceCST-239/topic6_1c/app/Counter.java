package app;

public class Counter {
	static int count = 0;
	
	static synchronized void increment() {
		count = count + 1;
	}
	
	static int getCount() {return count;}
}
