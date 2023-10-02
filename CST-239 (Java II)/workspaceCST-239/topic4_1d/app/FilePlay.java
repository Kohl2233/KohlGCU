package app;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FilePlay {
	private static void copyFile(String inputFile, String outputFile) throws FileNotFoundException, IOException {
		BufferedReader in = null;
		BufferedWriter out = null;
		in = new BufferedReader(new FileReader(inputFile));
		out = new BufferedWriter(new FileWriter(outputFile));
		String line;
		while((line = in.readLine()) != null) {
			String[] tokens = line.split("\\|");
			out.write(String.format("Name is %s %s of age %s\n", tokens[0], tokens[1], tokens[2]));
		}
		
		try {
			if (in != null) {
				in.close();
			}
			if (out != null) {
				out.close();
			}
		} catch (IOException err) {
			err.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		try {
			FilePlay.copyFile("InUsers.txt", "OutUsers.txt");
			System.out.println("File was copied successfully.");
		} catch (FileNotFoundException err) {
			err.printStackTrace();
			System.out.println("File could not be opened.");
		} catch (IOException err) {
			err.printStackTrace();
			System.out.println("File I/O error.");
		}
	}
}


