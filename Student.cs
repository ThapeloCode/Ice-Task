using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IceTaskOne
{


    internal class Student
    {
        private string Name;
        private int Marks;
        private int Total = 0;
        private int Avarage;

        private Dictionary<string, int> students;

        public Student()
        {
        }

        public Student(string Name, int Marks)
        { 
            this.Name = Name;
            this.Marks = Marks;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetMarks()
        { 
            return Marks;
        }

        public void GetResults(Dictionary<string, int> students)
        {
            foreach (var (Name, Marks) in students)
            {
                Total += Marks;
                Console.WriteLine("NAME     :   " + Name);
                Console.WriteLine("MARKS    :   " + Marks);
            }

        }

        public int GetAvarage(int NumberOfStudents) 
        {
            Avarage = Total/NumberOfStudents;
            return Avarage;
        }
            
    }
}
