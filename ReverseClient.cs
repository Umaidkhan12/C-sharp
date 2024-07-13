class Reverse
{
	internal Reverse(int value)
	{
		int rem,rev = 0,n;
		n = value;
		while(n!=0)
		{
			rem = n % 10;
			rev = rev * 10 + rem ;
			n = n / 10;
		}
		System.Console.WriteLine("Reverse : " + rev);
	}
}

class ReverseClient
{
	public static void Main(string[] args)
	{
		Reverse obj = new Reverse(System.Convert.ToInt32(args[0]));
	}
}