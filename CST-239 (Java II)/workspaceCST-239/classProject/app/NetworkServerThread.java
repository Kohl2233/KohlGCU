package app;

import java.io.IOException;

public class NetworkServerThread extends Thread{
	public StoreFrontApplication StoreFront;
	// Runs Server in Background
	public void run() {
		NetworkServer server = new NetworkServer();
		server.StoreFront = StoreFront;
		try {
			server.start(6666);
			server.cleanup();
		} catch (IOException err) {
			err.printStackTrace();
		}
	}
}
