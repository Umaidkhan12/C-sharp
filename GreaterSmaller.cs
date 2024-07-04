class GreaterSmaller
{
	public static void Main(string[] args)
	{
		double a = System.Convert.ToDouble(args[0]);
		double b = System.Convert.ToDouble(args[1]);
		double smallest = a < b;
		
		/*if(a == b)
		{
			System.Console.WriteLine("{0} = {1}",a,b);
		}
		else if(a < b)
		{
			System.Console.WriteLine("{0} < {1}",a,b);
		}
		else
		{
			System.Console.WriteLine("{0} > {1}",a,b);
		}*/

		System.Console.WriteLine("Smallest = {0} \nLargest = {1} ",smallest ,a>b);
	}
}