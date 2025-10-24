using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi ban dau: ");
            String frist_string = Console.ReadLine();
            Console.Write("Nhap chuoi can tim: ");
            String find_string = Console.ReadLine();
            Console.Write("Nhap chuoi can chen: ");
            String insert_string = Console.ReadLine();
            int index = -1;
            for (int i = 0; i < frist_string.Length - find_string.Length; i++)
            {
                string sub = frist_string.Substring(i, find_string.Length);
                int a = String.Compare(find_string, sub);
                if (a == 0)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                String new_string = frist_string.Insert(index, insert_string + " ");
                Console.WriteLine("Chuoi da duoc chen: " + new_string);
            }
            else
            {
                Console.WriteLine("khong tim thay chuoi de ghep");
            }
        }
    }
    
}
