using IceTaskOne;

string Name;
int Marks;
byte NumberOfStudents;

    Student student = new Student(); 
    Dictionary<string, int> students = new Dictionary<string, int>();

    Console.WriteLine("ENTER NUMBER OF STUDENTS:");
    NumberOfStudents = Convert.ToByte(Console.ReadLine());

    //VALIDATE NUMBER OF STUDENTS TO BE ADDED
    while (NumberOfStudents <1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ADD ATLEAST ONE STUDENT!!");
        Console.WriteLine("ENTER NUMBER OF STUDENTS:");
        Console.ResetColor();

        NumberOfStudents = Convert.ToByte(Console.ReadLine());
    }


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------------------------------");
    Console.WriteLine("STUDENT DETAILS");
    Console.WriteLine("------------------------------");
    Console.ResetColor();

    //ADD STUDENTS X NumberOfStudents
    for (int i = 0; i < NumberOfStudents; i++)
    {


        //PROMPT NAME
        Console.Write("NAME     :   ");
        Name = Console.ReadLine().ToUpper();

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

    }

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------------------------");
Console.ResetColor();

//RETURN ALL STUDENTS
Console.ForegroundColor = ConsoleColor.Green;  
student.GetResults(students);

//PRINT AVARAGE
Console.WriteLine("..............................");
Console.WriteLine("AVARAGE  :   " + student.GetAvarage(NumberOfStudents));
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------------------------");
Console.ResetColor();
