class Auth
{
	
	enum AccountType
	{
		Saving = 1,
		Current,
	}
	
	private static int accountNo, New = -1;
	private static int[] existingAccountNo = new int[10];
	private static string[] name = new string[10];
	private static long[] phoneNo = new long[10];
	private static int[] accountType = new int[10];
	
	public static void Login()
	{
		System.Console.Clear();
		System.Console.Write("Enter Account Number: ");
		accountNo = System.Convert.ToInt32(System.Console.ReadLine());
		
		if(Verification(accountNo))
		{
			System.Console.WriteLine("Welcome");
		}
		else
		{
			System.Console.WriteLine("\nError: Account does not exist");
			System.Console.WriteLine("1. Retry");
			System.Console.WriteLine("2. Create New Account");
			System.Console.Write("Enter your choice: ");
			switch(System.Console.ReadLine())
			{
				case "1":
					Auth.Login();
					break;
				case "2":
					Auth.CreateNewAccount();
					break;
				default:
					System.Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}

	private static bool Verification(int accountNo)
	{
		foreach(int i in existingAccountNo)
		{
			if(accountNo == i)
				return true;
		}
		return false;
	}

	private static void CreateNewAccount()
	{
		System.Console.Clear();
		New++;
		System.Console.Write("Enter Your Name: ");
		name[New] = System.Console.ReadLine();
		System.Console.Write("Enter Phone Number: ");
		phoneNo[New] = System.Int64.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Select Account Type: ");
		System.Console.WriteLine("\t1. Saving Account");
		System.Console.WriteLine("\t2. Current Account");
		System.Console.Write("Enter here: ");
		accountType[New] = System.Int32.Parse(System.Console.ReadLine());
		
		/***************************** Checking ****************************/

		System.Console.WriteLine();
		System.Console.WriteLine("Your Name: " + name[New]);
		System.Console.WriteLine("Phone Number: " + phoneNo[New]);
		System.Console.WriteLine("Account Type: " + (AccountType)accountType[New]);
		
		System.Console.WriteLine("\nIs above information correct: ");
		System.Console.WriteLine("1. Yes");
		System.Console.WriteLine("2. No");

		switch(System.Console.ReadLine())
		{
			case "1":
				System.Console.Clear();
				existingAccountNo[New] = System.Convert.ToInt32("101" + (New+1).ToString());
				System.Console.WriteLine("Your Account Number is : 101" + (New+1) );
				System.Console.Write("Click Enter to continue......... ");
				System.Console.ReadLine();
				Auth.Login();
				break;
			case "2":
				New--;
				Auth.CreateNewAccount();
				break;
			default:
				System.Console.WriteLine("Invalid Choice");
				break;
		}
		
	}
}

class Bank
{
	public static void Main(string[] args)
	{
		Auth.Login();
	}
}