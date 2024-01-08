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
    public class DemeritPointsCalculatorTests
    {
        [TestCase(40, 0)]
        [TestCase(0, 0)]
        [TestCase(50, 0)]
        public void CalculateDemeritPoints_SpeedInRangeAndUnderLimitShouldBeZero(int input, int expected)
        {
            //Arrange
            DemeritPointsCalculator testObject = new DemeritPointsCalculator();

            //Act
            int actual = testObject.CalculateDemeritPoints(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(59, 0)]
        public void CalculateDemeritPoints_SpeedInRangeButOverLimitWithLessThanTenShouldBeZero(int input, int expected)
        {
            //Arrange
            DemeritPointsCalculator testObject = new DemeritPointsCalculator();

            //Act
            int actual = testObject.CalculateDemeritPoints(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(60, 1)]
        [TestCase(69, 1)]
        [TestCase(70, 2)]
        [TestCase(175, 12)]
        [TestCase(180, 13)]
        public void CalculateDemeritPoints_SpeedInRangeButOverLimitWithMinTenShouldBeOneOrMore(int input, int expected)
        {
            //Arrange
            DemeritPointsCalculator testObject = new DemeritPointsCalculator();

            //Act
            int actual = testObject.CalculateDemeritPoints(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(181)]
        [TestCase(-1)]
        public void CalculateDemeritPoints_SpeedOutOfRangeShouldThrowException(int input)
        {
            //Arrange
            DemeritPointsCalculator testObject = new DemeritPointsCalculator();

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => testObject.CalculateDemeritPoints(input));
        }
    }
}
