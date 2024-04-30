namespace ReturnRandomNumberTests
{
    [TestClass]
    public class RandomNumberTests
    {
        [TestMethod]
        public void GetNumberIsEvenTrue()
        {
            // Arrange
            RandomNumber randomNumberGenerator = new RandomNumber();

            // Act
            int number = randomNumberGenerator.GetNumber();

            // Assert
            Assert.IsTrue(number % 2 == 0);
        }
    }
}