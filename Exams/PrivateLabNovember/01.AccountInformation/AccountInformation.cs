using System;
class AccountInformation
{
    static void Main()
    {
        // Input data
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        int clientId = int.Parse(Console.ReadLine());
        decimal balance = decimal.Parse(Console.ReadLine());

        // Execution
        Console.WriteLine("Hello, {0} {1}", firstName, secondName);
        Console.WriteLine("Client id: {0}", clientId);
        Console.WriteLine("Total balance: {0:F2}", balance);
        Console.WriteLine("Active: {0}", (balance >= 0m) ? "yes" : "no");
    }
}