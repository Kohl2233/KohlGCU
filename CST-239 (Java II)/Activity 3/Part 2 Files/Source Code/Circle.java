package base;

public class Circle extends ShapeBase {
	public Circle(int width, int height, String name) {
		super(width, height, name);
	}
	
	@Override
	public int calculateArea() {
		return (int) Math.PI * (((width/2) * (width/2)));
	}
}
