namespace StudentsGradebook
{
    public class Grades
    {
        public float Highest { get; private set; }

        public float Lowest { get; private set; }

        public float Sum { get; private set; }

        public int CountGrades { get; private set; }

        public float Average {
            get
            {
                return this.Sum / this.CountGrades;
            }
        }

        public float PrintAllEarnedGrades { get; private set; }

        public Grades()
        {
            this.Highest = float.MinValue;
            this.Lowest = float.MaxValue;
            this.CountGrades = 0;
            this.Sum = 0;
        }

        public void AddGrade(float grade)
        {
            this.CountGrades++;
            this.Sum += grade;
            this.Highest = Math.Max(grade, this.Highest);
            this.Lowest = Math.Min(grade, this.Lowest); 
        }
    }
}
