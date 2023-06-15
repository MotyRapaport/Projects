using System;

namespace ConsoleApp13
{
    interface Ifly
    {
        void Fly();
    }
    class FlyBehavior: Ifly
    {
        public void Fly()
        {
            Console.WriteLine("I fly!");
        }
    }
    class NoFlyBehavior : Ifly
    {
        public void Fly()
        {
            Console.WriteLine("I  can't fly!");
        }
    }
    class Bird : Ifly
    {
        private Ifly FlyBehavior { get; set; }
        public void Fly()
        {
            FlyBehavior.Fly();
        }
    }
    class Parent
    {
        protected static int year;
        protected string Name;
        private string LastName;
        protected double x;
        public string GetLastName()
        {
            return LastName;
        }
        public Parent(string Name, double x)
        {
            this.Name = Name;
            this.x = x;
        }
        public Parent(double x, string Name, string LastName)
        {
            this.x = x;
            this.Name = Name;
            this.LastName = LastName;
        }
        protected int Method()
        {
            return 0;
        }
        public virtual double Calculate(double d)
        {
            return 0;
        }
        public virtual void Print()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child: Parent
    {
        private int y;
        public Child(string name, double x) : base(name, x)
        {
            this.y = 10;
            Console.WriteLine(this.x);
        }
        public Child(int y): base(6.5, "david", "cohen")
        {
            this.y = y;
        }
        public int Sum()
        {
            Console.WriteLine(this.Name + " " + this.GetLastName());
            return this.y + this.Method();
        }
        public override double Calculate(double d)
        {
            return d * base.Calculate(5.2);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Child");
        }
        public int GetYear()
        {
            return Parent.year;
        }
    }
    class Program
    {
        
        public static void Output(Object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Parent p = (Parent)arr[i];
                p.Print();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parent p = new Parent("Moshe", 5);
            Child c = new Child(5);
            Object[] arr = { p, c };
            Output(arr);
        }
    }
}
