using System;
class EmployeeData
{
    static void Main()
    {
        string firstName = "Dimitar";
        string lastName = "Marinov";
        byte age = 27;
        char gender = 'M';
        ulong personalIdNum = 8712030000;
        uint uniqueEmployyeNum = 27569999;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", personalIdNum);
        Console.WriteLine("Unique Employee number: {0}",uniqueEmployyeNum );
    }
}
