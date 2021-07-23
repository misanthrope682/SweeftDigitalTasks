using System;

namespace exercise3
{
    class Program
    {

        static bool checkIsAP(int[] arr, int n)
        {
            if (n == 1)
                return true;


            Array.Sort(arr);


            int d = arr[1] - arr[0];
            for (int i = 2; i < n; i++)
                if (arr[i] - arr[i - 1] != d)
                    return false;

            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 13, 14, 16, 18 };
            int n = arr.Length;

            if (checkIsAP(arr, n))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
