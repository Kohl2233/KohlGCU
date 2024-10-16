package app;

import java.util.*;

public class PlayStack {
	public static void main(String[] args) {
		Stack<String> stringStack = new Stack<String>();
		stringStack.push("Mark Reha");
		stringStack.push("Mary Reha");
		stringStack.push("Justine Reha");
		stringStack.push("Brianna Reha");
		
		Stack<Integer> integerStack = new Stack<Integer>();
		integerStack.push(1);
		integerStack.push(-1);
		integerStack.push(5);
		integerStack.push(10);
		
		System.out.println(integerStack);
		System.out.printf("Integer Stack Tests: size is %d and 2nd element is %d\n", integerStack.size(), integerStack.get(1));
		
		Iterator<String> itr = stringStack.iterator();
		while (itr.hasNext()) {
			System.out.println(itr.next());
		}
	}
}
