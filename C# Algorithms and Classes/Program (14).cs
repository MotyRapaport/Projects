using System;

namespace ConsoleApp21
{
    public class Clothes
    {
        private string fabric; // סוג בד 
        private string color; // צבע
        public double price; // מחיר
        public double GetPrice() { return this.price; }
    }
    public class Shirt : Clothes
    {
        private string size; // (L, X,XL,XXL) מידה
    }
    public class Dress : Clothes
    {
        private double length; // אורך בסמ'
        private int size; // מידה
    }
    public class Book
    {
        private string name; // שם ספר
        private string author; // מחבר
        public double price; // מחיר
        public double GetPrice() { return 0.9 * this.price; }
    }
    public class Shipping
    {
        string Address;
       public Object[] arr; // כולם יורשים מאובג'קט, ורק ככה ניתן לגשת לכולם

        public Shipping(string address)
        {
            Address = address;
            this.arr =  new Object[10];
        }

        public double Sum()
        {
            double sum = 0;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    if(arr[i] is Clothes)
                    {
                      Clothes temp = (Clothes)arr[i];
                        sum += temp.GetPrice();
                    }
                    else if(arr[i] is Book)
                    {
                        Book temp = (Book)arr[i];
                        sum += temp.GetPrice();
                    }
                }
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shirt shirt = new Shirt();
            shirt.price = 30;
            Book book = new Book();
            book.price = 100;
            Shipping shipping = new Shipping("hello");
            shipping.arr[0] = shirt;
            shipping.arr[1] = book;
            Console.WriteLine(shipping.Sum());


        }
    }
}
