using static StudentsGradebook.StudentBase;

namespace StudentsGradebook
{
    public interface IStudent
    {
        public interface IEmployee
        {
            string FirstName { get; }

            string LastName { get; }

            string StudentClass { get; }

            void AddGrade(float grade);

            void AddGrade(int grade);

            void AddGrade(char grade);

            void AddGrade(string grade);


            event GradeAddedDalegate GradeAdded;

            Grades GetGrades();
        }
    }
}
