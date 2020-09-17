// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

using static RPN_CalcWithTests.RPN;
using RPN_CalcWithTests;
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

        [TestCase('+', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase('-', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase('/', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase('*', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase('^', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase('(', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase(')', true, Description = "Метод возвращает true, если проверяемый символ - оператор")]
        [TestCase('1', false, Description = "Метод возвращает false, если проверяемый символ - не разделитель (пробел или равно)")]
        public void IsOperatorReturnCorrectAnswer(char input, bool expected)
        {
            bool actual = IsOperator(input);
            Assert.AreEqual(expected, actual);
        }
    }
}