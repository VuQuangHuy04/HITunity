using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Bai1.Homework
{
    class Programs
    {
        static void Main(String[] args)
        {
            Stack<char> st = new Stack<char>();
            string str = Console.ReadLine();
            foreach (char c in str)
            {
                switch (c)
                {
                    case '(':
                        st.Push(c);
                        break;
                    case '[':
                        st.Push(c);
                        break;
                    case '{':
                        st.Push(c);
                        break;

                    case ')':
                        if (st.Count == 0 || st.Peek() != '(')
                        {
                            Console.WriteLine("No");
                            return;
                        }
                        st.Pop();
                        break;
                    case ']':
                        if (st.Count == 0 || st.Peek() != '[')
                        {
                            Console.WriteLine("No");
                            return;
                        }
                        st.Pop();
                        break;

                    case '}':
                        if (st.Count == 0 || st.Peek() != '{')
                        {
                            Console.WriteLine("No");
                            return;
                        }
                        st.Pop();
                        break;
                }
            }

            if (st.Count == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
        