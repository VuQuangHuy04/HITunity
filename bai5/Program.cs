using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] DiemHS = new double[100];
            Console.Write("Nhap so luong hs: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem sv");
            for (int i = 0; i < n; i++)
            {
                DiemHS[i] = double.Parse(Console.ReadLine());
            }
            DiemTB(DiemHS, n);
            MaxandMin(DiemHS, n);
            PercentPass(DiemHS, n);
            PhanLoai(DiemHS, n);
        }
        static void DiemTB(double[] DiemHS, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += DiemHS[i];
            }
            Console.WriteLine("Trung binh lop: " + Math.Round(sum / n, 2));
        }
        static void MaxandMin(double[] DiemHS, int n)
        {
            double max = DiemHS[0];
            double min = DiemHS[0];
            for (int i = 1; i < n; i++)
            {
                if (max < DiemHS[i])
                {
                    max = DiemHS[i];
                }
                if (min > DiemHS[i])
                {
                    min = DiemHS[i];
                }
            }
            Console.WriteLine("Diem cao nhat: " + max);
            Console.WriteLine("Diem thap nhat: " + min);
        }
        static void PercentPass(double[] DiemHS, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (DiemHS[i] >= 5)
                {
                    count++;
                }
            }
            Console.WriteLine("Ty le hoc sinh dat: " + Math.Round((double)count/n*100,2) + " %");
        }
        static void PhanLoai(double[] DiemHS, int n)
        {
            int g = 0;
             int k = 0;
            int tb = 0;
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                if (DiemHS[i] >= 8 && DiemHS[i] <= 10)
                {
                    g++;
                }
                else if (DiemHS[i] >= 6.5)
                {
                    k++;
                }
                else if (DiemHS[i] >= 5)
                {
                    tb++;
                }
                else if (DiemHS[i] >= 0)
                {
                    y++;
                }
            }
            Console.WriteLine("Phan Loai: ");
            Console.WriteLine("Gioi: " + g);
            Console.WriteLine("Kha: " + k);
            Console.WriteLine("Trung binh: " + tb);
             Console.WriteLine("yeu: "+ y);
        }
    }
}
