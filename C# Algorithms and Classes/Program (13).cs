using System;

namespace ConsoleApp7
{
    class Program
    {
        static bool IsGood(int[] arr)
        {
            int Biggest = arr[0], Smallest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Biggest)
                {
                    Biggest = arr[i];
                }
                if (arr[i] < Smallest)
                {
                    Smallest = arr[i];
                }
            }

            for (int i = 0; Smallest < Biggest; i++)
            {
                Smallest++;
                int check = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == Smallest)
                    {
                        check++;
                    }

                }
                if (check > 1 || check < 1)
                {
                    return false;
                }
            }
            return true;
        }
        static bool Oleh(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                temp++;
                if (arr[i] != temp)
                {
                    return false;
                }
               
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 23, 24, 25, 26, 27, 28, 29, 30};
            Console.WriteLine(Oleh(arr));
        }
    }
}
