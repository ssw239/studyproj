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
            // RealToBinary(0.625);
            FlipToWin(17753);
            Console.ReadKey();
        }

        // 5.3
        static void FlipToWin(int n)
        {
            StringBuilder s = new StringBuilder();
            string bstr = Convert.ToString(n, 2);
            char[] ba = bstr.ToArray();
            Console.WriteLine(Convert.ToString(n, 2));
            int idx1 = 0;
            bool flipped = false;
            int len1 = 0;
            int len2 = 0;
            int fOnes = 0;
            for(int i = 0; i < ba.Length; i++)
            {
                Console.WriteLine(ba[i]);
                if (ba[i] == '1')
                {
                    len1 += 1;
                    if (flipped)
                    {
                        fOnes += 1;
                    }
                }
                else if (ba[i] == '0')
                {
                    if (! flipped)
                    {
                        len1 += 1;
                        flipped = true;
                    }
                    else if (flipped)
                    {
                        if (len1 > len2)
                        {
                            len2 = len1;
                        }
                        len1 = fOnes + 1;
                        fOnes = 0;
                    }
                }
            }

            if (len1 > len2)
            {
                len2 = len1;
            }
            Console.WriteLine("result:" + len1);
            Console.WriteLine("result:" + len2);
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
            binStr.Append(".");
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
