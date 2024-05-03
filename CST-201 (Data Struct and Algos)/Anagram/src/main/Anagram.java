package main;

import java.util.Scanner;

public class Anagram {

	public static void main(String[] args) {
		// Get User Input
		Scanner scan = new Scanner(System.in);
		System.out.println("Enter a word: ");
		String word1 = scan.next();
		System.out.println("Enter another word: ");
		String word2 = scan.next();
		
		// Compare Strings
		boolean valid = checkAnagram(word1, word2);
		
		// Output
		System.out.print("\n" + valid);
	}
	
	// Big O: O(n)
	private static boolean checkAnagram(String w1, String w2) {
		// Compare String Lengths
		boolean valid = true;
		if (w1.length() == w2.length()) {
			// Compare Each Char (use w1 as the 'base' word to compare w2 to)
			for (int i = 0; i < w1.length(); i++) {
				if (!w2.contains(String.valueOf(w1.charAt(i)))) {
					// missing char, not valid
					valid = false;
					return valid;
				}
			}
		} else {
			// not same length, not valid
			valid = false;
			return valid;
		}
		return valid;
	}
}
