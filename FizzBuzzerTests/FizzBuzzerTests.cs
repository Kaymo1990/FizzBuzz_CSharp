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
    }
}
