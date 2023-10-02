package base;

public class ShapeBase implements ShapeInterface {
	protected int width;
	protected int height;
	protected String name;
	
	ShapeBase(int width, int height, String name){
		this.width = width;
		this.height = height;
		this.name = name;
	}
	
	public String getName() {return this.name;}
	
	@Override
	public int calculateArea() {
		// TODO Auto-generated method stub
		return -1;
	}
	
}
