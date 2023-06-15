using System;

namespace CarHomeWork
{
    class Car
    {
        string License;
        string OwnerNum;
        char Status;
        double Cost;
        public string GetLicense()
        {
            return License;
        }
        public string GetOwnerNum()
        {
            return OwnerNum;
        }
        public char GetStatus()
        {
            return Status;
        }
        public void SetStatus(char Status)
        {
            this.Status = Status;
        }
        public double GetCost()
        {
            return Cost;
        }
        public Car(string License, string OwnerNum)
        {
            this.License = License;
            this.OwnerNum = OwnerNum;
            Status = 's';
            Cost = 0;
        }
        public void EndWork(double Cost)
        {
            if (Status == 'w')
            {
                Status = 'e';
                this.Cost = Cost;
            }
        }
    }
    class Program
    {
        static bool Result(Car[] arr, string License)
        {
            for (int i = 0; i < arr.Length; i++)
            {
               if (arr[i] != null)
                {
                    if (arr[i].GetLicense() == License)
                    {
                        if (arr[i].GetStatus() == 'e')
                        {
                            Console.WriteLine(arr[i].GetCost());
                            return true;
                        }
                        else
                        {
                            Console.WriteLine(arr[i].GetStatus());
                            return false;
                        }
                    }
                }
               
            }
            Console.WriteLine("Car not found!!");
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car[] arr = new Car[3];
            arr[0] = new Car("123", "789");
            arr[0].SetStatus('w');
            arr[0].EndWork(25);
            arr[1] = new Car("124", "678");
            Console.WriteLine(Result(arr, "123"));
        }
    }
}
