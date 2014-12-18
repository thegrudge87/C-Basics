using System;
class NineDigitMagicNum
{
    static void Main()
    {
        // Input
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        // Bool if we have found a magic number it will become true.
        bool isMagicNum = false;

        for (int abc = 111; abc <= 777; abc++)
        {
            int def = abc + diff;
            int ghi = def + diff;
            if (isAllowed(abc) && isAllowed(def) && isAllowed(ghi) && 
               (ghi <=777) && 
               digitsSum(abc)+digitsSum(def)+ digitsSum(ghi) == sum)
            {
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                isMagicNum = true;
            }
        }
        if (isMagicNum == false)
        {
            Console.WriteLine("No");
        }
    }


    static bool isAllowed(int number)
    {
        string digits = number.ToString();
        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }

    static int digitsSum(int abc)
    {
        int sum = 0;
        while (abc > 0)
        {
            sum += abc % 10;
            abc = abc / 10;
        }
        return sum;
    }
}