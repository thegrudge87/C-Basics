using System;
class BankAccountData
{
    static void Main()
    {
        string firstName = "Dimitar";
        string middleName = "Stoyanov";
        string lastName = "Marinov";
        decimal balance = 12043392;
        string bankName = "My Bank";
        string ibanNum = "BG80 BNBG 9999 1020 3456 78";
        ulong firstCreditCardNum = 5100325465899000;
        ulong secondCreditCardNum = 4957349054007000;
        ulong thirdCreditCard = 2389570043789068;

        //prints data of the account holder
        Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0:C2}", balance); //C2 formats the values as currency.
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", ibanNum);
        //":#### #### #### ####" separates the card number in the 4 groups of 4 digits.
        Console.WriteLine("Customers credit cards: \n{0:#### #### #### ####}\n{1:#### #### #### ####}\n{2:#### #### #### ####}", firstCreditCardNum, secondCreditCardNum, thirdCreditCard);

    }
}
