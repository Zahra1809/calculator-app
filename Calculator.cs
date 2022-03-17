class Calculator
{
	static void Min(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
		Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
		Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
	static int Perkalian(int a, int b)
    {
        return a * b;
    }
    static int Pembagian(int a, int b)
    {
        return a / b;
    }
}