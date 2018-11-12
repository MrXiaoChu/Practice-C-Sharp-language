using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAryRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[,] score = { { 80, 75, 60},
            {65, 67, 62 },
            {100, 93, 91 },
            {98, 25, 50 },
            {83, 82, 87 }};
            int no;
            Console.Write("\n輸入座號(1-5): ");
            no = int.Parse(Console.ReadLine());
            if (no >= 1 && no <= 5)
            {
                Console.WriteLine("\n1.姓    名:{0}", name[no - 1]);
                Console.WriteLine("\n2.電腦概論:{0}", score[no - 1, 0]);
                Console.WriteLine("\n3.程式設計:{0}", score[no - 1, 1]);
                Console.WriteLine("\n4.動畫設計:{0}", score[no - 1, 2]);
            }
            else
            {
                Console.WriteLine("... 座號超出範圍 ...");
            }
            Console.Read();
        }
    }
}
