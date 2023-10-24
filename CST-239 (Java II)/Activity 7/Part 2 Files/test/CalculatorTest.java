package test;

import static org.junit.Assert.*;

import java.util.Arrays;
import java.util.Collection;

import org.junit.Assert;
import org.junit.Test;
import org.junit.runners.Parameterized.Parameter;
import org.junit.runners.Parameterized.Parameters;

import app.Calculator;

public class CalculatorTest {
	enum Type {ADD, SUBTRACT, MULTYPLY, DIVIDE};
	
	@Parameter(0)
	public Type type;
	@Parameter(1)
	public int a1;
	@Parameter(2)
	public int a2;
	@Parameter(3)
	public int result;
	
	@Parameters
	public static Collection<Object[]> data() {
		Object[][] data = new Object[][] {
			{Type.ADD, 2, 1, 3 }, {Type.ADD, 5, 2, 7},
			{Type.SUBTRACT, 2, 1, 1 }, {Type.SUBTRACT, 5, 2, 3},
			{Type.MULTYPLY, 2, 1, 2 }, {Type.MULTYPLY, 5, 2, 10},
			{Type.DIVIDE, 2, 1, 2 }, {Type.DIVIDE, 5, 2, 2} 
		};
		return Arrays.asList(data);
	}
	
	
	@Test
	public void testAdd() {
		Calculator calc = new Calculator();
		Assert.assertEquals(3, calc.add(2, 1));
		Assert.assertEquals(7, calc.add(5, 2));
	}

	@Test
	public void testSubtract() {
		Calculator calc = new Calculator();
		Assert.assertEquals(1, calc.subtract(2, 1));
		Assert.assertEquals(3, calc.subtract(5, 2));
	}

	@Test
	public void testMultiply() {
		Calculator calc = new Calculator();
		Assert.assertEquals(2,  calc.multiply(2, 1));
		Assert.assertEquals(10, calc.multiply(5, 2));
	}

	@Test
	public void testDivide() {
		Calculator calc = new Calculator();
		Assert.assertEquals(2, calc.divide(2, 1));
		Assert.assertEquals(2, calc.divide(5, 2));
	}

}
