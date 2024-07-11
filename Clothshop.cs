class Clothshop
{
	public static void Main(string[] args)
	{
		double purchase, totalAmt = 0;
		
		purchase = System.Convert.ToDouble(args[0]);
		string cloth = args[1];

		
		switch(cloth)
		{
			case "Milk":
				if(purchase <=100)
				{
					totalAmt = purchase;
				}
				else if(purchase <=200)
				{
					totalAmt = purchase - (purchase * 0.05);
				}
				else if(purchase <=300)
				{
					totalAmt = purchase - (purchase * 0.075);
				}
				else
				{
					totalAmt = purchase - (purchase * 0.1);
				}
				break;
			case "Handloom":
				if(purchase <=100)
				{
					totalAmt = purchase - (purchase * 0.05);
				}
				else if(purchase <=200)
				{
					totalAmt = purchase - (purchase * 0.075);
				}
				else if(purchase <=300)
				{
					totalAmt = purchase - (purchase * 0.1);
				}
				else
				{
					totalAmt = purchase - (purchase * 0.15);
				}
				break;
		}
		System.Console.WriteLine("Total Amount : " + totalAmt);
	}
}