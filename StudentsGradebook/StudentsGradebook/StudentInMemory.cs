namespace StudentsGradebook
{
    public class StudentInMemory : StudentBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddedDalegate GradeAdded;

        public StudentInMemory(string firstName, string lastName, string studentClass)
            : base(firstName, lastName, studentClass)
        {
        }



        public override void AddGrade(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"Invalid Grade: Grade {grade}, value must be between 1 to 6.");
            }
        }

        public override void GetAllValuesFromList()
        {
            foreach (var element in this.grades)
            {
                switch (element)
                {
                    case 6:
                        Console.Write("6; ");
                        break;
                    case 5.75f:
                        Console.Write("-6; ");
                        break;
                    case 5.50f:
                        Console.Write("+5; ");
                        break;
                    case 5:
                        Console.Write("5; ");
                        break;
                    case 4.75f:
                        Console.Write("-5; ");
                        break;
                    case 4.50f:
                        Console.Write("+4 ");
                        break;
                    case 4:
                        Console.Write("4; ");
                        break;
                    case 3.75f:
                        Console.Write("-4; ");
                        break;
                    case 3.50f:
                        Console.Write("+3; ");
                        break;
                    case 3:
                        Console.Write("3; ");
                        break;
                    case 2.75f:
                        Console.Write("-3; ");
                        break;
                    case 2.50f:
                        Console.Write("+2; ");
                        break;
                    case 2:
                        Console.Write("2; ");
                        break;
                    case 1.75f:
                        Console.Write("-2; ");
                        break;
                    case 1.50f:
                        Console.Write("+1; ");
                        break;
                    default:
                        Console.Write("1; ");
                        break;
                }
            }
        }

        public override Grades GetGrades()
        {
            var statistics = new Grades();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
