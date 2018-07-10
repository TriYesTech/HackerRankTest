using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace HackerRank
{
    class Program
    {

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] temp = new int[d];

            Array.Copy(a, 0, temp, 0, d);
            Array.Copy(a, d, a, 0, a.Length - d);
            Array.Copy(temp, 0, a, a.Length - d, d);

            return a;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] result = rotLeft(a, d);

            Console.Out.WriteLine(string.Join(" ", result));

            Console.In.ReadLine();

        }
    }



}

