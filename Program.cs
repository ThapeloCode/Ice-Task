using IceTaskOne;

string Name;
int Marks;
byte Option;
byte NumberOfStudents;

    Student student = new Student(); 
    Dictionary<string, int> students = new Dictionary<string, int>();


Menu();
Option = Convert.ToByte(Console.ReadLine());

Selector();

void Selector()
{


    if (Option >= 1 && Option <= 4)
    {

        if (Option == 1)
        {
            AddStudent();
        }
        else if (Option == 2)
        {
            student.GetResults(students);
        }
        else if (Option == 3)
        {
            Console.WriteLine("SEARCH");
            Console.WriteLine("STUDENT NAME: ");
            Name = Console.ReadLine();

            SearchStudent(Name);
        }
        else if (Option == 4)
        {

            Console.WriteLine("AVARAGE  :   " + student.GetAvarage(students.Count));
        }
        Menu();
        Option = Convert.ToByte(Console.ReadLine());
        Selector();

    }
    else if (Option > 4)
    {

        Selector();
    }
    else
    {
        Console.WriteLine("THANKS!");

    }

}
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("MENU");
    Console.WriteLine("1] ADD STUDENT");
    Console.WriteLine("2] DISPLAY ALL STUDENTS");
    Console.WriteLine("3] SEARCH STUDENT");
    Console.WriteLine("4] DISPLAY AVARAGE");
    Console.WriteLine("0] Exit");
}

void SearchStudent(string Name)
{
    if (students.ContainsKey(Name))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("STUDENT EXIST!");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("NOT FOUND!");
        Console.ResetColor();
    }
}

void AddStudent()
{
    //PROMPT NAME
    Console.Write("NAME     :   ");
    Name = Console.ReadLine().ToUpper().Trim();

    while (Name == "" || String.IsNullOrEmpty(Name))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("NAME CANNOT BE NULL!!");
        Console.ResetColor();

        Console.Write("NAME     :   ");
        Name = Console.ReadLine().ToUpper().Trim();
    }

    //PROMPT MARKS
    Console.Write("MARKS    :   ");
    Marks = Convert.ToInt32(Console.ReadLine());

    while (Marks < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("MARKS CANNOT BE NEGATIVE!!");
        Console.ResetColor();

        Console.Write("MARKS    :   ");

        Marks = Convert.ToInt32(Console.ReadLine());
    }

    //ADD STUDENT TO DICTIONARY
    student = new Student(Name, Marks);
    students.Add(student.GetName(), student.GetMarks());

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Added!");
    Console.ResetColor();

}
