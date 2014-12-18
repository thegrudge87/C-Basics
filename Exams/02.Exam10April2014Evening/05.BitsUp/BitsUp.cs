using System;
class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 7 ; j >= 0; j--)
            { 
                if ((step == 1 && index >0) || (index % step == 1))
                {
                      int mask = 1 << j;
                       num = num | mask;               
                }
                index++;
            }
            Console.WriteLine(num);
        }
    }
}