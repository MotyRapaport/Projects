using System;

namespace StringHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Please enter string");
            string str2 = Console.ReadLine();
            string Print = "";
            if (str1.Length > str2.Length)
            {
                Print = str1;
            }
            else
            {
                Print = str2;
            }
            Console.WriteLine("Please enter how much to jump");
            int j = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Print.Length; i+=j)
            {
                string substr = Print.Substring(0, i);
                Console.WriteLine(substr);
            }

        }
    }
}
