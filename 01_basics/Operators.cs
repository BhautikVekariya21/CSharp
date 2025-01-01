using System;

// Demonstrates basic operators in C#
class Operators
{
    static void Main()
    {
        int a = 10;
        int b = 3;

        // Arithmetic operators
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Remainder: " + (a % b));

        // Relational operators
        Console.WriteLine("Is a equal to b? " + (a == b));
        Console.WriteLine("Is a not equal to b? " + (a != b));
        Console.WriteLine("Is a greater than b? " + (a > b));
        Console.WriteLine("Is a less than or equal to b? " + (a <= b));

        // Logical operators
        bool x = true;
        bool y = false;
        Console.WriteLine("Logical AND: " + (x && y));
        Console.WriteLine("Logical OR: " + (x || y));
        Console.WriteLine("Logical NOT: " + (!x));
    }
}
