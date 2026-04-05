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







    }
}
