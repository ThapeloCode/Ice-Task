

using IceTaskOne;

string Name;
int Marks;
byte NumberOfStudents;

Student student = new Student(); 
Dictionary<string, int> students = new Dictionary<string, int>();

Console.WriteLine("ENTER NUMBER OF STUDENTS:");
NumberOfStudents = Convert.ToByte(Console.ReadLine());

while (NumberOfStudents <1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ADD ATLEAST ONE STUDENT!!");
    Console.WriteLine("ENTER NUMBER OF STUDENTS:");
    Console.ResetColor();

    NumberOfStudents = Convert.ToByte(Console.ReadLine());
}



    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("------------------------------");
    Console.WriteLine("STUDENT DETAILS");
    Console.WriteLine("------------------------------");
    Console.ResetColor();

    //ADD STUDENTS X NumberOfStudents
    for (int i = 0; i < NumberOfStudents; i++)
    {


        //PROMPT NAME
        Console.Write("NAME     :   ");
        Name = Console.ReadLine();

        while (Name == "" || String.IsNullOrEmpty(Name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NAME CANNOT BE NULL!!");
            Console.ResetColor();

            Console.Write("NAME     :   ");
            Name = Console.ReadLine();
        }

        //PROMPT MARKS
        Console.Write("MARKS    :   ");
        Marks = Convert.ToInt32(Console.ReadLine());

        while (Marks == null || Int32.IsNegative(Marks))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MARKS CANNOT BE NULL OR NEGATIVE!!");
            Console.ResetColor();

            Console.Write("MARKS    :   ");
            Marks = Convert.ToInt32(Console.ReadLine());

        }
        //ADD STUDENT TO DICTIONARY
        student = new Student(Name, Marks); 
        students.Add(student.GetName(), student.GetMarks());

    }
    

//RETURN ALL STUDENTS
student.GetResults(students);
