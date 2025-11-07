using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace buoi4
{
    class Program
    { static private List<CONGNHAN> DSCN = new List<CONGNHAN>();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("-------MENU----------");
                Console.WriteLine("=====================");
                Console.WriteLine("1.Them cong nhan ");
                Console.WriteLine("2.Hien thi danh sach cong nhan");
                Console.WriteLine("3.Sap xep danh sach cong nhan");
                Console.WriteLine("4.Tim cong nhan theo ma");
                Console.Write("nhap lua chon: ");
                switch (Console.ReadLine())
                {
                    case "1": Add(); break;
                    case "2": Output(); break;
                    case "3": Sort(); break;
                    case "4": Finding(); break;
                    default:
                        break;
                }
            } while (true);
        }
        static private void Add()
        {
            while (true) {
                Console.Write("Nhap ma cong nhan "); string id = Console.ReadLine();
                Console.Write("Nhap chuc vu: \n 1. Truong nhom \n 2. Pho nhom \n 3. Cong nhan bac 3 \n 4. Cong nhan bac 2 \n 5. Cong nhan bac 1 \n");
                ChucVu cv = (ChucVu)(int.Parse(Console.ReadLine())-1);
                foreach (var item in DSCN) {
                    if (item.maCongNhan.Equals(id))
                    {
                        Console.WriteLine("is exist !");
                        break;
                    }
                }
                Console.Write("Nhap ten "); string name = Console.ReadLine();
                int age;
                do
                {
                    Console.Write("nhap tuoi "); age = int.Parse(Console.ReadLine());
                } while (age < 0);
                Console.Write("Nhap address "); string address = Console.ReadLine();
                CONGNHAN x = new CONGNHAN(id, cv, name, age, address);
                DSCN.Add(x);
                Console.WriteLine("Nhap tiep : Y/N");
                string option = Console.ReadLine();
                if (option.Equals("N"))
                {
                    break;
                }
            }
        }
        static private void Output()
        {
            foreach (var item in DSCN)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static private void Sort()
        {
            DSCN.Sort((a, b) =>
            {
                int kq = a.Name.CompareTo(b.Name);
                if (kq == 0)
                {
                    return a.TinhLuong().CompareTo(b.TinhLuong());
                }
                return kq;
            });
            Output();
        }

        static private void Finding()
        { Console.Write("Nhap ma can tim "); string id = Console.ReadLine();
            foreach (var item in DSCN)
            {
                if (item.maCongNhan.Equals(id))
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
     
    }
}

