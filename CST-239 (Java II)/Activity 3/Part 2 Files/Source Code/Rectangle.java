package base;

public class Rectangle extends ShapeBase {
	public Rectangle(int width, int height, String name) {
		super(width, height, name);
	}
	
	@Override
	public int calculateArea() {
		return width * height;
	}
}
