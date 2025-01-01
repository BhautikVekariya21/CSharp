using System;

// Demonstrates the boolean data type in C#
class BooleanDataType
{
    static void Main()
    {
        bool isRaining = true;
        bool isSunny = false;

        Console.WriteLine("Is it raining? " + isRaining);
        Console.WriteLine("Is it sunny? " + isSunny);

        // Boolean logic
        Console.WriteLine("Is it either raining or sunny? " + (isRaining || isSunny));
        Console.WriteLine("Is it both raining and sunny? " + (isRaining && isSunny));
    }
}