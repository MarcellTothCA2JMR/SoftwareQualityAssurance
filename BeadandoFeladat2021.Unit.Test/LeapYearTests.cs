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
    public class LeapYearTests
    {
        [TestCase(1996, true)]
        public void checkLeapYear_NumberCanBeDividedWithFourButNotWithHundredAndFourHundredShouldBeTrue(int input, bool expected)
        {
            //Arrange
            LeapYear testObject = new LeapYear();

            //Act
            bool actual = testObject.checkLeapYear(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2002, false)]
        [TestCase(2003, false)]
        public void checkLeapYear_NumberCantBeDividedWithFourOrHundredOrFourHundredShouldBeFalse(int input, bool expected)
        {
            //Arrange
            LeapYear testObject = new LeapYear();

            //Act
            bool actual = testObject.checkLeapYear(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1900, false)]
        public void checkLeapYear_NumberCanBeDividedWithFourAndHundredButNotFourHundredShouldBeFalse(int input, bool expected)
        {
            //Arrange
            LeapYear testObject = new LeapYear();

            //Act
            bool actual = testObject.checkLeapYear(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2000, true)]
        [TestCase(0, true)]
        public void checkLeapYear_NumberCanBeDividedWithFourHundredShouldBeTrue(int input, bool expected)
        {
            //Arrange
            LeapYear testObject = new LeapYear();

            //Act
            bool actual = testObject.checkLeapYear(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1996, true)]
        [TestCase(-2000, true)]
        [TestCase(-1900, false)]
        [TestCase(-2003, false)]
        [TestCase(-2002, false)]
        public void checkLeapYear_MinusNumbersWorkProperlyAsWell(int input, bool expected)
        {
            //Arrange
            LeapYear testObject = new LeapYear();

            //Act
            bool actual = testObject.checkLeapYear(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
