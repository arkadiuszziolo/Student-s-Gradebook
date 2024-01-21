namespace StudentsGradebook.Tests
{
    public class GradesTests
    {
        [Test]
        public void AddGradesAsStringAndInt_ShouldReturnCorrectValues()
        {
            //arrange
            var student = new StudentInMemory("Arek", "Zioło", "4C");
            student.AddGrade(5);
            student.AddGrade("F");
            student.AddGrade("C");

            // act
            var result = student.GetGrades();

            // assert
            Assert.AreEqual(5, result.HighestGrade);
            Assert.AreEqual(1, result.LowestGrade);
            Assert.AreEqual("3", result.AverageReturnAsString);
            Assert.AreEqual(3, result.CountGrades);
        }

        [Test]
        public void AddGradesWithMinusAndPlus_ShoudReturnCorrectValues()
        {
            //arrange
            var student = new StudentInMemory("Arek", "Zioło", "4C");
            student.AddGrade("-5");
            student.AddGrade("+F");
            student.AddGrade("A-");
            student.AddGrade("C-");

            //act
            var result = student.GetGrades();

            // assert
            Assert.AreEqual("6-", result.HighestGradeReturnAsString);
            Assert.AreEqual("+1", result.LowestGradeReturnAsString);
            Assert.AreEqual("-4", result.AverageReturnAsString);
            Assert.AreEqual(4, result.CountGrades);
            }
        }
}