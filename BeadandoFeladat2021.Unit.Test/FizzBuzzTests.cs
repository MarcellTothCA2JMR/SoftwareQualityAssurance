using BeadandoFeladat2021.MainPrograms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat2021.Unit.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(15, "FizzBuzz")]
        [TestCase(0, "FizzBuzz")]
        [TestCase(-30, "FizzBuzz")]
        public void GetOutput_DivideWithThreeAndFiveShouldWork(int input, string expected)
        {
            //Arrange
            FizzBuzz testObject = new FizzBuzz();

            //Act
            string actual = testObject.GetOutput(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(-3, "Fizz")]
        public void GetOutput_DivideWithJustThreeShouldWork(int input, string expected)
        {
            //Arrange
            FizzBuzz testObject = new FizzBuzz();

            //Act
            string actual = testObject.GetOutput(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(-20, "Buzz")]
        public void GetOutput_DivideWithJustFiveShouldWork(int input, string expected)
        {
            //Arrange
            FizzBuzz testObject = new FizzBuzz();

            //Act
            string actual = testObject.GetOutput(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, "2")]
        [TestCase(-7, "-7")]
        public void GetOutput_DivideWithFiveOrThreeShouldNotWork(int input, string expected)
        {
            //Arrange
            FizzBuzz testObject = new FizzBuzz();

            //Act
            string actual = testObject.GetOutput(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
