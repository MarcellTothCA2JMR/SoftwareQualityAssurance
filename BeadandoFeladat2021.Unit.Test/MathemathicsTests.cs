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
    public class MathemathicsTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(0, 5, 5)]
        public void Add_TwoPositivesShouldBePositive(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Add(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3, -6, -9)]
        [TestCase(0, -7, -7)]
        public void Add_TwoNegativesShouldBeNegative(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Add(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3, 7, 4)]
        [TestCase(6, -7, -1)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 0, 0)]
        public void Add_OnePositiveOneNegativeDependent(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Add(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(6, 5, 6)]
        [TestCase(1, 3, 3)]
        [TestCase(0, 3, 3)]
        public void Max_TwoNotNegativesNotEquals(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Max(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, -7, -2)]
        [TestCase(-5, -1, -1)]
        [TestCase(0, -3, 0)]
        public void Max_TwoNotPositivesNotEquals(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Max(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, 2, 2)]
        [TestCase(5, -5, 5)]
        [TestCase(-2, 5, 5)]
        [TestCase(3, -4, 3)]
        public void Max_TwoDefferentSignes(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Max(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, -2, -2)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 0, 0)]
        public void Max_TwoEquals(int input, int inp, int expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            int actual = testObject.Max(input, inp);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        //(new [] {1, 3, 5})
        [TestCase(6, (new[] { 1, 3, 5 }))]
        [TestCase(7, (new[] { 1, 3, 5, 7 }))]
        public void GetOddNumbers_AreThereAny(int input, IEnumerable<int> expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            IEnumerable<int> actual = testObject.GetOddNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, (new int[0]))]
        [TestCase(-3, (new int[0]))]
        public void GetOddNumbers_EmptyResult(int input, IEnumerable<int> expected)
        {
            //Arrange
            Mathemathics testObject = new Mathemathics();

            //Act
            IEnumerable<int> actual = testObject.GetOddNumbers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
