using NUnit.Framework;

namespace Tests

{
    public class FizzBuzzerTests
    {

        [Test]
        public void Buzzer_When1Returns1()
        {
            int input = 1;

            string output = FizzBuzz.Library.FizzBuzzer.Getvalue(input);

            Assert.AreEqual("1", output);
        }
    }
}