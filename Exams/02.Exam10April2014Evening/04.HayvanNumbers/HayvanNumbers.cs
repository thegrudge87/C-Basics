using System;
class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isExist = false;

        for (int abc = 555; abc <=999; abc++)
        {
            int def = abc + diff;
            int ghi = def + diff;

            if ( isAllowed(abc) && isAllowed(def) && isAllowed(ghi) && (ghi <=999) && (digitsSum(abc) + digitsSum(def) + digitsSum(ghi) == sum) )
            {
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                isExist = true;
            }
        }
        if (isExist == false)
        {
            Console.WriteLine("No");
        }
    }

    static bool isAllowed(int num)
    {
        string digits = num.ToString();
        foreach (var digit in digits)
        {
            if ((digit < '5') || (digit > '9'))
            {
                return false;
            }
        }
        return true;
    }

    static int digitsSum(int number)
    {
        int sum = 0;
        sum += number % 10;
        sum += (number / 10) % 10;
        sum += (number / 100) % 10;
        return sum;
    }
}