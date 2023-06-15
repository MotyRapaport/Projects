using System;

namespace Tor_Taylor2
{
    class Program
    {
        static double Exponent(double x, int y)
        {
            if (y == 0)
                return 1;
            return Exponent(x, y - 1) * x;
        }

        static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            return Factorial(n - 1) * n;
        }
        static double SumT(int num, double x)
        {
            int Operator = 1;
            double sum = 0;
            for (int i = 0, j = 1; i < num; i++, j += 2)
            {
                double temp = Exponent(x, j) / Factorial(j);
                temp *= Operator;
                sum += temp;
                Operator *= -1;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine(Exponent(2, 3) + " " + "exponent");
            Console.WriteLine(Factorial(4));
            Console.WriteLine(SumT(30, Math.PI / 2));
        }
    }
}
