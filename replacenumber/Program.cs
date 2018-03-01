using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replacenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] n = new String[101];
            for (int i = 1; i <= 100; i++)
            {
                n[i] = i.ToString().Replace("3", "A").Replace("5", "B").Replace("9", "C").Replace("0", "D");
                Console.WriteLine(n[i]);
            }
            Console.ReadLine();
        }
    }
}
