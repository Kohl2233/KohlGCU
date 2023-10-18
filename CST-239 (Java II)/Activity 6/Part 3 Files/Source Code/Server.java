package app;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {
	// Attributes
	private ServerSocket serverSocket;
	private Socket clientSocket;
	private PrintWriter out;
	private BufferedReader in;
	
	public void start(int port) throws IOException {
		// Wait for client connection
		System.out.println("Waiting for a Client Connection...");
		serverSocket = new ServerSocket(port);
		clientSocket = serverSocket.accept();
		
		// Once client connects
		System.out.println("Received a Client connection on port " + clientSocket.getLocalPort());
		out = new PrintWriter(clientSocket.getOutputStream(), true);
		in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
		
		// Wait for a command
		String inputLine;
		while ((inputLine = in.readLine()) != null) {
			// If period command shut down server
			if (".".equals(inputLine)) {
				System.out.println("Received command to shut down.");
				out.println("QUIT");
				break;
			} else {
				// Echo command/acknowledgement back to client
				System.out.println("Got a message of: " + inputLine);
				out.println("OK");
			}
		}
		
		// Exit Message that Server Shut Down
		System.out.println("Server is shut down.");
	}
	
	public void cleanup() throws IOException {
		// cleanup logic to close network connection
		in.close();
		out.close();
		clientSocket.close();
		serverSocket.close();
	}
	
	public static void main(String[] args) throws IOException {
		Server server = new Server(); // create instance of server
		server.start(6666); // Start server (does not return until exit command)
		server.cleanup(); // Clean up server
	}
}
