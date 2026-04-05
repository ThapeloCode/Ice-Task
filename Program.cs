

using IceTaskOne;

string Name;
int Marks;
byte NumberOfStudents;

Student student; 
Dictionary<string, int> students = new Dictionary<string, int>();

Console.Write("NUMBER OF STUDENTS:");

Console.Write("STUDENT DETAILS");
//PROMPT NAME
Console.WriteLine("NAME     :   ");
Name = Console.ReadLine();

//PROMPT MARKS
Console.WriteLine("MARKS    :   ");
Marks = Convert.ToInt32(Console.ReadLine());

//ADD STUDENT TO DICTIONARY
student = new Student(Name, Marks);
students.Add(student.GetName(), student.GetMarks());
