using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int score1 = 0;
            int score2 = 0;

            Console.Write("請輸入操行成績: ");
            score1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入學科成績: ");
            score2 = int.Parse(Console.ReadLine());
            if (score1 >= 90)
            {
                if (score2 >= 95)
                {
                    Console.WriteLine("操行 {0} 分, 學科 {1} 分，獎學金5000元", score1, score2);
                }
                else
                {
                    if (score2 >= 90)
                    {
                        Console.WriteLine("操行 {0} 分，學科 {1} 分，獎學金2000元", score1, score2);
                    }
                    else
                    {
                        Console.WriteLine("操行 {0} 分，學科 {1} 分，未達申請條件", score1, score2);
                    }
                }
            }
            else
            {
                Console.WriteLine("操行 {0} 分，學科 {1} 分，未達申請條件", score1, score2);
            }

            Console.Read();
        }
    }
}
