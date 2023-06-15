using System;

namespace Gift4UHomeWork
{
    class Gift
    {
        int Code;
        double Price;
        char type;
        public int GetCode() { return Code; }
        public double GetPrice() { return Price; }
        public char Gettype() { return type; }
        public void Settype(char set)
        {
            if (set == 'M')
                type = 'M';
            else if (set == 'F')
                type = 'F';
            else if (set == 'U')
                type = 'U';
            else if (set == 'K')
                type = 'K';
        }
        public bool IsForMan()
        {
            if (type == 'M' || type == 'U')
            {
                return true;
            }
            return false;
        }
        
        public Gift(int code, double price, char type)
        {
            Code = code;
            Price = price;
            this.type = type;
        }

    }
    class Program
    {
        static void ThreeGifts(Gift[] arr, double sum)
        {
            bool Flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] != null && arr[j] != null && arr[k] != null)
                        {
                            if (arr[i].IsForMan() && arr[j].IsForMan() && arr[k].IsForMan())
                            {
                                if (arr[i].GetCode() != arr[j].GetCode() && arr[i].GetCode() != arr[k].GetCode() && arr[j].GetCode() != arr[k].GetCode())
                                {
                                    if (arr[i].GetPrice() + arr[j].GetPrice() + arr[k].GetPrice() == sum)
                                    {
                                        Console.WriteLine(arr[i].GetCode() + "" + arr[j].GetCode() + "" + arr[k].GetCode());
                                        Flag = true;
                                    }
                                }
                            }
                           
                        }
                    }
                }
            }
            if (Flag == false)
                Console.WriteLine("No Gifts Found");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gift Computer1 = new Gift(123, 5, 'M');
            Gift Computer2 = new Gift(124, 5, 'M');
            Gift Computer3 = new Gift(125, 5, 'M');
            Gift Computer4 = new Gift(126, 5, 'M');
            Gift Computer5 = new Gift(127, 5, 'M');
            Gift Computer6 = new Gift(128, 5, 'M');

        }
    }
}
