using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buycandy
{
    class Program
    {
        static void Main(string[] args)
        {
            int exchange = 0, candy = 0, count = 0 , buy = 0 ;
            Console.WriteLine("請輸入包裝紙兌換糖果的數字 : ");
            bool result = int.TryParse(Console.ReadLine(),out exchange);
            Console.WriteLine("請輸入買多少糖果 : ");
            bool result2 = int.TryParse(Console.ReadLine(), out candy);
            while (candy > 0)
            {
                if (count == exchange)
                {
                    candy--;
                    count = 1;
                }
                else
                {
                    candy--;
                    count++;
                    buy++;
                }
            }
            Console.WriteLine("一共要買:"+buy+"次");
            Console.ReadLine();
        }
    }
}
