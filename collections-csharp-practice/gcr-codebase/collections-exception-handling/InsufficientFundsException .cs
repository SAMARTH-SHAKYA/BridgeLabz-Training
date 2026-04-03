using System;

class InsufficientFundsException : Exception
{
  public InsufficientFundsException(string message) : base(message)
  {
  }
}


class BankAccount
{
  private double balance;

  public BankAccount(double initialBalance)
  {
    balance = initialBalance;
  }

  public void Withdraw(double amount)
  {
    if (amount < 0)
    {
      throw new ArgumentException("Invalid amount!");
    }

    if (amount > balance)
    {
      throw new InsufficientFundsException("Insufficient balance!");
    }

    balance -= amount;
    Console.WriteLine("Withdrawal successful, new balance: " + balance);
  }
}


class Program
{
  static void Main()
  {
    try
    {
      BankAccount account = new BankAccount(5000);

      Console.Write("Enter withdrawal amount: ");
      double amount = double.Parse(Console.ReadLine());

      account.Withdraw(amount);
    }
    catch (InsufficientFundsException ex)
    {
      Console.WriteLine(ex.Message);
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}
