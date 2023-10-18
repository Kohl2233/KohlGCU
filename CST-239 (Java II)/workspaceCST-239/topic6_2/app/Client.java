package app;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.net.UnknownHostException;

public class Client {
	private Socket clientSocket;
	private PrintWriter out;
	private BufferedReader in;
	
	public void start(String ip, int port) throws UnknownHostException, IOException {
		clientSocket = new Socket(ip, port); // connect to remote server on specified IP and Port
		
		// Input and Output network buffers to communicate back and forth with the server
		out = new PrintWriter(clientSocket.getOutputStream(), true);
		in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
	}
	
	public String sendMessage(String msg) throws IOException {
		// Send a print message to Server
		out.println(msg); // send message 
		return in.readLine(); // return response message
	}
	
	public void cleanup() throws IOException {
		in.close();
		out.close();
		clientSocket.close();
	}
	
	public static void main(String[] args) throws IOException {
		Client client = new Client(); // create client
		client.start("127.0.0.1", 6666); // connect to local port on specified IP
		
		// Send 10 Messages
		String response;
		for (int count = 0; count < 10; count++) {
			String message;
			if (count != 9) {
				message = "Hello from Client " + count;
			} else {
				message = ".";
			}
			response = client.sendMessage(message);
			
			System.out.println("Server response was " + response);
			if (response.equals("q")) {
				break;
			}
		}
		client.cleanup();
	}
}
