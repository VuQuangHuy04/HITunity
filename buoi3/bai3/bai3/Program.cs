using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
namespace bai3.homework
{
    class Program
    {
        struct Product
        {
            public string Name;
            public double Price;
            public int Quantity;
            public string Category;

            public Product(string Name, double Price, int Quantity, string Category)
            {
                this.Name = Name;
                this.Price = Price;
                this.Quantity = Quantity;
                this.Category = Category;
            }


            public override string? ToString()
            {
                return " " + Name + " " + Price + " " + Quantity + " " + Category;
            }
            
            public double tinh()
            {
                return this.Price * this.Quantity;
            }
        }
            static void Main(string[] args)
            {
                Dictionary<string, Product> dic = new Dictionary<string, Product>();
            while (true)
            {
                Console.WriteLine("----------MENU-------------");
                Console.WriteLine("1. Thêm / Cập nhật sản phẩm");
                Console.WriteLine("2. Xem thông tin sản phẩm theo mã");
                Console.WriteLine("3. Sản phẩm bán chạy nhất (theo SL)");
                Console.WriteLine("4. Sản phẩm bán chạy nhất theo từng danh mục");
                Console.WriteLine("5. Tổng doanh thu theo từng danh mục");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ADD(dic); break;
                    case "2": Infor(dic); break;
                    case "3": BestSellerQuantity(dic); break;
                    case "4": BestSellerofCategory(dic); break;
                    case "5": SUMSellerofCategory(dic); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
            }
            static void ADD(Dictionary<string, Product> dic) {
                char choice = 'N';
                do {
                    Console.WriteLine("Nhap ma sp");
                    string maSP = Console.ReadLine();
                    Console.WriteLine("Nhap ten sp");
                    string name = Console.ReadLine();
                    Console.WriteLine("Nhap gia sp");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so luong sp");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap danh muc sp");
                    string category = Console.ReadLine();
                    Product product = new Product(name, price, quantity, category);
                    if (dic.ContainsKey(maSP))
                    {   Product exits = dic[maSP];
                        exits.Quantity += quantity;
                        dic[maSP] = exits;
                    }
                    else
                    {
                        dic[maSP] = product;
                    }
                        Console.WriteLine("Muon them du lieu Y/N ");
                    choice = char.Parse(Console.ReadLine());;
                } while (choice.Equals('Y'));
            }
        static void Infor(Dictionary<string, Product> dic)
        {
            Console.WriteLine("Nhap ma sp");
            string maSP = Console.ReadLine();
            foreach (KeyValuePair<string,Product> m in dic)
            {
                if (m.Key.Equals(maSP))
                {
                    Console.WriteLine("Ma sp "+ m.Key +" "+ m.Value.ToString());
                    return;
                }
            }
            Console.WriteLine("Khong tim thay ma san pham!");
        }
        static void BestSellerQuantity(Dictionary<string, Product> dic)
        { 
            int max = 0;
            foreach(KeyValuePair<string , Product> p in dic)
            {   if(p.Value.Quantity > max)
                {
                    max = p.Value.Quantity;
                }
            }
            foreach (KeyValuePair<string, Product> p in dic)
            {
                if (p.Value.Quantity == max)
                {
                  Console.WriteLine("Thông tin sản phẩm bán chạy nhất" + p.Value.ToString());
                }
            }
        }
        static void BestSellerofCategory(Dictionary<string, Product> dic)
        {
            Dictionary<string, Product> best = new Dictionary<string, Product>();

            foreach (var item in dic)
            {
                string category = item.Value.Category;
                Product current = item.Value;
                if (!best.ContainsKey(category))
                {
                    best[category] = current;
                }
                else
                {
                    if (current.Quantity > best[category].Quantity)
                    {
                        best[category] = current;
                    }
                }
            }
            Console.WriteLine("Sản phẩm bán chạy nhất theo từng danh mục");
            foreach (var item in best)
            {
                Product p = item.Value;
                Console.WriteLine($"Danh mục: " + item.Key + "Tên:" + p.Name +" SL bán:" +p.Quantity +" Doanh thu: " + p.Price * p.Quantity);
            }

        }
        static void SUMSellerofCategory(Dictionary<string, Product> dic)
        {
            Dictionary<string, double> sum = new Dictionary<string, double>();

            foreach (var item in dic)
            {
                string category = item.Value.Category;
                double money = item.Value.Quantity*item.Value.Price;
                if (!sum.ContainsKey(category))
                {
                   sum[category] = money;
                }
                else
                {
                    sum[category] += money;
                }
            }
            Console.WriteLine("Tổng doanh thu theo từng danh mục ");
            foreach (var item in sum)
            {
                Console.WriteLine("Danh mục: " + item.Key+ " Tổng doanh thu:" + item.Value);
            }
        }
        }
    }
