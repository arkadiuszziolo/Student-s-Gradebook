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

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract void GetAllValuesFromList();

        public abstract Grades GetGrades();

    }
}
