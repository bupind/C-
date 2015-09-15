using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int Fibonacci(int n)
        {
            int a = 0, b = 1, c = 0;
            if (n == 0) return 0;
            if (n == 1) return 1;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int length = Convert.ToInt32(Console.ReadLine())+1;
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
