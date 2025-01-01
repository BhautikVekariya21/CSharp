using System;

// Demonstrates converting strings to numbers
class StringToNumber
{
    static void Main()
    {
        string numberString = "123";

        // Convert string to integer
        int number = int.Parse(numberString);
        Console.WriteLine("String to Integer: " + number);

        // Try converting with TryParse
        if (int.TryParse(numberString, out int result))
        {
            Console.WriteLine("Successfully parsed: " + result);
        }
        else
        {
            Console.WriteLine("Failed to parse string.");
        }
    }
}
