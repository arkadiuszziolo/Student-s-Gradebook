namespace StudentsGradebook.Tests
{
    public class StudentsTests
    {
        [Test]
        public void TestTwoStudentsAreNotSame_ShouldReturnTrue()
        {
            //arrange
            var student = new StudentInMemory("Arek", "Zio這", "4C");
            var student2 = new StudentInMemory("Marek", "Zio這", "4C");

            // act

            // assert
            Assert.AreNotSame(student, student2);
        }

        [Test]
        public void TestTwoStudentsEquals_ShouldReturnFalse()
        {
            //arrange
            var student = new StudentInFile("Arek", "Zio這", "4C");
            var student2 = new StudentInFile("Marek", "Zio這", "4C");

            // act

            // assert
            Assert.IsFalse(student.Equals(student2));
        }
    }
}