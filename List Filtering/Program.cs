using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Filtering
{
    class Program
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> filteredList = new List<int>();
            foreach (object item in listOfItems)
            {
                if (item is Int32)
                    filteredList.Add(Convert.ToInt32(item));
            }
            return filteredList;
        }

        static void Main(string[] args)
        {
            List<object> list1 = new List<object>() { 1, 2, "a", "b" };

            foreach(var item in GetIntegersFromList(list1))
            {
                Console.WriteLine(item);
            }
        }
    }
}
