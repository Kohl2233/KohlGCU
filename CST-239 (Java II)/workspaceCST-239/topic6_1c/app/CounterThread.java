package app;

import java.util.Random;

public class CounterThread extends Thread {
	public void run() {
		try {
			Random randy = new Random();
			int sleeper = randy.ints(1, (1000 + 1)).findFirst().getAsInt();
			Thread.sleep(sleeper);
		} catch (InterruptedException err) {
			err.printStackTrace();
		}
		Counter.increment();
	}
}
