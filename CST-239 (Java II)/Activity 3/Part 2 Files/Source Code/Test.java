package base;

public class Test {
	public static void main(String[] args) {
		ShapeBase[] shapes = new ShapeBase[4];
		shapes[0] = new Rectangle(10, 200, "Rectangle");
		shapes[1] = new Triangle(10, 50, "Triangle");
		shapes[2] = new Circle(10, 20, "Cirlce");
		shapes[3] = new Trapezoid(30, 20, 15, "Trapezoid");
		
		for (int x = 0; x < shapes.length; x++) {
			displayArea(shapes[x]);
		}
	}
	
	private static void displayArea(ShapeBase shape) {
		System.out.printf("This shape is named %s with an area of %d.\n", shape.getName(), shape.calculateArea());
	}
}
