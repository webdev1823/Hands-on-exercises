using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator.AllClear();
        }

        [Test]
        [TestCase(10, 5, 15)]
        [TestCase(-3, 3, 0)]
        public void Addition_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 5, 5)]
        [TestCase(5, 10, -5)]
        public void Subtraction_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(3, 4, 12)]
        [TestCase(-2, 5, -10)]
        public void Multiplication_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void Division_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowArgumentException()
        {
            var ex = Assert.Throws<System.ArgumentException>(() => _calculator.Division(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }

        [Test]
        public void AllClear_ShouldResetResult()
        {
            _calculator.Addition(2, 3);
            _calculator.AllClear();
            Assert.That(_calculator.GetResult, Is.EqualTo(0));
        }
    }
}
