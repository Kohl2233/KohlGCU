package base;

public class Triangle extends ShapeBase {
	public Triangle(int width, int height, String name) {
		super(width, height, name);
	}
	
	@Override
	public int calculateArea() {
		return width * height / 2;
	}
}
