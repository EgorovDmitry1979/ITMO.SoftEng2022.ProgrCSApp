
using System;

class CreateAccount
{

	static void Main()
	{
		Console.WriteLine("Аккаунт Сида"); //10.1.2
		Bank bank = new Bank(); //10.1.2
		long sidsAccNo = bank.CreateAccount(); //10.1.2
		BankAccount sids = bank.GetAccount(sidsAccNo); //10.1.2
		TestDeposit(sids); //10.1.2
		TestWithdraw(sids); //10.1.2
		Write(sids); //10.1.2
		if (bank.CloseAccount(sidsAccNo)) //10.1.2
		{
			Console.WriteLine("Аккаунт закрыт"); //10.1.2
		}
		else //10.1.2
		{
			Console.WriteLine("Что-то пошло не так при закрытии аккаунта"); //10.1.2
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
