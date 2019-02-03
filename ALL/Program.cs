using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL
{
    class Program
    {
        public static bool ValidateSolution(int[][] board)
        {
            List<int> toCompare = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<int> comparebl = new List<int>();

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (board[i][j] == 0)
                        return false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    comparebl.Add(board[i][j]);
                comparebl.Sort();
                if (!comparebl.SequenceEqual(toCompare))
                    return false;
                comparebl = new List<int>();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    comparebl.Add(board[j][i]);
                comparebl.Sort();
                if (!comparebl.SequenceEqual(toCompare))
                    return false;
                comparebl = new List<int>();
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 0; i < 3; i++)
                for (int j = 3; j < 6; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 0; i < 3; i++)
                for (int j = 6; j < 9; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 3; i < 6; i++)
                for (int j = 0; j < 3; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 3; i < 6; i++)
                for (int j = 3; j < 6; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 3; i < 6; i++)
                for (int j = 6; j < 9; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 6; i < 9; i++)
                for (int j = 0; j < 3; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 6; i < 9; i++)
                for (int j = 3; j < 6; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;
            comparebl = new List<int>();

            for (int i = 6; i < 9; i++)
                for (int j = 6; j < 9; j++)
                    comparebl.Add(board[i][j]);
            comparebl.Sort();
            if (!comparebl.SequenceEqual(toCompare))
                return false;

            return true;
        }

        public static string formatDuration(int seconds)
        {
            int s = 0, m = 0, h = 0, d = 0, y = 0;
            List<string> list = new List<string>();
            string output = "";
            if (seconds >= 31536000)
            {
                y = (seconds - seconds % 31536000) / 31536000;
                d = (seconds % 31536000 - (seconds % 31536000) % 86400) / 86400;
                h = ((seconds % 31536000) % 86400 - ((seconds % 31536000) % 86400) % 3600) / 3600;
                m = (((seconds % 31536000) % 86400) % 3600 - (((seconds % 31536000) % 86400) % 3600) % 60) / 60;
                s = seconds - y * 31536000 - d * 86400 - h * 3600 - m * 60;
                if (y == 1)
                    list.Add($"{y} year");
                else if (y > 1)
                    list.Add($"{y} years");

                if (d == 1)
                    list.Add($"{d} day");
                else if (d > 1)
                    list.Add($"{d} days");

                if (h == 1)
                    list.Add($"{h} hour");
                else if (h > 1)
                    list.Add($"{h} hours");

                if (m == 1)
                    list.Add($"{m} minute");
                else if (m > 1)
                    list.Add($"{m} minutes");

                if (s == 1)
                    list.Add($"{s} second");
                else if (s > 1)
                    list.Add($"{s} seconds");

            }
            else if (seconds >= 86400)
            {
                d = (seconds - seconds % 86400) / 86400;
                h = (seconds % 86400 - (seconds % 86400) % 3600) / 3600;
                m = ((seconds % 86400) % 3600 - ((seconds % 86400) % 3600) % 60) / 60;
                s = seconds - d * 86400 - h * 3600 - m * 60;

                if (d == 1)
                    list.Add($"{d} day");
                else if (d > 1)
                    list.Add($"{d} days");

                if (h == 1)
                    list.Add($"{h} hour");
                else if (h > 1)
                    list.Add($"{h} hours");

                if (m == 1)
                    list.Add($"{m} minute");
                else if (m > 1)
                    list.Add($"{m} minutes");

                if (s == 1)
                    list.Add($"{s} second");
                else if (s > 1)
                    list.Add($"{s} seconds");
            }
            else if (seconds >= 3600)
            {
                h = (seconds - seconds % 3600) / 3600;
                m = (seconds % 3600 - (seconds % 3600) % 60) / 60;
                s = seconds - h * 3600 - m * 60;

                if (h == 1)
                    list.Add($"{h} hour");
                else if (h > 1)
                    list.Add($"{h} hours");

                if (m == 1)
                    list.Add($"{m} minute");
                else if (m > 1)
                    list.Add($"{m} minutes");

                if (s == 1)
                    list.Add($"{s} second");
                else if (s > 1)
                    list.Add($"{s} seconds");
            }
            else if (seconds >= 60)
            {
                m = (seconds - seconds % 60) / 60;
                s = seconds % 60;

                if (m == 1)
                    list.Add($"{m} minute");
                else if (m > 1)
                    list.Add($"{m} minutes");

                if (s == 1)
                    list.Add($"{s} second");
                else if (s > 1)
                    list.Add($"{s} seconds");

            }
            else if (seconds > 0)
            {
                s = seconds;

                if (s == 1)
                    list.Add($"{s} second");
                else if (s > 1)
                    list.Add($"{s} seconds");
            }
            else
            {
                return "now";
            }
            if (list.Count == 1)
                return list[0];
            else if (list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == list.Count - 2)
                        output += list[i] + " and ";
                    else if (i == list.Count - 1)
                        output += list[i];
                    else
                        output += list[i] + ", ";
                }

            }
            return output;
        }

        public static string GetReadableTime(int seconds)
        {
            int h = 0, m = 0, s = 0;

            if (seconds >= 3600)
            {
                h = (seconds - seconds % 36600) / 3600;
                m = (seconds % 3600 - (seconds % 3600) % 60) / 60;
                s = seconds - h * 3600 - m * 60;
            }
            else if (seconds >= 60)
            {
                m = (seconds - seconds % 60) / 60;
                s = seconds % 60;

            }
            else
            {
                s = seconds;
            }
            return $"{h:D2}:{m:D2}:{s:D2}";
        }

        public static int find_it(int[] seq)
        {
            int value = -1;
            foreach (var item in seq)
            {
                int counter = 0;
                for (int i = 0; i < seq.Length; i++)
                {
                    if (item == seq[i])
                        counter++;
                }
                if (counter % 2 != 0)
                    value = item;
            }
            return value;
        }

        public static bool IsValidWalk(string[] walk)
        {
            return walk.Length == 10
                && walk.Where(x => x == "w").Count() == walk.Where(x => x == "e").Count()
                && walk.Where(x => x == "n").Count() == walk.Where(x => x == "s").Count();
        }

        public static bool IsSquare(int n)
        {
            double result = Math.Sqrt(n);
            if (result % 1 == 0)
                return true;
            else
                return false;
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                foreach (var item in arr.Take(i))
                {
                    if (arr[i] == item)
                        count++;
                }
                if (count <= x)
                    list.Add(arr[i]);
            }

            return list.ToArray<int>();
        }

        public static int[] DDeleteNth(int[] arr, int x)
        {
            return arr.Where((t, i) => arr.Take(i + 1).Count(s => s == t) <= x).ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 20, 37, 31, 20, 53 };
            Console.WriteLine(arr.Contains(27));
            List<int> list1 = new List<int>() { 1, 2, 3, 9, 5, 6, 7, 8, 4 };

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list1.Sort();
            if(list1.SequenceEqual( list2))
                Console.WriteLine("True");
        }
    }
}
