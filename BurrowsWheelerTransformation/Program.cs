using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurrowsWheelerTransformation
{
    class Program
    {
        public static string SumbvolRightShift(string s)
        {
            char[] inputArray = s.ToCharArray();
            string outputString = "";
            outputString += inputArray[s.Length - 1];
            for (int i = 0; i < s.Length - 1; i++)
            {
                outputString += inputArray[i];
            }
            return outputString;
        }

        public static Tuple<string, int> Encode(string s)
        {
            if(String.IsNullOrEmpty(s))
                return new Tuple<string, int>(s, 0);
            string outputString = "";
            int outputIndex = 0;
            string[] array = new string[s.Length];
            array[0] = s;
            for (int i = 1; i < s.Length; i++)
            {
                array[i] = SumbvolRightShift(array[i - 1]);
            }
            Array.Sort(array, StringComparer.Ordinal);
            for (int i = 0; i < s.Length; i++)
            {
                outputString += array[i].ElementAt(s.Length - 1);
                if (array[i] == s)
                    outputIndex = i;
            }
            return new Tuple<string, int>(outputString, outputIndex);
        }

        public static string Decode(string s, int i)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            string[] column = new string[s.Length];
            string[] matrix = new string[s.Length];
            for(int j = 0; j < s.Length; j++)
            {
                column[j] = Convert.ToString(s.ElementAt(j));
                matrix[j] = Convert.ToString(s.ElementAt(j));
            }
            for(int k = 0; k < s.Length - 1; k++)
            {
                Array.Sort(matrix, StringComparer.Ordinal);
                for(int l = 0; l < s.Length; l++)
                {
                    matrix[l] = matrix[l].Insert(0, column[l]);
                }
            }
            Array.Sort(matrix, StringComparer.Ordinal);
            return matrix[i];
        }

        static void Main(string[] args)
        {
            string s = "Andddlad";
            Console.WriteLine(s);

            Console.WriteLine(new string('-', 30));

            var encode = Encode(s);
            Console.WriteLine(encode.Item1);
            Console.WriteLine(encode.Item2);

            Console.WriteLine(new string('-', 30));

            var decode = Decode(encode.Item1, encode.Item2);
            Console.WriteLine(decode);

            Console.WriteLine(new string('-', 30));
            if(decode == s)
                Console.WriteLine("True!");
            else
                Console.WriteLine("False!");
        }
    }
}
