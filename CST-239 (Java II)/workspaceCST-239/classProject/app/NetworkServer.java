package app;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class NetworkServer {
	private ServerSocket serverSocket;
	private Socket clientSocket;
	private PrintWriter out;
	private BufferedReader in;
	public StoreFrontApplication StoreFront;
	
	public void start(int port) throws IOException {
		// Wait for Admin Connection
		serverSocket = new ServerSocket(port);
		clientSocket = serverSocket.accept();
		
		// Once Client Connects
		//System.out.println("Received a Client Connection on Port: " + clientSocket.getLocalPort());
		out = new PrintWriter(clientSocket.getOutputStream(), true);
		in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
		
		// Wait for Commands
		String inputLine;
		while ((inputLine = in.readLine()) != null) {
			switch (inputLine) {
			case "U":
				// update inventory with new products
				StoreFront.InvManager.randomInventoryUpdate();
				out.println("Inventory has been updated.");
				out.flush();
				break;
			case "R":
				// return all products in inventory
				out.println(StoreFront.InvManager.getProductDetailsAsString());
				out.flush();
				break;
			case "N":
				// create new product
				out.println("Recieved command to Add New.");
				out.flush();
				break;
			case "Q":
				// shutdown server
				out.println("Received Command to Shut Down.");
				out.flush();
				break;
			}
		}
	}
	
	public void cleanup() throws IOException {
		in.close();
		out.close();
		clientSocket.close();
		serverSocket.close();
	}
	
	public static void main(String[] args) throws IOException {
		NetworkServer server = new NetworkServer();
		server.start(6666);
		server.cleanup();
	}
}
