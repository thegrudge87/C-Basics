using System;
class MagicStrings
{
    static void Main()
    {
        // input data 
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 's', 'n', 'k', 'p' };
        Array.Sort(letters);
        bool isMagicStrExist = false;

        // loop for the 1st letter of the sequence
        for (int ch1 = 0; ch1 < letters.Length; ch1++)
        {
            // loop for 2nd letter of the sequence
            for (int ch2 = 0; ch2 < letters.Length; ch2++)
            {
                // loop for 3th letter of the sequence
                for (int ch3 = 0; ch3 < letters.Length; ch3++)
                {
                    // loop for 4th letter of the sequence
                    for (int ch4 = 0; ch4 < letters.Length; ch4++)
                    {
                        // ::: IN THIS PART I'M GETTING THE VALUE OF LEFT 4 LETTERS :::
                        // must use empty string to show the compilator that we want to use concatination.
                        string firstFour = "" + letters[ch1] + letters[ch2] + letters[ch3] + letters[ch4];
                        int leftStrValue = 0;
                        foreach (var symbol in firstFour)
                        {
                            switch (symbol)
                            {
                                case 's':
                                    leftStrValue += 3;
                                    break;
                                case 'n':
                                    leftStrValue += 4;
                                    break;
                                case 'k':
                                    leftStrValue += 1;
                                    break;
                                case 'p':
                                    leftStrValue += 5;
                                    break;
                            }
                        }
                        // loop for 5th letter of the sequence
                        for (int ch5 = 0; ch5 < letters.Length; ch5++)
                        {
                            // loop for 6th letter of the sequence
                            for (int ch6 = 0; ch6 < letters.Length; ch6++)
                            {
                                // loop for 7th letter of the sequence
                                for (int ch7 = 0; ch7 < letters.Length; ch7++)
                                {
                                    // loop for 8th letter of the sequence
                                    for (int ch8 = 0; ch8 < letters.Length; ch8++)
                                    {
                                        string secondFour = "" + letters[ch5] + letters[ch6] + letters[ch7] + letters[ch8];
                                        int rightStrValue = 0;
                                        foreach (var symbol in secondFour)
                                        {
                                            switch (symbol)
                                            {
                                                case 's':
                                                    rightStrValue += 3;
                                                    break;
                                                case 'n':
                                                    rightStrValue += 4;
                                                    break;
                                                case 'k':
                                                    rightStrValue += 1;
                                                    break;
                                                case 'p':
                                                    rightStrValue += 5;
                                                    break;
                                            }
                                        }

                                        // ::: CHECK IS THE VALUES OF THE LEFT & RIGHT PARTS HAVE DIFFERENCE  = diff  :::
                                        if (Math.Abs(leftStrValue-rightStrValue)==diff)
                                        {
                                            Console.WriteLine(firstFour+secondFour);
                                            isMagicStrExist = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (isMagicStrExist == false)
        {
            Console.WriteLine("No");
        }
    }
}
