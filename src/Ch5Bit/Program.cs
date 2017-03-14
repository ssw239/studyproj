using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch5Bit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Insertion(1024, 76, 1, 1);
            Console.ReadKey();
        }

        static void Insertion (int n, int m, int i, int j)
        {
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(11, '0'));
            Console.WriteLine(Convert.ToString(m, 2).PadLeft(11, '0'));
        }
    }
}
