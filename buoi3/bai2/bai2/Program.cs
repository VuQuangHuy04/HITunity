using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai2.homework
{
    class programs
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> st = new Stack<char>();
            foreach(char c in str)
            {
                st.Push(c);
            }
            foreach (char c in str)
            {
                Console.Write(st.Pop());
            }
        }
    }
}
