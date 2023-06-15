using System;

namespace CardHomeWork
{
    class Card
    {
        int Number;
        string Color;
        int Shape;

        public Card(int number, int shape)
        {
            Number = number;
            Shape = shape;
            switch (Shape)
            {
                case 1:
                    Color = "Red";
                    break;
                case 2:
                    Color = "Red";
                    break;
                case 3:
                    Color = "Black";
                    break;
                case 4:
                    Color = "Black";
                    break;
            }
        }
        public Card(string color)
        {
            Number = 15;
            Shape = 5;
            Color = color;
        }
        public bool IsSame(Card other)
        {
            if ((other.Number == 15 || this.Number == 15) && other.Color == this.Color)
                return true;
            if (other.Number == this.Number && other.Color == this.Color)
                return true;

            return false;
           
        }

    }
    class Pack
    {
        Card[] cards;

        public Pack()
        {
            cards = new Card[54];
            for (int i = 2, k = 0; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++, k++)
                {
                    cards[k] = new Card(i, j);
                }
            }
            cards[52] = new Card("Black");
            cards[53] = new Card("Red");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
