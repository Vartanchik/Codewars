using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigIt
{
    class Program
    {
        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(z => z.Substring(1) + z[0] + "ay"));
        }

        static void Main(string[] args)
        {
        }
    }
}
