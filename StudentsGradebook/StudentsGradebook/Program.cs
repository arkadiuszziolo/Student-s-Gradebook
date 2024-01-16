using StudentsGradebook;
using static StudentsGradebook.IStudent;

Console.WriteLine("Welcome in Student Gradebook console application!");
Console.WriteLine();

bool CloseApp = false;

while (!CloseApp)
{
    Console.WriteLine("What you want to do:");
    Console.WriteLine("1 - write grade to file");
    Console.WriteLine("2 - write grade to memory");
    Console.WriteLine("X - close console application");

    char choiceUser = Console.ReadLine()[0];
    switch (choiceUser)
    {
        case '1':
            //AddGradeInFile();
            break;
        case '2':
            AddGradeInMemory();
            break;
        case 'X':
        case 'x':
            CloseApp = true;
            break;
        default:
            Console.WriteLine("Invalid input value! Choice between 1,2 and X");
            break;
    }
}
Console.WriteLine("Bye bye! Press any key to close console application");
void AddGradeInMemory()
{
    Console.WriteLine("Insert student first name: ");
    string firstName = Console.ReadLine();

    Console.WriteLine("Insert student last name: ");

    string lastName = Console.ReadLine();


    string studentClass = null;

    while (true)
    {
        Console.WriteLine("Insert student class: ");

        studentClass = Console.ReadLine().ToUpper();

        if (studentClass.Length != 2)
        {
            Console.WriteLine("Wrong Class!");
            continue;
        }
        else
        {
            break;
        }
    }
    var student = new StudentInMemory(firstName, lastName, studentClass);

    void StudentGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Successfully added grade");
    }

    while (true)
    {
        Console.WriteLine("Enter next Student grade or type 'Q' to get result student grades:");
        var input = Console.ReadLine().ToUpper();
        if (input == "Q")
        {
            break;
        }

        try
        {
          student.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    var result = student.GetGrades();
    Console.WriteLine($"Result grades student {student.FirstName} {student.LastName} {student.StudentClass}");
    Console.WriteLine($"Highest Grade: {result.Highest}");
    Console.WriteLine($"Lowest Grade: {result.Lowest}");
    Console.WriteLine($"Average Grade: {result.Average}");
    Console.WriteLine($"Number of grades earned: {result.CountGrades}");
    Console.WriteLine($"All your grades: {result.PrintAllEarnedGrades}");
    Console.WriteLine("");
}

//void AddGradeInFile()
//{
//    Console.WriteLine("Insert student first name: ");
//    string firstName = Console.ReadLine();

//    Console.WriteLine("Insert student last name: ");

//    string lastName = Console.ReadLine();

//    Console.WriteLine("Insert student class: ");

//    string studentClass = Console.ReadLine();

//    //var student = new StudentInFile(firstName, lastName, studentClass);
//}




