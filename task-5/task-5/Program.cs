using System;
using System.Linq;

namespace exercise4
{
    class Program
    {


        static void printMode(int[] a, int n)
        {
            int max = a.Max();


            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;


            for (int i = 0; i < n; i++)
                count[a[i]]++;


            int mode = 0;
            int k = count[0];
            for (int i = 1; i < t; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }

            Console.WriteLine("mode = " + mode);
        }

        // Driver Code
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 3, 2, 3, 1, 2, 3, 3, 6 };
            int n = a.Length;
            printMode(a, n);
        }
    }

}
