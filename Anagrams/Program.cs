using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> output = new List<string>();
            List<char> compWord = word.ToList<char>();
            compWord.Sort();
            foreach(var item in words)
            {
                bool condition = false;
                List<char> temp = item.ToList<char>();
                temp.Sort();
                if(compWord.Count == temp.Count)
                {
                    condition = true;
                    for(int i = 0; i < compWord.Count; i++)
                    {
                        if (compWord[i] != temp[i])
                            condition = false;

                    }
                }
                if (condition)
                    output.Add(item);

            }
            return output;
        }

        static void Main(string[] args)
        {
        }
    }
}
