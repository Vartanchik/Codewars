using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution
{
    class Kata
    {
        public static bool ValidatePin(string pin)
        {
            bool isValiadPin = false;
            const string pattern = @"^[0-9]+$";
            var regex = new Regex(pattern);

            if (!regex.IsMatch(pin))
                return isValiadPin;
            else if (pin.Length == 4 || pin.Length == 6)
                return isValiadPin = true;
            else
                return isValiadPin;
        }

        static void Main(string[] args)
        {
            string str = "123 ";
            string str1 = "1245";
            string str2 = "13s5";
            string str3 = "-12345";
            string str4 = "123435";
            Console.WriteLine(ValidatePin(str));
            Console.WriteLine(ValidatePin(str1));
            Console.WriteLine(ValidatePin(str2));
            Console.WriteLine(ValidatePin(str3));
            Console.WriteLine(ValidatePin(str4));
            SolutionTest test = new SolutionTest();
        }
    }
}
