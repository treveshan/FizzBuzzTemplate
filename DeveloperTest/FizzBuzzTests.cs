using NUnit.Framework;

namespace DeveloperTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GivenOne_ShouldReturnOne()
        {
            //Arrange
            var fizzBuzz = new FizzBuzz();

            //Act
            var result = fizzBuzz.Calc(1);

            //Assert
            Assert.AreEqual("1", result);
        }
      
    }
}