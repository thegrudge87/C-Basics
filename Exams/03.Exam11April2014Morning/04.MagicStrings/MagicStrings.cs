using System;
class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = {'s', 'n', 'k', 'p'};
        Array.Sort(letters);
        bool isMagic = false;

        for (int lt1 = 0; lt1 < letters.Length; lt1++)
        {
            for (int lt2 = 0; lt2 < letters.Length; lt2++)
            {
                for (int lt3 = 0; lt3 < letters.Length; lt3++)
                {
                    for (int lt4 = 0; lt4 < letters.Length; lt4++)
                    {
                        string frst4 = "" + letters[lt1] + letters[lt2] + letters[lt3] + letters[lt4];
                        int first4Val = 0;
                        foreach (var letter in frst4)
                        {
                            switch (letter)
                            {
                                case 's': first4Val += 3; break;
                                case 'n': first4Val += 4; break;
                                case 'k': first4Val += 1; break;
                                case 'p': first4Val += 5; break;
                            }
                        }

                        for (int lt5 = 0; lt5 < letters.Length; lt5++)
                        {
                            for (int lt6 = 0; lt6 < letters.Length; lt6++)
                            {
                                for (int lt7 = 0; lt7 < letters.Length; lt7++)
                                {
                                    for (int lt8 = 0; lt8 < letters.Length; lt8++)
                                    {
                                        string scnd4 = "" +letters[lt5] + letters[lt6] + letters[lt7] + letters[lt8];
                                        int scnd4Val = 0;
                                        foreach (var letter in scnd4)
                                        {
                                            switch (letter)
                                            {
                                                case 's': scnd4Val += 3; break;
                                                case 'n': scnd4Val += 4; break;
                                                case 'k': scnd4Val += 1; break;
                                                case 'p': scnd4Val += 5; break;
                                            }
                                        }

                                        if (Math.Abs(first4Val-scnd4Val) == diff)
                                        {
                                            Console.WriteLine(frst4+scnd4);
                                            isMagic = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (isMagic == false)
        {
            Console.WriteLine("No");
        }
    }
}