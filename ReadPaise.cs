class ReadPaise
{
	public static void Main(string[] args)
	{
		double a = System.Convert.ToDouble(args[0]);
		int paise = (int)(a * 100);
		System.Console.WriteLine(paise + " Paise");
	}
}