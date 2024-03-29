
using System;

class CreateAccount
{

	static void Main()
	{
		Console.WriteLine("������� ����"); //10.1.2
		Bank bank = new Bank(); //10.1.2
		long sidsAccNo = bank.CreateAccount(); //10.1.2
		BankAccount sids = bank.GetAccount(sidsAccNo); //10.1.2
		TestDeposit(sids); //10.1.2
		TestWithdraw(sids); //10.1.2
		Write(sids); //10.1.2
		if (bank.CloseAccount(sidsAccNo)) //10.1.2
		{
			Console.WriteLine("������� ������"); //10.1.2
		}
		else //10.1.2
		{
			Console.WriteLine("���-�� ����� �� ��� ��� �������� ��������"); //10.1.2
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
