package app;

public class CounterWorker {
	public static void main(String[] args) throws InterruptedException {
		System.out.println("This is the initial value of the Counter: " + Counter.getCount());
		
		int numberCounters = 1000;
		
		CounterThread[] counters = new CounterThread[numberCounters];
		for (int x = 0; x < 1000; x++) {
			counters[x] = new CounterThread();
		}
		
		for (int x = 0; x < 1000; x++) {
			counters[x].start();
		}
		
		for (int x = 0; x < 1000; x++) {
			counters[x].join();
		}
		
		System.out.println("This is the end value of the Counter: " + Counter.getCount());
	}
}
