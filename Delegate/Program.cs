using System;
using System.Net;

class Program
{

    //delegate declaration
    public delegate int Calculator(int a, int b);


    //1st method
    static int Add(int a, int b)
    {
        return a + b;
    }
    
    //2nd method
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Calculate(int x, int y, Calculator operation)
    {
        int result = operation(x, y);
        Console.WriteLine($"Result: {result}");
    }

    static void Main()
    {
        Calculator calc = Add;
        Console.WriteLine(calc(10, 5));

        Calculate(10, 5, Add);
        Calculate(10, 5, Multiply);
    }
}