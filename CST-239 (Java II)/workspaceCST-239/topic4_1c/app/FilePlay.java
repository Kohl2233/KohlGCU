package app;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FilePlay {
	private static int copyFile(String inputFile, String outputFile) {
		BufferedReader in = null;
		BufferedWriter out = null;
		try {
			in = new BufferedReader(new FileReader(inputFile));
			out = new BufferedWriter(new FileWriter(outputFile));
			String line;
			while((line = in.readLine()) != null) {
				String[] tokens = line.split("\\|");
				out.write(String.format("Name is %s %s of age %s\n", tokens[0], tokens[1], tokens[2]));
			}
			in.close();
			out.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
			return -1;
		} catch (IOException e) {
			e.printStackTrace();
			return -2;
		}
		return 0;
	}
	
	public static void main(String[] args) {
		int err = FilePlay.copyFile("InUsers.txt", "OutUsers.txt");
		switch (err) {
			case 0:
				System.out.println("File was copied successfuly.");
				break;
			case -1: 
				System.out.println("File could not be opened.");
				break;
			case -2:
				System.out.println("File I/O error.");
				break;
			
		}
	}
}


