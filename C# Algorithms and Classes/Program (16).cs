using System;

namespace RecursionHomework4
{
    class Program
    {
        static bool IsProgression(int[] arr, int Index, int Temp)
        {
            if (Index == arr.Length - 2)
            {
                return (Temp == (arr[Index + 1] - arr[Index]));
            }
            
            if (Temp != arr[Index + 1] - arr[Index] && Index != 0)
            {
                return false;
            }
            Temp = arr[Index + 1] - arr[Index];
            return IsProgression(arr, Index + 1, Temp);
           
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 4, 8, 12, 16 };
            Console.WriteLine(IsProgression(arr, 0, 0));
        }
    }
}
