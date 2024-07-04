class Temperature
{
	public static void Main(string[] args)
	{
		double temp = System.Convert.ToDouble(args[0]);
		double C = (temp - 32) * 5 / 9;
		
		System.Console.WriteLine("Temp(F) = {0} \nTemp(C) = {1}",temp,C);
	}
} 