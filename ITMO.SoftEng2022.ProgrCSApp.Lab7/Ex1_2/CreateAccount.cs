using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab7Ex1_2 //Протестировать метод TransferFrom
{
    public class Test //newlab7.1.2
    {
        public static void Main()
        {
            BankAccount b1 = new BankAccount(); //newlab7.1.2
            b1.Populate(100); //newlab7.1.2

            BankAccount b2 = new BankAccount(); //newlab7.1.2
            b2.Populate(100); //newlab7.1.2

            Console.WriteLine("Before transfer (До перевода)"); //newlab7.1.2
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance()); //newlab7.1.2
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance()); //newlab7.1.2

            b1.TransferFrom(b2, 10); //newlab7.1.2

            Console.WriteLine("After transfer (После перевода)");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance()); //newlab7.1.2
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance()); //newlab7.1.2
        }
    }

    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }

        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
            public string Type()
        {
            return accType.ToString();
        }
            private static long NextNumber()
        {
            return nextAccNo++;
        }

    }
    class CreateAccount
    {
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit (Введите сумму для зачисления): ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw (Введите сумму для снятия): ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds (Недостаточно средств).");
            }
        }

        //static void Main() ////newlab7.1.2 Пришлось закомментировать один из Main-ов
        //{
        //    BankAccount berts = NewBankAccount();
        //    Write(berts);
        //    TestDeposit(berts);
        //    Write(berts);
        //    TestWithdraw(berts);
        //    Write(berts);

        //    BankAccount freds = NewBankAccount();
        //    Write(freds);
        //    TestDeposit(freds);
        //    Write(freds);
        //    TestWithdraw(freds);
        //    Write(freds);
        //}
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance! (Введите баланс счета!): ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        { 
            Console.WriteLine("Account number is (Номер счета) {0}", toWrite.Number());
            Console.WriteLine("Account balance is (Баланс счета) {0}", toWrite.Balance());
            Console.WriteLine("Account type is (Тип счета) {0}", toWrite.Type());
        }
    }
}
