using System;

namespace Petek
{
    class Petek
    {
       private char PartyChar;
       private string PartyName;
        public Petek(char PartyChar, string PartyName)
        {
            this.PartyChar = PartyChar;
            this.PartyName = PartyName;
        }
        public char GetPartyChar()
        {
            return PartyChar;
        }
        public string GetPartyName()
        {
            return PartyName;
        }
        public void SetPartyChar(char PartyChar)
        {
            this.PartyChar = PartyChar;
        }
        public void SetPartyName(string PartyName)
        {
            this.PartyName = PartyName;
        }
    }
    class BallotBox
    {
        private int KalpiName;
        private Petek[] PetekArray;

        public BallotBox(int kalpiName)
        {
            KalpiName = kalpiName;
            PetekArray = new Petek[100];
        }
        public Petek[] GetPetekArray()
        {
            return PetekArray;
        }
        public bool AddPetek(Petek p)
        {
            for (int i = 0; i < PetekArray.Length; i++)
            {
                if (PetekArray[i] == null)
                {
                    PetekArray[i] = p;

                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static int[] HowManyVotes(BallotBox b) // returns array[0] = 'A', array[1] = 'B', array[2] = 'L', array[3] = 'Y'
        {
            int[] ret = new int[4];
            for (int i = 0; i < b.GetPetekArray().Length; i++)
            {
                if (b.GetPetekArray()[i] != null)
                {
                    if (b.GetPetekArray()[i].GetPartyChar() == 'A')
                    {
                        ret[0]++;
                    }
                    else if (b.GetPetekArray()[i].GetPartyChar() == 'B')
                    {
                        ret[1]++;
                    }
                    else if (b.GetPetekArray()[i].GetPartyChar() == 'L')
                    {
                        ret[2]++;
                    }
                    else if (b.GetPetekArray()[i].GetPartyChar() == 'Y')
                    {
                        ret[3]++;
                    }
                }
            }
            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Petek p1 = new Petek('A', "Likud");
            Petek p2 = new Petek('B', "Likud");
            BallotBox b1 = new BallotBox(123);
            b1.AddPetek(p1);
            b1.AddPetek(p2);
            int[] check = HowManyVotes(b1);
            for (int i = 0; i < check.Length; i++)
            {
                Console.WriteLine(check[i]);
            }
        }
    }
}
