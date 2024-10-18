using System;
class Program
{
    static void Main(string[] args)
    {
        double a = 10, b = 0;
        double result = 0;
        try
        {
            result = safeDivision(a, b);
            Console.WriteLine($"{a} divided by {b} is {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Atempted Division by zero");
        }
    }

    private static double safeDivision(double m, double n)
    {
        if (n == 0)
        {
            throw new System.DivideByZeroException();
        }
        return m / n;
    }
}
