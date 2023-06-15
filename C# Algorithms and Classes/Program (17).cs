using System;

namespace ConsoleApp11
{
    class Necklace
    {
        int Red;
        int Yellow;
        int Green;
        public int GetRed()
        {
            return Red;
        }
        public int GetYellow()
        {
            return Yellow;
        }
        public int GetGreen()
        {
            return Green;
        }
        public Necklace(int Red, int Yellow, int Green)
        {
            this.Red = Red;
            this.Yellow = Yellow;
            this.Green = Green;
        }
        public int WhatType()
        {
            if (Green > 0 && Yellow == 0 && Red == 0 || Green == 0 && Yellow > 0 && Red == 0 || Green == 0 && Yellow == 0 && Red > 0)
                return 1;
            if (Green == Red && Red == Yellow)
                return 2;
            if (Green > 0 && Yellow > 0 && Red == 0 || Green > 0 && Yellow == 0 && Red > 0 || Green == 0 && Yellow > 0 && Red > 0)
                return 3;
            else
            {
                return 4;
            }
        }
       
    }
    class Program
    {
        static int NumBoard(Necklace[] arr, int num)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].WhatType() == 3 && (arr[i].GetGreen() + arr[i].GetRed() + arr[i].GetYellow()) > num)
                    sum++;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Necklace[] arr = new Necklace[2];
            arr[0] = new Necklace(3, 3, 0);
            Console.WriteLine(arr[0].WhatType());
            arr[1] = new Necklace(4, 0, 4);
            Console.WriteLine(NumBoard(arr, 5));
        }
    }
}
