package app;

public class ServerApp {
	public static void main(String[] args) throws InterruptedException {
		ServerThread server = new ServerThread();
		server.start();
		while(true) {
			System.out.println(".");
			Thread.sleep(5000);
		}
	}
}
