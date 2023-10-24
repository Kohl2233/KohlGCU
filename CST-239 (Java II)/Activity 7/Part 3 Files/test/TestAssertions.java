package test;

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Test;

public class TestAssertions {
	@Test
	public void testAssertions() {
		// test data
		String str1 = new String("abc");
		String str2 = new String("abc");
		String str3 = null;
		String str4 = new String("abc");
		String str5 = new String("abc");
		
		int val1 = 5;
		int val2 = 6;
		
		String[] expectedArray = {"one", "two", "three"};
		String[] resultArray = {"one", "two", "three"};
		
		// Check that two objects are equal
		Assert.assertEquals(str1, str2);
		
		// Check that a condition is true
		Assert.assertTrue(val1 < val2);
		
		// Check that a condition is false
		Assert.assertFalse(val1 > val2);
		
		// Check that an object is not null
		Assert.assertNotNull(str1);
		
		// Check if two object references point to the same object
		Assert.assertNotSame(str1, str2);
		
		// Check whether two arrays are equal to each other
		Assert.assertArrayEquals(expectedArray, resultArray);
	}
}
