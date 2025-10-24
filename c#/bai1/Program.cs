// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai1
{  class Program{
    static void Main (string[] args){
    Console.Write("nhap cac canh ");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
            if (a + b < c)
            {
                Console.WriteLine("is valid triangle");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("is a isosceles triangle");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("is a equilateral triangle");
            }
            else
            {
                Console.WriteLine("is a nomal triangle");
            }
}}}
