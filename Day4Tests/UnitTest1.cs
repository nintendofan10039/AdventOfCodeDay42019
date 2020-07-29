using NUnit.Framework;
using Day4;

namespace Day4Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DuplicateEasy()
        {
            Assert.IsTrue(Day4Application.HasADuplicate("11"));
        }

        [Test]
        public void SixDigitEasy()
        {
            Assert.IsTrue(Day4Application.IsSixCharacters("123456"));
        }

        [Test]
        public void InRangeEasy()
        {
            Assert.IsTrue(Day4Application.IsInRange("2", "1", "3"));
        }

        [Test]
        public void IncreaseEasy()
        {
            Assert.IsTrue(Day4Application.IsIncreasing("123"));
        }

        [Test]
        public void AdjacentDigits()
        {
            Assert.IsTrue(Day4Application.HasADuplicate("122345"));
        }

        [Test]
        public void NeverDecrease1()
        {
            Assert.IsTrue(Day4Application.IsIncreasing("111123"));
        }

        [Test]
        public void NeverDecrease2()
        {
            Assert.IsTrue(Day4Application.IsIncreasing("135679"));
        }

        [Test]
        public void TotalTest1()
        {
            Assert.IsTrue(Day4Application.IsIncreasing("112233") && Day4Application.IsSixCharacters("112233") && Day4Application.HasADuplicate("112233"));
        }

        [Test]
        public void TotalTest2()
        {
            Assert.IsFalse(Day4Application.HasADuplicate("123444") && Day4Application.IsIncreasing("123444") && Day4Application.IsSixCharacters("123444"));
        }

        [Test]
        public void TotalTest3()
        {
            Assert.IsTrue(Day4Application.HasADuplicate("111122") && Day4Application.IsIncreasing("111122"));
        }
    }
}