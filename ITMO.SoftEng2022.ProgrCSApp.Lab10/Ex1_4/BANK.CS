using System.Collections;
public class Bank
{
    private Bank() { } // 10.1.4. Закрытый конструктор
    public static long CreateAccount() // 10.1.4. + static
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }

    public static long CreateAccount(AccountType aType, decimal aBal) // 10.1.4. + static
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }

    public static long CreateAccount(AccountType aType) // 10.1.4. + static
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }

    public static long CreateAccount(decimal aBal) // 10.1.4. + static
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }

    public static bool CloseAccount(long accNo) // 10.1.4. + static
    {
        BankAccount closing = (BankAccount)accounts[accNo];
        if (closing != null)
        {
            accounts.Remove(accNo);
            closing.Dispose();
            return true;
        }
        else
        {
            return false;
        }
    }
    private static Hashtable accounts = new Hashtable(); // 10.1.4. + static

    public static BankAccount GetAccount(long accNo)
    {
        return (BankAccount)accounts[accNo];
    }
}
