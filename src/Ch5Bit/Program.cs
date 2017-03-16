using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Ch5Bit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Insertion(1024, 19, 2, 6);
            RealToBinary(0.625);
            Console.ReadKey();
        }

        static void Insertion(int n, int m, int i, int j)
        {
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(11, '0'));
            Console.WriteLine(Convert.ToString(m, 2).PadLeft(11, '0'));
            Console.WriteLine(Convert.ToString((m <<= i) | n, 2).PadLeft(11, '0'));
            
        }

        static int RealToBinary(double r)
        {
            if (r >= 1 || r <= 0)
            {
                Console.WriteLine("Invalid Number");
                return 0;
            }

            StringBuilder binStr = new StringBuilder();
            while(r > 0)
            {
                if (binStr.Length > 32)
                {
                    Console.WriteLine("Invalid Number");
                    return 0;
                }

                double t = r * 2;

                if (t >= 1)
                {
                    binStr.Append("1");
                    r = t - 1;
                }
                else
                {
                    binStr.Append("0");
                    r = t;
                }

                Console.WriteLine(r.ToString() + ":" + binStr.ToString());
            }

            return 1;
        }
    }
}
