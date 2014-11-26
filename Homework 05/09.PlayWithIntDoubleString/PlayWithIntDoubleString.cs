using System;
using System.Globalization;
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Please enter an int:");
            int output = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", output+1);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Please enter a double:");
            double output = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("{0}", output+1);

        }
        else if (choice == 3)
        {
            Console.WriteLine("Please enter a string:");
            string output = Console.ReadLine();
            Console.WriteLine("{0}*", output);
        }
    }
}