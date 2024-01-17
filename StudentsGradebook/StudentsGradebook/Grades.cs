namespace StudentsGradebook
{
    public class Grades
    {
        public float HighestGrade { get; private set; }

        public string HighestGradeReturnAsString
        {
            get
            {
                switch (this.HighestGrade) 
                {
                    case var highest when highest == 6:
                        return "6";
                    case var highest when highest >= 5.75f:
                        return "6-";
                    case var highest when highest >= 5.50f:
                        return "5+";
                    case var highest when highest >= 5:
                        return "5";
                    case var highest when highest >= 4.75f:
                        return "-5";
                    case var highest when highest >= 4.50f:
                        return "4+";
                    case var highest when highest >= 4:
                        return "4";
                    case var highest when highest >= 3.75f:
                        return "-4";
                    case var highest when highest >= 3.50f:
                        return "3+";
                    case var highest when highest >= 3:
                        return "3";
                    case var highest when highest >= 2.75f:
                        return "-3";
                    case var highest when highest >= 2.50f:
                        return "2+";
                    case var highest when highest >= 2:
                        return "2";
                    case var highest when highest >= 1.75f:
                        return "-2";
                    case var highest when highest >= 1.50f:
                        return "+1";
                    default:
                        return "1";
                }
            }
        }

        public float LowestGrade { get; private set; }

        public string LowestGradeReturnAsString
        {
            get
            {
                switch (this.LowestGrade)
                {
                    case var lowest when lowest == 6:
                        return "6";
                    case var lowest when lowest >= 5.75:
                        return "6-";
                    case var lowest when lowest >= 5.50:
                        return "5+";
                    case var lowest when lowest >= 5:
                        return "5";
                    case var lowest when lowest >= 4.75:
                        return "-5";
                    case var lowest when lowest >= 4.50:
                        return "4+";
                    case var lowest when lowest >= 4:
                        return "4";
                    case var lowest when lowest >= 3.75:
                        return "-4";
                    case var lowest when lowest >= 3.50:
                        return "3+";
                    case var lowest when lowest >= 3:
                        return "3";
                    case var lowest when lowest >= 2.75:
                        return "-3";
                    case var lowest when lowest >= 2.50:
                        return "2+";
                    case var lowest when lowest >= 2:
                        return "2";
                    case var lowest when lowest >= 1.75:
                        return "-2";
                    case var lowest when lowest >= 1.50:
                        return "+1";
                    default:
                        return "1";
                }
            }
        }

        public float Sum { get; private set; }

        public int CountGrades { get; private set; }

        public float Average {
            get
            {
                return this.Sum / this.CountGrades;
            }
        }

        public string AverageReturnAsString
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average == 6:
                        return "6";
                    case var average when average >= 5.75f:
                        return "6-";
                    case var average when average >= 5.50f:
                        return "5+";
                    case var average when average >= 5:
                        return "5";
                    case var average when average >= 4.75f:
                        return "-5";
                    case var average when average >= 4.50f:
                        return "4+";
                    case var average when average >= 4:
                        return "4";
                    case var average when average >= 3.75f:
                        return "-4";
                    case var average when average >= 3.50f:
                        return "3+";
                    case var average when average >= 3:
                        return "3";
                    case var average when average >= 2.75f:
                        return "-3";
                    case var average when average >= 2.50f:
                        return "2+";
                    case var average when average >= 2:
                        return "2";
                    case var average when average >= 1.75f:
                        return "-2";
                    case var average when average >= 1.50f:
                        return "+1";
                    default:
                        return "1";
                }
            }
        }

        public Grades()
        {
            this.HighestGrade = float.MinValue;
            this.LowestGrade = float.MaxValue;
            this.CountGrades = 0;
            this.Sum = 0;
        }
        public void AddGrade(float grade)
        {
            this.CountGrades++;
            this.Sum += grade;
            this.HighestGrade = Math.Max(grade, this.HighestGrade);
            this.LowestGrade = Math.Min(grade, this.LowestGrade);
        }
    }
}
