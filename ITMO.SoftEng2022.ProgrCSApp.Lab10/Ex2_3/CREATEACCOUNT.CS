
using System;
using Banking; // 10.2.3. new

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
		Console.WriteLine("Sid's Account");
		long sidsAccNo = Bank.CreateAccount(); // 10.2.3. -Banking.
		BankAccount sids = Bank.GetAccount(sidsAccNo); // 10.2.3 -Banking.
		TestDeposit(sids);
		TestWithdraw(sids);
		Write(sids);
		if (Bank.CloseAccount(sidsAccNo)) // 10.2.3. -Banking.
			Console.WriteLine("Account Closed");
		else
			Console.WriteLine("Something went wrong closing the account");
    }

	static void TestDeposit(BankAccount acc) // 10.2.3. -Banking.
	{
		Console.Write("Enter amount to deposit: ");
		decimal amount = decimal.Parse(Console.ReadLine());
		acc.Deposit(amount);        
	}
    
	static void TestWithdraw(BankAccount acc) // 10.2.3. -Banking.
	{
		Console.Write("Enter amount to withdraw: ");
		decimal amount = decimal.Parse(Console.ReadLine());
		acc.Withdraw(amount);   
	}
      
    static void Write(BankAccount acc) // 10.2.3. -Banking.
	{
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
		Console.WriteLine("Transactions:");
		foreach (BankTransaction tran in acc.Transactions()) // 10.2.3. -Banking.
		{
			Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
		}
		Console.WriteLine();
    }
}
