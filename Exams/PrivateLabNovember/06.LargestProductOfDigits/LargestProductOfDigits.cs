using System;
class LargestProductOfDigits
{
    static void Main()
    {
        string inNum = Console.ReadLine();
        //string inNum = "73167176531330624919225119674426574742355349194934";
        int pos = 0;
        int maxProduct = int.MinValue;
        while (pos+6 <= inNum.Length)
        {
            int frstD = Convert.ToInt32(new string(inNum[pos], 1));
            int scndD = Convert.ToInt32(new string(inNum[pos+1], 1));
            int thrdD = Convert.ToInt32(new string(inNum[pos+2], 1));
            int frthD = Convert.ToInt32(new string(inNum[pos+3], 1));
            int ffthD = Convert.ToInt32(new string(inNum[pos+4], 1));
            int sxthD = Convert.ToInt32(new string(inNum[pos+5], 1));
            maxProduct = Math.Max(maxProduct, frstD*scndD*thrdD*frthD*ffthD*sxthD);
            pos++;
        }
        Console.WriteLine(maxProduct);
    }
}