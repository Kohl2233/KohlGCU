package app;

public class MyNumberArray {
	public <E extends Number> void printArray(E[] inputArray) {
		for (E element : inputArray) {
			System.out.printf("%s ", element);
		}
	}
	
	public static void main(String[] args) {
		Integer[] intArray = {1, 2, 3, 4, 5};
		Double[] doubleArray = {1.1, 2.2, 3.3, 4.4};
		Float[] floatArray = {0.0f, 1.0f, 2.5f, 3.5f};
		
		MyArray ma = new MyArray();
		System.out.println("\nArray intArray contains: ");
		ma.printArray(intArray);
		System.out.println("\nArray doubleArray contains: ");
		ma.printArray(doubleArray);
		System.out.println("\nArray floatArray contains: ");
		ma.printArray(floatArray);
	}
}
