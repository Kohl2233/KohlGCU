package app;

public class MyThread2 implements Runnable {
	public void run() {
		for (int x = 0; x < 100; x++) {
			System.out.println("MyThread2 is running iteration: " + x);
			try {
				Thread.sleep(500);
			} catch (InterruptedException err) {
				err.printStackTrace();
			}
		}
	}
}
