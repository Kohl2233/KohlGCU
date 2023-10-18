package app;

public class MyThread1 extends Thread {
	public void run() {
		for (int x = 0; x < 1000; x++) {
			System.out.println("MyThread1 is running iterartion: " + x);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException err) {
				err.printStackTrace();
			}
		}
	}
}
