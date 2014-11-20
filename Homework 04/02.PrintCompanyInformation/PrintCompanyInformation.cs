using System;
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company Name: ");
        string compName = Console.ReadLine();
        Console.Write("Company Address: ");
        string compAddr = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNum = Console.ReadLine();
        Console.Write("FAX number: ");
        string faxNum = Console.ReadLine();
        if (faxNum == "")
        {
            faxNum = "(no fax)";
        }
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string mangrFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string mangrLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int mangrAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string mangrPhone = Console.ReadLine();

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
                          compName,
                          compAddr,
                          phoneNum,
                          faxNum,
                          website,
                          mangrFirstName,
                          mangrLastName,
                          mangrAge,
                          mangrPhone);
    }
}

