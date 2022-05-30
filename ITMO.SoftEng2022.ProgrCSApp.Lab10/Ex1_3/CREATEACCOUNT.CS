
using System;

class CreateAccount
{

	static void Main()
	{
		Console.WriteLine("Аккаунт Сида");
		Bank bank = new Bank();
		long sidsAccNo = bank.CreateAccount();
		BankAccount sids = bank.GetAccount(sidsAccNo);
		TestDeposit(sids);
		TestWithdraw(sids);
		Write(sids);
		if (bank.CloseAccount(sidsAccNo))
		{
			Console.WriteLine("Аккаунт закрыт");
		}
		else
		{
			Console.WriteLine("Что-то пошло не так при закрытии аккаунта");
		}
	}

	static void TestDeposit(BankAccount acc)
	{
		Console.Write("Введите сумму для вклада: ");
		decimal amount = decimal.Parse(Console.ReadLine());
		acc.Deposit(amount);        
	}
    
	static void TestWithdraw(BankAccount acc)
	{
		Console.Write("Введите сумму для снятия: ");
		decimal amount = decimal.Parse(Console.ReadLine());
		acc.Withdraw(amount);   
	}

    static void Write(BankAccount acc)
    {
        Console.WriteLine("Номер счета {0}",  acc.Number());
        Console.WriteLine("Баланс счета {0}", acc.Balance());
        Console.WriteLine("Тип счета {0}", acc.Type());
		Console.WriteLine("Транзакции:");
		foreach (BankTransaction tran in acc.Transactions()) 
		{
			Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
		}
		Console.WriteLine();
    }
}
