using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Harga Fotokopian");
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x + " Lembar = " + x * 80 + " Rupiah");
            }
            Console.ReadLine();
        }
    }
}
