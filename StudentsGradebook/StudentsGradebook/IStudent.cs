using static StudentsGradebook.StudentBase;

namespace StudentsGradebook
{
    public interface IStudent
    {
        public interface IStudent
        {
            string FirstName { get; }

            string LastName { get; }

            string StudentClass { get; }

            void AddGrade(float grade);

            void AddGrade(int grade);

            void AddGrade(char grade);

            void AddGrade(string grade);

            void GetAllValuesFromList();

            event GradeAddedDalegate GradeAdded;

            Grades GetGrades();
        }
    }
}
