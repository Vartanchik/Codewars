using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindEvenIndex
{
    class Program
    {
        public class Kata
        {
            public static int FindEvenIndex(int[] arr)
            {
                int index = -1;
                for(int i = 0; i < arr.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;

                    if (i != 0)
                        for(int j = 0; j < i; j++)
                            leftSum += arr[j];

                    if (i != arr.Length - 1)
                        for(int j = i + 1; j < arr.Length; j++)
                            rightSum += arr[j];

                    if (leftSum == rightSum)
                        if (index == -1)
                            index = i;
                        else if (index > i)
                            index = i;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 6, 1, 8, 8 };
            foreach(var item in arr.Take(5))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));
            foreach(var item in arr.Skip(6))
            {
                Console.WriteLine(item);
            }
        }
    }
}
