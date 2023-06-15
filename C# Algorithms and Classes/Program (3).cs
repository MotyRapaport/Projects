using System;

namespace ConsoleApp16
{
    class Advert
    {
        int Length;
        string Product;
        string Company;
        double Price;
        public double GetPrice()
        {
            return Price;
        }
        public int GetLength()
        {
            return Length;
        }
        public Advert(int length, string product, string company, double price)
        {
            Length = length;
            Product = product;
            Company = company;
            Price = price;
        }
    }
    class AdvertHour
    {
        Advert[] adverts; // Array of 15 possible advertisements
        int Hour;         // Hour of day
        int NoOfAddvert;  // counter
        public Advert[] GetAdverts()
        {
            return adverts;
        }
        public int FreeTime()
        {
            int Temp = 0;
            for (int i = 0; i < adverts.Length; i++)
            {
                if (adverts[i] != null)
                    Temp += adverts[i].GetLength();
            }
            return 5 * 60 - Temp;
        }
        public bool Ispossible(Advert adv)
        {
            if (adv.GetLength() <= FreeTime())
            {
                return true;
            }
            return false;
        }
        public bool AddAdvert(Advert adv)
        {
            if (Ispossible(adv))
            {
                adverts[NoOfAddvert] = adv;
                NoOfAddvert++;
                return true;
            }
            return false;
        }
        public AdvertHour()
        {
            adverts = new Advert[15];

        }
    }
    class ManageDay
    {
        DateTime date; // Date
        AdvertHour[] DayOfAdvert; // Array of 24 hours

        public ManageDay(DateTime date)
        {
            this.date = date;
            DayOfAdvert = new AdvertHour[24];
        }
        public double BenefitDay()
        {
            double Temp = 0;
            for (int i = 0; i < DayOfAdvert.Length; i++)
            {
                if (DayOfAdvert[i] != null)
                {
                    for (int j = 0; j < DayOfAdvert[i].GetAdverts().Length; j++)
                    {
                        if (DayOfAdvert[i].GetAdverts()[j] != null)
                            Temp += DayOfAdvert[i].GetAdverts()[j].GetPrice();
                    }
                }

            }
            return Temp;
        }
        public bool AddHour(AdvertHour a1)
        {
            for (int i = 0; i < DayOfAdvert.Length; i++)
            {
                if (DayOfAdvert[i] == null)
                {
                    DayOfAdvert[i] = a1;
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Advert a1 = new Advert(120, "Creams", "EasyNurse", 100);
            Advert a2 = new Advert(120, "Creams", "EasyNurse", 100);
            Advert a3 = new Advert(61, "Creams", "EasyNurse", 100);
            AdvertHour advertHour = new AdvertHour();
            advertHour.AddAdvert(a1);
            advertHour.AddAdvert(a2);
            advertHour.AddAdvert(a3);
            ManageDay manageDay = new ManageDay(new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            manageDay.AddHour(advertHour);
            Console.WriteLine(manageDay.BenefitDay());
        }
    }
}
