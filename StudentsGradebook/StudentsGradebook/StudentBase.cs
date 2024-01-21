namespace StudentsGradebook
{
    public abstract class StudentBase : IStudent
    {
        public delegate void GradeAddedDalegate(object sender, EventArgs args);

        public abstract event GradeAddedDalegate GradeAdded;

        public StudentBase(string firstName, string lastName, string studentClass)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentClass = studentClass;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string StudentClass { get; private set; }

        public abstract void AddGrade(float grade);

        public void AddGrade(int grade)
        {
            float intToFloat = grade;
            this.AddGrade(intToFloat);
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "A":
                case "6":
                    this.AddGrade(6);
                    break;
                case "A-":
                case "-A":
                case "-6":
                case "6-":
                    this.AddGrade(5.75f);
                    break;
                case "B+":
                case "+B":
                case "+5":
                case "5+":
                    this.AddGrade(5.50f);
                    break;
                case "B":
                case "5":
                    this.AddGrade(5);
                    break;
                case "B-":
                case "-B":
                case "-5":
                case "5-":
                    this.AddGrade(4.75f);
                    break;
                case "C+":
                case "+C":
                case "+4":
                case "4+":
                    this.AddGrade(4.50f);
                    break;
                case "C":
                case "4":
                    this.AddGrade(4);
                    break;
                case "C-":
                case "-C":
                case "-4":
                case "4-":
                    this.AddGrade(3.75f);
                    break;
                case "D+":
                case "+D":
                case "+3":
                case "3+":
                    this.AddGrade(3.50f);
                    break;
                case "D":
                case "3":
                    this.AddGrade(3);
                    break;
                case "D-":
                case "-D":
                case "-3":
                case "3-":
                    this.AddGrade(2.75f);
                    break;
                case "E+":
                case "+E":
                case "+2":
                case "2+":
                    this.AddGrade(2.50f);
                    break;
                case "E":
                case "2":
                    this.AddGrade(2);
                    break;
                case "E-":
                case "-E":
                case "-2":
                case "2-":
                    this.AddGrade(1.75f);
                    break;
                case "F+":
                case "+F":
                case "+1":
                case "1+":
                    this.AddGrade(1.50f);
                    break;
                case "F":
                case "1":
                    this.AddGrade(1);
                    break;
                default:
                    Console.WriteLine($"Invalid String: {grade}");
                    break;
            }
        }

        public abstract void GetAllValuesFromList();

        public abstract Grades GetGrades();
    }
}
