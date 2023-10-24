package test;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.runner.JUnitCore;
import org.junit.runner.Result;
import org.junit.runner.notification.Failure;

public class TestRunner {
	public static void main(String[] args) {
		Result result = JUnitCore.runClasses(TestAssertions.class);
		for (Failure failure : result.getFailures()) {
			System.out.println("A JUnit test has failed: " + failure.toString());
		}
		System.out.println("The JUnit Tests " + (result.wasSuccessful() ? "Passed" : "Failed"));
	}

}
