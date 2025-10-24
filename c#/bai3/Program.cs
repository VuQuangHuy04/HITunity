using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = n -i-1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i + 1; k++)
                {
                    Console.Write(k);
                }
                for (int  l = i ; l >=1 ; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }
    }
}
