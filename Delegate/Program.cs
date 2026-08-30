using System;

class Program
{
    // Create delegate
    delegate void MyDelegate();

    // First method
    static void Hello()
    {
        Console.WriteLine("Hello");
    }

    // Second method
    static void Welcome()
    {
        Console.WriteLine("Welcome");
    }

    static void Main()
    {
        // Create delegate and add methods
        MyDelegate d = Hello;
        d += Welcome;

        // Call delegate
        d();
    }
}