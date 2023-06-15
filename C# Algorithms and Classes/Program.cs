using System;

namespace ConsoleApp3
{
    class Program
    {
        static int SchumSfarot(int num)
        {
            int tmp = 0;
            while (num > 0)
            {
                tmp += num % 10;
                num /= 10;
            }
            return tmp;
        }
        static int RamatKirvah(int[] arr, int num)
        {
            int tmp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (SchumSfarot(num) == SchumSfarot(arr[i]))
                {
                    tmp++;
                }
            }
            return tmp;
        }
        static int TowArrays(int[] arr1, int[] arr2)
        {
            int tmp = -1, Index = -1;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (RamatKirvah(arr2, arr1[i]) > tmp)
                {
                    tmp = RamatKirvah(arr2, arr1[i]);
                    Index = i;
                }
            }
            return Index;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
