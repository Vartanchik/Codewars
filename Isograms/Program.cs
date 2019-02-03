using System;

namespace Isograms
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            bool isIsogram = true;
            string givenString = str.ToUpper();
            char[] charArray = givenString.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (charArray[i] == charArray[j])
                        isIsogram = false;
                }
            }
            return isIsogram;
        }

        static void Main()
        {
            string str1 = "aabscct";
            string str2 = "absct";
            string str3 = "abscat";
            Console.WriteLine(IsIsogram(str1));
            Console.WriteLine(IsIsogram(str2));
            Console.WriteLine(IsIsogram(str3));
        }
    }
}
