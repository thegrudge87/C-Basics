using System;
class NumberAsWords
{
    // Method that converts digits from 1 to 9 to string and returns the string value.
    static string DigitToString(int Digit)
    {
        string outputString = "";
        switch (Digit)
        {
            case 1: outputString = outputString + "one"; break;
            case 2: outputString = outputString + "two"; break;
            case 3: outputString = outputString + "three"; break;
            case 4: outputString = outputString + "four"; break;
            case 5: outputString = outputString + "five"; break;
            case 6: outputString = outputString + "six"; break;
            case 7: outputString = outputString + "seven"; break;
            case 8: outputString = outputString + "eight"; break;
            case 9: outputString = outputString + "nine"; break;
            //case 10: outputString = outputString + "ten"; break;
        }
        return outputString;
    }

    // Method that converts numbers between 10 and 19 to string and returns the string value.
    static string From10TO19(int number)
    {
        string outputString = "";
        switch (number)
        {
            case 10: outputString = "ten"; break;
            case 11: outputString = "eleven"; break;
            case 12: outputString = "twelve"; break;
            case 13: outputString = "thirteen"; break;
            case 14: outputString = "fourteen"; break;
            case 15: outputString = "fifteen"; break;
            case 16: outputString = "sixteen"; break;
            case 17: outputString = "seventeen"; break;
            case 18: outputString = "eighteen"; break;
            case 19: outputString = "nineteen"; break;
        }
        return outputString;
    }

    // Method that converts tenths to string and returns the string value.
    static string TenthsDigitsToString(int number)
    {
        string outputString = "";
        switch (number)
        {
            case 2: outputString = "twenty"; break;
            case 3: outputString = "thirty"; break;
            case 4: outputString = "fourty"; break;
            case 5: outputString = "fifty"; break;
            case 6: outputString = "sixty"; break;
            case 7: outputString = "seventy"; break;
            case 8: outputString = "eighty"; break;
            case 9: outputString = "ninety"; break;
        }
        return outputString;
    }

    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());
        string result = "";

        // Check is the input number is between 0 and 999.
        if ((n < 0) || (1000 < n))
        {
            result = "Invalid input number";
        }
        else
        {
            int hundredsDigit = n / 100;
            int tensDigit = (n % 100) / 10;
            int tens = n % 100;
            int lastDigit = n % 10;

            // if the input number is 0 
            if (n == 0)
            {
                result = "zero";
            }
            // if the input number is greater than 99
            else if (hundredsDigit > 0)
            {
                // Check is the number is round like 100, 200....
                if (tens == 0)
                {
                    result = DigitToString(hundredsDigit) + " hundred";
                }
                // Check is the second digit is 0 - 104, 203, 602...
                else if (tens < 10)
                {
                    result = DigitToString(hundredsDigit) + " hundred and " + DigitToString(lastDigit);
                }
                // Check is the second digit is 2 - 624, 725, 921...
                else if ((10 <= tens) && (tens < 20))
                {
                    result = DigitToString(hundredsDigit) + " hundred and " + From10TO19(tens);
                }
                // After catching all other cases, second digit will be bigger than 2
                else
                {
                    result = DigitToString(hundredsDigit) + " hundred and " + TenthsDigitsToString(tensDigit)+ " " + DigitToString(lastDigit);
                }
            }
            // if the input number is between 10 and 19
            else if ((10 <= tens) && (tens < 20))
            {
                result = From10TO19(tens);
            }
            // if the input number is between 20 and 99
            else if (tens > 19)
            {
                result = TenthsDigitsToString(tensDigit)+ " " + DigitToString(lastDigit);
            }
            // if the input number is between 1 and 9
            else
            {
                result = DigitToString(lastDigit);
            }
        }
        // Format the final result to starts with capital letter.
        result = result.Substring(0, 1).ToUpper() + result.Substring(1);
        Console.WriteLine(result);
    }
}