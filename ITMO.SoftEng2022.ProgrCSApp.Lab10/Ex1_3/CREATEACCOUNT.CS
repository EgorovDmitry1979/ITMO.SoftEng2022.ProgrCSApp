
using System;

class CreateAccount
{

	static void Main()
	{
		Console.WriteLine("������� ����");
		Bank bank = new Bank();
		long sidsAccNo = bank.CreateAccount();
		BankAccount sids = bank.GetAccount(sidsAccNo);
		TestDeposit(sids);
		TestWithdraw(sids);
		Write(sids);
		if (bank.CloseAccount(sidsAccNo))
		{
			Console.WriteLine("������� ������");
		}
		else
		{
			Console.WriteLine("���-�� ����� �� ��� ��� �������� ��������");
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
