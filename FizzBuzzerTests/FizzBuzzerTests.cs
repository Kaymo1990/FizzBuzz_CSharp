using NUnit.Framework;
using System;
namespace FizzBuzzerTests
{
    [TestFixture()]
    public class Test
    {
        [Test]
        public void FizzBuzzer_Returns1_WhenPassed1()
        {
            var input = 1;

            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);

            Assert.AreEqual("1", output);
        }

        [Test]
        public void FizzBuzzer_ReturnsFizz_WhenPassed3()
        {
            var input = 3;

            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Fizzbuzzer_ReturnsBuzz_WhenPassed5()
        {
            var input = 5;

            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void FizzBuzzer_ReturnsFizzBuzz_WhenPassed15()
        {
            var input = 15;

            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);

            Assert.AreEqual("FizzBuzz", output);

        }

        [Test]
        public void FizzBuzzer_ReturnsDefault_WhenPassedInput([Values(1, 2, 4, 7)] int input)
        {
            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);
            Assert.AreEqual(input.ToString(), output);

        }

        [Test]
        public void FizzBuzzer_ReturnsFizz_WhenPassedInput([Values(3, 6, 9, 12)] int input)
        {
            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);
            Assert.AreEqual("Fizz", output);

        }

        [Test]
        public void FizzBuzzer_ReturnsBuzz_WhenPassedInput([Values(5, 10, 20, 25)] int input)
        {
            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void FizzBuzzer_ReturnsFizzBuzz_WhenPassedInput([Values(15, 30, 45, 60)] int input)
        {
            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
