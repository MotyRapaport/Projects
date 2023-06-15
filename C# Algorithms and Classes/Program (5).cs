using System;

namespace ConsoleApp3
{
    class Teacher
    {
        string Id;
        string Name;
        bool HaveDiploma;
        public string GetName()
        {
            return Name;
        }
        public bool GetHaveDiploma()
        {
            return HaveDiploma;
        }
        public Teacher(string Id, string Name, bool HaveDiploma)
        {
            this.Id = Id;
            this.Name = Name;
            this.HaveDiploma = HaveDiploma;
        }
        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + "Has Diploma? " + HaveDiploma;
        }
    }
    class School
    {
        string SchoolName;
        string Principle;
        Teacher[] SchoolTeachers;
        public Teacher[] GetSchoolTeachers()
        {
            return SchoolTeachers;
        }
        public string GetSchoolName()
        {
            return SchoolName;
        }
        public School(string schoolName, string principle, Teacher[] schoolTeachers, int NumOfTeachers)
        {
            SchoolName = schoolName;
            Principle = principle;
            SchoolTeachers = new Teacher[NumOfTeachers];
        }
        public override string ToString()
        {
            string ret = "";
            ret += "School Name: " + SchoolName + "\nPrinciple: " + Principle + "\n";
            ret += "Teachers: ";
            for (int i = 0; i < SchoolTeachers.Length; i++)
            {
                if (SchoolTeachers[i] != null)
                {
                    ret += SchoolTeachers[i] + "\n";
                }
            }
            return ret;
        }
    }
    class AllSchools
    {
        School[] Schools = new School[200];

        public AllSchools(School[] schools)
        {
            Schools = schools;
        }
        public override string ToString()
        {
            string ret = "Schools:";
            for (int i = 0; i < Schools.Length; i++)
            {
                if (Schools[i] != null)
                {
                    ret += Schools[i];
                }
            }
            return ret;
        }
        public void SchoolsOfTeacher(string Id)
        {
            for (int i = 0; i < Schools.Length; i++)
            {
                for (int j = 0; j < Schools[i].GetSchoolTeachers().Length; j++)
                {
                    if (Schools[i].GetSchoolTeachers()[j] != null)
                    {
                        if (Schools[i].GetSchoolTeachers()[j].GetName() == Id)
                        {
                            Console.WriteLine(Schools[i].GetSchoolTeachers()[j].GetName());
                        }
                    }
                }
            }
        }
        public string University()
        {
            int counter = 0;
            int index = 0;
            int max = -1;
            for (int i = 0; i < Schools.Length; i++)
            {
                for (int j = 0; j < Schools[i].GetSchoolTeachers().Length; j++)
                {
                    if (Schools[i].GetSchoolTeachers()[j] != null)
                    {
                        if (Schools[i].GetSchoolTeachers()[j].GetHaveDiploma())
                        {
                            counter++;
                        }
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    index = i;
                }
            }
            return Schools[index].GetSchoolName();

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
