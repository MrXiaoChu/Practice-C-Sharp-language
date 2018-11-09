using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConReadAry1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "";
            int[] ary = new int[] { 111, 222, 333, 444, 555, 666 };
            Console.Write("\n\t\t\t    ary[0]    ary[1]    ary[2]    ary[3]    ary[4]    ary[5]\n");
            Console.Write("\n 1.原始陣列各陣列元素    :");
            foreach (int num in ary)
            {
                str1 += "\t" + num.ToString();
            }
            Console.WriteLine("{0}", str1);
            int temp;
            temp = ary[0];
            for (int i = 0; i <= ary.Length - 2; i++)
            {
                ary[i] = ary[i + 1];
            }
            ary[ary.Length - 1] = temp;
            str1 = "";
            Console.Write("\n2.陣列左移一個陣列元素    :");
            foreach (int num in ary)
            {
                str1 += "\t" + num.ToString();
            }
            Console.WriteLine("{0}", str1);
            Console.Write("\n3.陣列又移一個陣列元素    :");
            temp = ary[ary.Length - 1];
            for(int i = ary.Length - 1; i >= 1; i--)
            {
                ary[i] = ary[i - 1];
            }
            ary[0] = temp;
            str1 = "";
            foreach(int num in ary)
            {
                str1 += "\t" + num.ToString();
            }
            Console.WriteLine("{0}", str1);
            Console.Read();
        }
    }
}
