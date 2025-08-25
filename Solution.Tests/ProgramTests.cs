using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solution.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetMissingNumber_GivenArrayMissingTwo_ReturnsTwo()
        {
            // Arrange
            int[] inputs = [3, 0, 1];
            int expected = 2;

            // Act
            int result = Program.GetMissingNumber(inputs);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void GetMissingNumber_GivenArrayMissingEight_ReturnsEight()
        {
            // Arrange
            int[] inputs = [9, 6, 4, 2, 3, 5, 7, 0, 1];
            int expected = 8;

            // Act
            int result = Program.GetMissingNumber(inputs);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}