package app;

public class Testing {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int n;
		for (n = 1; n < 11; n++) {
			System.out.println(Q(n));
		}
	}
	
	static int Q(int n) {
		if (n == 1) {
			return 1;
		} else {
			return Q(n - 1) + 2 * n - 1;
		}
	}

}
