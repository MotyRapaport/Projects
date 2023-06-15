using System;

namespace Question_9_B
{
    class Payment
    {
        double Sum; // סכום התשלום
        public double GetSum() { return Sum; }
        public Payment(double Sum)
        {
            this.Sum = Sum;
        }

    }
    class Cash : Payment
    {
        public Cash(double Sum) : base(Sum)
        {

        }
    }
    class Credit : Payment
    {
        string CardNum; // מספר כרטיס האשראי
        DateTime Expiration; // תוקף כרטיס
        DateTime ChargeDate; // תאריך החיוב
        public string GetCardNum()
        {
            return CardNum;
        }
        public Credit(double sum, string cardNum, DateTime expiration, DateTime chargeDate) : base(sum)
        {
            CardNum = cardNum;
            Expiration = expiration;
            ChargeDate = chargeDate;
        }
    }
    class Cheque : Payment
    {
        string ChequeNum; // מספר צ'ק
        string BankName; // שם הבנק
        DateTime ChequeDate; // תאריך הצ'ק

        public Cheque(double Sum, string chequeNum, string bankName, DateTime chequeDate) : base(Sum)
        {
            ChequeNum = chequeNum;
            BankName = bankName;
            ChequeDate = chequeDate;
        }
    }
    class Buy
    {
        DateTime DateOfSale; // תאריך הרכישה
        double TotalSum; // סכום התשלום
        Payment[] PayingMethods; // פירוט אמצעי התשלום
        int NumOfPayingMeth; // מספר אמצעי התשלום
        public Payment[] GetPayingMethods()
        {
            return PayingMethods;
        }

        public Buy(DateTime dateOfSale, double totalsum, int numOfPayingMeth)
        {
            DateOfSale = dateOfSale;
            TotalSum = totalsum;
            PayingMethods = new Payment[numOfPayingMeth];
            NumOfPayingMeth = numOfPayingMeth;
        }
        public void Init(Payment p)
        {
            for (int i = 0; i < NumOfPayingMeth; i++)
            {
                if (PayingMethods[i] == null)
                {
                    PayingMethods[i] = p;
                    break;
                }
            }
        }

        public bool Check()
        {
            double CheckTotal = 0;
            for (int i = 0; i < NumOfPayingMeth; i++)
            {
                CheckTotal += PayingMethods[i].GetSum();
            }
            return CheckTotal == TotalSum;
        }
        public override string ToString()
        {
            return "Date of Sale: " + DateOfSale + " Total sum is: " + TotalSum;
        }

    }
    class Store
    {
        Buy[] buy; // כל הקניות
        int NumOfSales; // מספר הקניות

       public Store()
        {
            buy = new Buy[30];
        }
        public bool AddSale(Buy b)
        {
            if (NumOfSales < buy.Length)
            {
                buy[NumOfSales] = b;
                NumOfSales++;
                return true;
            }
            return false;
        }
        public void Print(string CreditNUm)
        {
            for (int i = 0; i < NumOfSales; i++)
            {
                if (buy[i] != null)
                {
                    for (int j = 0; j < buy[i].GetPayingMethods().Length; j++)
                    {
                        if (buy[i].GetPayingMethods()[j] is Credit)
                        {
                            Credit credit = (Credit)buy[i].GetPayingMethods()[j];
                            if (credit.GetCardNum() == CreditNUm)
                            {
                                Console.WriteLine(buy[i]);
                            }
                        }
                    }
                }
            }
        }
        public int CachPayments()
        {
            int num = 0;
            for (int i = 0; i < NumOfSales; i++)
            {
                bool Check = false;
                for (int j = 0; j < buy[i].GetPayingMethods().Length; j++)
                {
                    if (buy[i].GetPayingMethods()[j] is Credit || buy[i].GetPayingMethods()[j] is Cheque)
                    {
                        Check = true; 
                    }
                }
                if (!Check)
                {
                    num++;
                }
            }
            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cash cash1 = new Cash(250);
            Credit credit1 = new Credit(250, "1111", new DateTime(2022, 04, 1), new DateTime(2030, 1,1));
            Credit credit2 = new Credit(250, "1111", new DateTime(2022, 04, 1), new DateTime(2030, 1, 1));
            Credit credit3 = new Credit(250, "1111", new DateTime(2022, 04, 1), new DateTime(2030, 1, 1));
            Buy sale1 = new Buy(new DateTime(2022, 04, 01), 1000, 4);
            sale1.Init(cash1);
            sale1.Init(credit1);
            sale1.Init(credit2);
            sale1.Init(credit3);
            sale1.Check();
            Store s1 = new Store();
            s1.AddSale(sale1);
            s1.Print("1111");
           
            Buy sale2 = new Buy(new DateTime(2022, 04, 01), 1000, 4);
            Cash cash2 = new Cash(250);
            Cash cash3 = new Cash(250);
            Cash cash4 = new Cash(250);
            Cash cash5 = new Cash(250);
            sale2.Init(cash5);
            sale2.Init(cash4);
            sale2.Init(cash3);
            sale2.Init(cash2);
            s1.AddSale(sale2);
            Console.WriteLine(s1.CachPayments());



        }
    }
}
