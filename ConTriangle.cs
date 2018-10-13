using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("1.請輸入三角形的第一個邊長:");
            a = int.Parse(Console.ReadLine());
            Console.Write("2.請輸入三角形的第二個邊長:");
            b = int.Parse(Console.ReadLine());
            Console.Write("3.請輸入三角形的第三個邊長:");
            c = int.Parse(Console.ReadLine());
            Console.Write("\n 經過判斷:");

            if (a > 0 && b > 0 && c > 0 && (a + b) > c && (b + c) > a && (a + c) > b)
            {
                if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                {
                    Console.WriteLine("1.{0} {1} {2} 可構成一個直角三角形", a, b, c);
                }
                else if ((a * a > b * b + c * c) || (b * b > a * a + c * c) || (c * c > a * a + b * b))
                {
                    Console.WriteLine("2.{0} {1} {2} 可構成一個鈍角三角形", a, b, c);
                }
                else if ((a * a) < (b * b + c * c) || (b * b) < (a * a + c * c) || (c * c) < (a * a + b * b))
                {
                    Console.WriteLine("3.{0} {1} {2} 可構成一個銳角三角形", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} 無法構成一個三角形", a, b, c);
                }
                Console.Read();
            }
        }
    }
}
