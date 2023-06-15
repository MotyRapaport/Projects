using System;

namespace TimeHomeWork
{
    class Time
    {
        int Hour;
        int Minute;
        public int GetHour()
        {
            return Hour;
        }
        public int GetMinute()
        {
            return Minute;
        }
        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
        public bool Before(Time other)
        {
            if (Hour > other.Hour)
            {
                return false;
            }
            if (Hour == other.Hour)
            {
                if (Minute >= other.Minute)
                {
                    return false;
                }
            }
            return true;
        }
        public Time AddFiveMinutes()
        {
            int _hour = 0;
            int _minute = 0;
            if (Minute <= 54)
            {
                _minute = this.Minute + 5;
                _hour = Hour;
            }
            else
            {
                _minute = this.Minute + 5 - 60;
                if (Hour < 23)
                {
                    _hour = Hour + 1;
                }
                else
                {
                    _hour = 0;
                }
            }
            return new Time(_hour, _minute);
        }
    }
    class Message
    {
        string Sender;
        int Subject;
        string Content;
        Time ReceivingTime;
        bool HasAttachment;
        public string GetSender() { return Sender; }
        public int GetSubject() { return Subject; }
        public string GetContent() { return Content; }
        public Time GetReceivingTime() { return ReceivingTime; }
        public bool GetHasAttachment() { return HasAttachment; }

        public Message(string sender, int subject, string content, Time receivingTime, bool hasAttachment)
        {
            Sender = sender;
            Subject = subject;
            Content = content;
            ReceivingTime = receivingTime;
            HasAttachment = hasAttachment;
        }
        public Message Reply(string text)
        {
            string sender = "support@uni.ac.il";
            int subject = Subject - Subject - Subject;
            string content = Content + " " + text;
            Time t1 = ReceivingTime.AddFiveMinutes();
            bool hasAttachment = false;
            return new Message(sender, subject, content, t1, hasAttachment);
        }
    }
    class Mailbox
    {
        Message[] Inbox;
        int NoOFMes;
        public Mailbox(int num)
        {
            Inbox = new Message[num];
            NoOFMes = 0;
        }
        public int HowManyBetween(Time First, Time Last)
        {
            int temp = 0;
            for (int i = 0; i < Inbox.Length; i++)
            {
                if (Inbox[i] != null && First.Before(Inbox[i].GetReceivingTime()) && Inbox[i].GetReceivingTime().Before(Last))
                    temp++;
            }
            return temp;
        }
        public int MostPopularSubject()
        {
            int[] arrtmp = new int[12];
            for (int i = 0; i < Inbox.Length; i++)
            {
                if (Inbox[i] != null)
                {
                    arrtmp[Inbox[i].GetSubject() - 1]++;
                }
            }
            int temp = 0;
            for (int i = 1; i < arrtmp.Length; i++)
            {
                if (arrtmp[i] > arrtmp[temp])
                {
                    temp = i;
                }
            }
            return temp+1;
        }
        public void SetInbox(Message m1)
        {
            for (int i = 0; i < Inbox.Length; i++)
            {
                if (Inbox[i] == null)
                {
                    Inbox[i] = m1;
                    break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(13, 00);
            Time t3 = new Time(13, 01);
            Message m1 = new Message("rapmordechai@gmail.com", 12, "Didn't understand", t3, true);
            Message m2 = m1.Reply("Yes you can!");
            Message m3 = new Message("@gmail.com", 11, "", t3, true);
            Message m4 = new Message("", 10, "", t3, false);
            Time t2 = new Time(14, 00);
            Mailbox e1 = new Mailbox(3);
            e1.SetInbox(m1);
            e1.SetInbox(m4);
            e1.SetInbox(m3);
            int check = e1.HowManyBetween(t1, t2);
            Console.WriteLine(e1.MostPopularSubject());

        }
    }
}
