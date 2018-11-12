using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDynamicAry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data;
            string str1 = "";
            int size;
            Console.Write("\n 輸入陣列大小:");
            size = int.Parse(Console.ReadLine());
            if (size >= 1 && size <= 9)
            {
                data = new int[size];
                int i;
                for (i = 0; i < data.Length; i++)
                {
                    data[i] = 111 * (i + 1);
                }
                i = 0;
                foreach (int num in data)
                {
                    str1 += "\n data[" + i.ToString() + "] = " + num.ToString() + "\n";
                    i++;
                }
                Console.WriteLine("{0}", str1);
            }
            else
            {
                Console.WriteLine("陣列大小範圍限 1~9");
            }
            Console.Read();
        }
    }
}
