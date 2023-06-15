using System;

namespace ConsoleApp3
{
   abstract class TvProgram
    {
        static int Counter = 0;
        int Id;
        string PName;
        protected bool Local;
        double Cost;
        public virtual double GetCost()
        {
            return Cost;
        }
        public TvProgram(string pName, bool local, double cost)
        {
            Id = ++Counter;
            PName = pName;
            Local = local;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"Program name: {PName}, Is local: {Local}, Cost is: {Cost}";
        }
    }
    class Documentary : TvProgram
    {
        string PTopic;
        int Length;

        public Documentary(string pName, bool local, string pTopic, int length):base( pName,  local,  12)
        {
            PTopic = pTopic;
            Length = length;
        }
        public override double GetCost()
        {
            double Extra = Length % 30 != 0 ? base.GetCost() : 0;
            return (Length / 30) * base.GetCost() + Extra;
        }
        public override string ToString()
        {
            return base.ToString() + $"Program topic: {PTopic}, Length: {Length}";
        }
    }
    class Series : TvProgram
    {
        int Year;
        int Episodes;

        public Series(string pName, bool local, int year, int episodes):base( pName,  local,  25)
        {
            Year = year;
            Episodes = episodes;

        }
        public override double GetCost()
        {
            double ret = Episodes * base.GetCost();
            if (!Local)
                return ret * 1.1;
            return ret;
        }
        public override string ToString()
        {
            return base.ToString() + $"Year: {Year}, Num of episodes: {Episodes}";
        }
    }
    class Programs
    {
       TvProgram[] ListOfPrograms;
        public TvProgram MostExpensive()
        {
            int index = -1;
            double max = -1;
            for (int i = 0; i < ListOfPrograms.Length; i++)
            {
                if (ListOfPrograms[i] is Documentary && ListOfPrograms[i].GetCost() > max)
                {
                    index = i;
                    max = ListOfPrograms[i].GetCost();
                }
            }
            if (index >= 0)
                 return ListOfPrograms[index];
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Documentary d1 = new Documentary("eeg", true, "drama", 61);
            Series s1 = new Series("Bible", false, 2019, 3);
            Console.WriteLine(d1);
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetCost());
            Console.WriteLine(d1.GetCost());
        }
    }
}
