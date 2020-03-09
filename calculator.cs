class calculator 
{
	static void Main(String[]args) 
	{
		int a;
		int b;
		
		Console.WriteLine("Hasil Penambahan",a,b, Penambahan(a,b));
		Console.WriteLine("Hasil Pengurangan",a,b, Pengurangan(a,b));
	}
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	static int Pengurangan (int a , int b)
	{
		return a - b;
	}
}
	
	