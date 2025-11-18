using System;

public class BankAccount
{
    private decimal balance;   // Private: cannot be accessed outside this class

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
