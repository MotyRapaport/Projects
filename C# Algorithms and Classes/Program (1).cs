using System;

namespace ConsoleApp4
{
    class Program
    {
        static bool IsBalanced(int[] arr)
        {
            if (arr.Length % 2 == 0 || arr.Length < 3)
            {
                return false;
            }
            int middle = arr.Length / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    if (arr[i] < arr[middle])
                    {
                        return false;
                    }
                }
                else if (i > middle)
                {
                    if (arr[i] > arr[middle])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[]  arr ={ 22,56,123,12,10,-4,};
            Console.WriteLine(IsBalanced(arr));

         }
    }
}
