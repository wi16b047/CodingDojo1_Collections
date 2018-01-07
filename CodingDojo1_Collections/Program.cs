using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
            //Output: D C B A

            Console.WriteLine();
            
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            
            Console.WriteLine();

            Console.WriteLine("Removing values: ");
            st.Pop();
            st.Pop();
            
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }

            Console.ReadKey();
        }
    }
}
