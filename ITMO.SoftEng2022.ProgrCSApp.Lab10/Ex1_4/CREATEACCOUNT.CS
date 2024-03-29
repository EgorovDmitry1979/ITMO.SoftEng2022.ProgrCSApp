
using System;

public class CreateAccount
{
	static void Main()
	{
		Console.WriteLine("Sid's Account");
		long sidsAccNo = Bank.CreateAccount();
		BankAccount sids = Bank.GetAccount(sidsAccNo);
		TestDeposit(sids);
		TestWithdraw(sids);
		Write(sids);
		if (Bank.CloseAccount(sidsAccNo))
        {
			Console.WriteLine("Account closed");
		}
		else
        {
			Console.WriteLine("Something went wrong closing the account");
		}
	}

	static void TestDeposit(BankAccount acc)
	{
		Console.Write("������� ����� ��� ������: ");
		decimal amount = decimal.Parse(Console.ReadLine());
		acc.Deposit(amount);        
	}
    
	static void TestWithdraw(BankAccount acc)
	{
		Console.Write("������� ����� ��� ������: ");
		decimal amount = decimal.Parse(Console.ReadLine());
		acc.Withdraw(amount);   
	}

    static void Write(BankAccount acc)
    {
        Console.WriteLine("����� ����� {0}",  acc.Number());
        Console.WriteLine("������ ����� {0}", acc.Balance());
        Console.WriteLine("��� ����� {0}", acc.Type());
		Console.WriteLine("����������:");
		foreach (BankTransaction tran in acc.Transactions()) 
		{
			Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
		}
		Console.WriteLine();
    }
}
