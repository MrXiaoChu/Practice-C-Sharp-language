using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConForAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int start_num;
            int end_num;
            int step_num;
            int i;
            int sum = 0;

            Console.Write("請輸入初值(整數): ");
            start_num = int.Parse(Console.ReadLine());
            Console.Write("請輸入終值(整數): ");
            end_num = int.Parse(Console.ReadLine());
            Console.Write("請輸入增值(整數): ");
            step_num = int.Parse(Console.ReadLine());

            for (i = start_num; i <= end_num; i += step_num)
            {
                sum += i;
            }
            Console.Write("初值 {0} 到 終值 {1} 增值為 {2} 時，總和為{3}",
                start_num,
                end_num,
                step_num,
                sum);
            Console.Read();
        }
    }
}
