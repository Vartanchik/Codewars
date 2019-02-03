using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquaredDivisors
{
    class Program
    {
        public static long SumOfSquares(long num)
        {
            List<long> divisors = new List<long>();
            long sumOfSquares = 0;
            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    divisors.Add(i);
                }
            }
            for(int i = 0; i < divisors.Count; i++)
            {
                sumOfSquares = sumOfSquares + divisors[i] * divisors[i];
            }
            foreach(var item in divisors)
            {
                sumOfSquares = sumOfSquares + item * item;
            }

            return sumOfSquares;
        }

        public static string listSquared(long m, long n)
        {
            string result = $"[";
            for(long i = m; i <= n; i++)
            {
                long sumOfSquares = SumOfSquares(i);
                if (Math.Sqrt(sumOfSquares) % 1 == 0)
                    result += $"[{i}, {sumOfSquares}], ";
            }
            return result.TrimEnd(new char[] { ',', ' ' }) + "]";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(listSquared(2, 5));
        }
    }
}
