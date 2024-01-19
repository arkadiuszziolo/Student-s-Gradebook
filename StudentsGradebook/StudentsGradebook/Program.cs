using StudentsGradebook;
using static StudentsGradebook.IStudent;

Console.WriteLine("Welcome in Student Gradebook console application!\n");

bool CloseApp = false;

string firstName = null;
string lastName = null;
string studentClass = null;

while (!CloseApp)
{
    Console.WriteLine("What you want to do:");
    Console.WriteLine("1 - Write grade to file");
    Console.WriteLine("2 - Write grade to memory");
    Console.WriteLine("X - Close console application");

    try
    {
        Console.Write("Your choice: ");
        char choiceUser = Console.ReadLine()[0];
        switch (choiceUser)
        {
            case '1':
                AddGradeInFile();
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
    catch (Exception MessageException)
    {
        Console.WriteLine($"Invalid choice! > {MessageException.Message}");
    }
}
Console.WriteLine("Bye! Press any key to close console application");

void AddGradeInFile()
{
    while (true)
    {
        Console.Write("Insert student first name: ");
        firstName = Console.ReadLine().ToUpper();

        Console.Write("Insert student last name: ");
        lastName = Console.ReadLine().ToUpper();

        if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
        {
            break;
        }
        else
        {
            Console.WriteLine("First name or last name can't be empty!");
            continue;
        }
    }

    while (true)
    {
        Console.Write("Insert student class: ");

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
    var student = new StudentInFile(firstName, lastName, studentClass);
    student.GradeAdded += StudentGradeAdded;

    void StudentGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Successfully added grade!\n");
    }

    while (true)
    {
        Console.WriteLine("Enter next Student grade or type 'Q' to get result student grades:");
        Console.Write("Grade: ");
        var input = Console.ReadLine().ToUpper();
        if (input == "Q")
        {
            break;
        }

        try
        {
            student.AddGrade(input);
        }
        catch (Exception MessageException)
        {
            Console.WriteLine($"Exception catched: {MessageException.Message}");
        }
    }
    var result = student.GetGrades();
    Console.WriteLine("");
    Console.WriteLine($"Result grades student > First Name: {student.FirstName} Last Name: {student.LastName} Class: {student.StudentClass}");
    Console.WriteLine($"Highest Grade: {result.HighestGradeReturnAsString}");
    Console.WriteLine($"Lowest Grade: {result.LowestGradeReturnAsString}");
    Console.WriteLine($"Average Grade: {result.Average:N2} ({result.AverageReturnAsString})");
    Console.WriteLine($"Number of grades earned: {result.CountGrades}");
    Console.Write($"All of the student grades: ");
    student.GetAllValuesFromList();
    Console.WriteLine("\n");
}

void AddGradeInMemory()
{

    while (true)
    {
        Console.Write("Insert student first name: ");
        firstName = Console.ReadLine().ToUpper();

        Console.Write("Insert student last name: ");
        lastName = Console.ReadLine().ToUpper();

        if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
        {
            break;
        }
        else
        {
            Console.WriteLine("First name or last name can't be empty!");
            continue;
        }
    }

    while (true)
    {
        Console.Write("Insert student class: ");

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
    student.GradeAdded += StudentGradeAdded;

    void StudentGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Successfully added grade!\n");
    }

    while (true)
    {
        Console.WriteLine("Enter next Student grade or type 'Q' to get result student grades:");
        Console.Write("Grade: ");
        var input = Console.ReadLine().ToUpper();
        if (input == "Q")
        {
            break;
        }

        try
        {
            student.AddGrade(input);
        }
        catch (Exception MessageException)
        {
            Console.WriteLine($"Exception catched: {MessageException.Message}");
        }
    }
    var result = student.GetGrades();
    Console.WriteLine("");
    Console.WriteLine($"Result grades student > First Name: {student.FirstName} Last Name: {student.LastName} Class: {student.StudentClass}");
    Console.WriteLine($"Highest Grade: {result.HighestGradeReturnAsString}");
    Console.WriteLine($"Lowest Grade: {result.LowestGradeReturnAsString}");
    Console.WriteLine($"Average Grade: {result.Average:N2} ({result.AverageReturnAsString})");
    Console.WriteLine($"Number of grades earned: {result.CountGrades}");
    Console.Write($"All of the student grades: ");
    student.GetAllValuesFromList();
    Console.WriteLine("\n");
}




