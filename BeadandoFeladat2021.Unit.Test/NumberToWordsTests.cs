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
    public class NumberToWordsTests
    {
        [TestCase(0, "zero")]
        public void convertNumbers_Zero(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(-9, "minus nine")]
        [TestCase(-99, "minus ninety-nine")]
        [TestCase(-1576897, "minus one million, five hundred and seventy-six thousand and eight hundred and ninety-seven")]
        public void convertNumbers_Minus(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(15, "fifteen")]
        public void convertNumbers_LessThanTwentyPositives(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(20, "twenty")]
        [TestCase(59, "fifty-nine")]
        public void convertNumbers_MoreThanTwentyLessThanHundred(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, "one hundred")]
        [TestCase(109, "one hundred and nine")]
        public void convertNumbers_HundredAndMoreButLessThanThousand(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1000, "one thousand")]
        [TestCase(9000, "nine thousand")]
        [TestCase(2135, "two thousand and one hundred and thirty-five")]
        [TestCase(32004, "thirty-two thousand and four")]
        [TestCase(56340, "fifty-six thousand and three hundred and forty")]
        [TestCase(202200, "two hundred and two thousand and two hundred")]
        [TestCase(238689, "two hundred and thirty-eight thousand and six hundred and eighty-nine")]
        public void convertNumbers_ThousandAndMoreButLessThanMillion(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1000000, "one million")]
        [TestCase(1500090, "one million, five hundred thousand and ninety")]
        [TestCase(1576897, "one million, five hundred and seventy-six thousand and eight hundred and ninety-seven")]
        public void convertNumbers_MillionPlus(int input, string expected)
        {
            //Arrange

            //Act
            string actual = NumberToWords.convertNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
