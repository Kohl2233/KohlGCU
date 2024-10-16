package app;

import java.util.*;

public class PlayQueue {
	public static void main(String[] args) {
		Queue<String> stringQueue = new LinkedList<String>();
		stringQueue.offer("Mark Reha");
		stringQueue.add("Mary Reha");
		stringQueue.offer("Justine Reha");
		stringQueue.add("Brianna Reha");
		
		Queue<Integer> integerQueue = new LinkedList<Integer>();
		integerQueue.add(1);
		integerQueue.offer(-1);
		integerQueue.add(5);
		integerQueue.offer(10);
		
		System.out.println(integerQueue);
		System.out.printf("Integer Queue Tests: size is %d and head element is %d\n", integerQueue.size(), integerQueue.peek());
		
		Iterator<String> itr = stringQueue.iterator();
		while (itr.hasNext()) {
			System.out.println(itr.next());
		}
	}
}
