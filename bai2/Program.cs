using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Chon dien tich can tinh");
                Console.WriteLine("1.Hinh tron");
                Console.WriteLine("2.Hinh chu nhat");
                Console.WriteLine("3.Hinh tam giac");
                Console.Write("Nhap lua chon cua ban ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Console.Write("Nhap r");
                        double r = double.Parse(Console.ReadLine());
                        Console.Write("dien tinh hình tron" + Math.Round(3.14 * r * r, 3));
                        break;
                    case "2":
                        Console.Write("Nhap chieu dai");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Nhap chieu rong");
                        double y = double.Parse(Console.ReadLine());
                        Console.Write("dien tinh hình chu nhat" + Math.Round(x * y, 3));
                        break;
                    case "3":
                        Console.Write("Nhap canh a");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Nhap canh b");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Nhap canh c");
                        double c = double.Parse(Console.ReadLine());
                        double p = (a + b + c) / 2;
                        Console.Write("dien tich hinh tam giac" + Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p * c))));
                        break;
                }
            } while (true);
        }
     }
}