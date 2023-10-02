package base;

public class Trapezoid extends ShapeBase {
	private int shortWidth;
	
	public Trapezoid(int width, int shortWidth, int height, String name) {
		super(width, height, name);
		this.shortWidth = shortWidth;
	}
	
	@Override
	public int calculateArea() {
		return (int) ((0.5) * (width + shortWidth) * height);
	}
}
