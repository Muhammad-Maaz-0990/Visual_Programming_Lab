using System;

namespace Activity_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery = from num in numbers where (num%2)==0 select num;

            foreach (var num in numQuery)
            {
                Console.Write("{0,1}",num);
            }
        }
    };
}