// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

using static RPN_CalcWithTests.RPN;
using RPN_CalcWithTests;
using System;

namespace NUnit.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }

        [TestCase(' ', true, Description = "Метод возвращает true, если проверяемый символ - разделитель (пробел)")]
        [TestCase('=', true, Description = "Метод возвращает true, если проверяемый символ - разделитель (равно)")]
        [TestCase('1', false, Description = "Метод возвращает false, если проверяемый символ - не разделитель (пробел или равно)")]
        public void IsDelimiterReturnCorrectAnswer(char input, bool expected)
        {
            bool actual = IsDelimeter(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase('+', true, Description = "Метод возвращает true, если проверяемый символ - оператор +")]
        [TestCase('-', true, Description = "Метод возвращает true, если проверяемый символ - оператор -")]
        [TestCase('/', true, Description = "Метод возвращает true, если проверяемый символ - оператор /")]
        [TestCase('*', true, Description = "Метод возвращает true, если проверяемый символ - оператор *")]
        [TestCase('^', true, Description = "Метод возвращает true, если проверяемый символ - оператор ^")]
        [TestCase('(', true, Description = "Метод возвращает true, если проверяемый символ - оператор (")]
        [TestCase(')', true, Description = "Метод возвращает true, если проверяемый символ - оператор )")]
        [TestCase('1', false, Description = "Метод возвращает false, если проверяемый символ - не оператор")]
        [TestCase(' ', false, Description = "Метод возвращает false, если проверяемый символ - не оператор")]
        public void IsOperatorReturnCorrectAnswer(char input, bool expected)
        {
            bool actual = IsOperator(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase('+', 2, Description = "Метод возвращает 2, если проверяемый символ - оператор +")]
        [TestCase('-', 3, Description = "Метод возвращает 3, если проверяемый символ - оператор -")]
        [TestCase('/', 4, Description = "Метод возвращает 4, если проверяемый символ - оператор /")]
        [TestCase('*', 4, Description = "Метод возвращает 4, если проверяемый символ - оператор *")]
        [TestCase('^', 5, Description = "Метод возвращает 5, если проверяемый символ - оператор ^")]
        [TestCase('(', 0, Description = "Метод возвращает 0, если проверяемый символ - оператор (")]
        [TestCase(')', 1, Description = "Метод возвращает 1, если проверяемый символ - оператор )")]
        [TestCase('1', 6, Description = "Метод возвращает 6, если проверяемый символ - не один из операторов")]
        [TestCase(' ', 6, Description = "Метод возвращает 6, если проверяемый символ - не один из операторов")]
        public void TestGetPriorityMethod(char input, byte expected)
        {
            byte actual = GetPriority(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3+4*2/(1-5)^2", 3.5d)]
        [TestCase("3+4", 7)]
        [TestCase("0+0", 0)]
        [TestCase("-1*2+3/4", -1.25)]
        [TestCase("1/0", Double.PositiveInfinity)]
        public void TestCalculateMethod(string input, double expected)
        {
            double actual = Calculate(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("3+4*2/(1-5)^2", "3 4 2 * 1 5 - 2 ^ / + ")]
        [TestCase("3+4", "3 4 + ")]
        [TestCase("0+0", "0 0 + ")]
        [TestCase("-1*2+3/4", "1 2 * 3 4 / + - ")]
        [TestCase("1/0", "1 0 / ")]
        public void TestGetExpressionMethod(string input, string expected)
        {
            string actual = GetExpression(input);
            Assert.AreEqual(expected, actual);
        }       
    }
}