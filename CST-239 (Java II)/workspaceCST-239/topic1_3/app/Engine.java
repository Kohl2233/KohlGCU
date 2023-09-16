package app;

public class Engine {
	// Class Attributes
	private String state;
	
	// Constructor
	Engine (String state){
		this.state = state;
	}
	
	// Setter Method
	public void setState(String state) {
		this.state = state;
	}
	
	// Getter Method
	public String getState() {
		return state;
	}
	
	// Other Methods
	public void start() {
		this.setState("Running");
	}
	
	public void stop() {
		this.setState("Off");
	}
	
	public boolean isRunning() {
		if (state == "Running") {
			return true;
		} else {
			return false;
		}
	}
}
