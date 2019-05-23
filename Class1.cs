using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace Calculator_test
{
    [TestFixture]
    class Class1
    {
        [Test]
        public void GetDivision_Input8poin0tand2point0_Returns4point0()

        {

            //Arrange
            double number1 = 8.0;
            double number2 = 2.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input18point0and3point0_Returns6point0()

        {

            //Arrange
            double number1 =18.0;
            double number2 = 3.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void GetDivision_Input24point0and2point0_Returns12point0()

        {

            //Arrange
            double number1 = 24.0;
            double number2 = 2.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input48point5and5point5_Returns54point0()

        {

            //Arrange
            double number1 = 48.5;
            double number2 = 5.5;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input7point0and3point0_Returns10point0()

        {

            //Arrange
            double number1 = 7.0;
            double number2 = 3.0;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetAddition_Input26point5and5point5_Returns32point0()

        {

            //Arrange
            double number1 = 26.5;
            double number2 = 5.5;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input5point0and3point0_Return2point0()

        {

            //Arrange
            double number1 = 5.0;
            double number2 = 3.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input2point5and1point5_Returns1point0()

        {

            //Arrange
            double number1 = 2.5;
            double number2 = 1.5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input6point2and3point5_Returns2point7()

        {

            //Arrange
            double number1 = 6.2;
            double number2 = 3.5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultlipication_Input8point0and2point0_Returns16point0()

        {

            //Arrange
            double number1 = 8.0;
            double number2 = 2.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultilplicaton_Input3point9and9point6_Returns37point44()

        {

            //Arrange
            double number1 = 3.9;
            double number2 = 9.6;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetMultiplication_Input3point0and2point0_Returns6point0()

        {

            //Arrange
            double number1 = 3.0;
            double number2 = 2.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
