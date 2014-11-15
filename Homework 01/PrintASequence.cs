using System;
class PrintASequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++ )  // i++ e edno i syshto kato i=i+1
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}, ", i);
            }
            else
            {
                Console.Write("{0}, ",-i);
            }
        }
    }
}

