using System;

public class Program
{
    public static void Main()
    {
        // Create a BankAccount instance with an initial balance of $1000.
        BankAccount account = new BankAccount(1000);

        // Use the GetBalance method to get the current balance.
        double currentBalance = account.GetBalance();
        Console.WriteLine("Current Balance: $" + currentBalance);

        // Attempt to call the private method PerformAudit (won't compile).
        // This will result in a compilation error because private methods cannot be accessed from outside the class.
        // account.PerformAudit();
    }
}

public class BankAccount
{
    // Keeping track of current balance.
    private double balance;

    // Constructor
    public BankAccount(double initialAmount)
    {
        balance = initialAmount;
    }

    // Accessor method for balance.
    public double GetBalance()
    {
        return balance;
    }

    // Private method to perform a transaction audit.
    private void PerformAudit()
    {
        // In a real application, this method would perform auditing.
        // For this example, we'll just print a message.
        Console.WriteLine("Audit complete.");
    }
}
