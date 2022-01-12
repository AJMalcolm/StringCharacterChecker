using NUnit.Framework;
using StringCharacterChecker;

namespace CharacterCheckerTest
{
    public class CharacterCheckerUnitTests
    {
        private StringChecker _checker;

        private string _input;
        private string _expected;

        [SetUp]
        public void Setup()
        {
            _checker = new StringChecker();
        }

        [Test]
        public void AllDuplicates()
        {
            _input = "abcdefgabcdefgabcdefg";
            _expected = "abcdefg";
            Assert.That(_expected, Is.EqualTo(_checker.GetRepeatedCharacters(_input)));
        }

        [Test]
        public void NoDuplicates()
        {
            _input = "abcdefghijklmn";
            _expected = "";
            Assert.That(_expected, Is.EqualTo(_checker.GetRepeatedCharacters(_input)));
        }

        [Test]
        public void DuplicateNumbers()
        {
            _input = "123123123";
            _expected = "123";
            Assert.That(_expected, Is.EqualTo(_checker.GetRepeatedCharacters(_input)));
        }

        [Test]
        public void DuplicatePunctuation()
        {
            _input = ",.,.";
            _expected = ",.";
            Assert.That(_expected, Is.EqualTo(_checker.GetRepeatedCharacters(_input)));
        }

        [Test]
        public void SpacesDoNotCount()
        {
            _input = ",.,.  ";
            _expected = ",.";
            Assert.That(_expected, Is.EqualTo(_checker.GetRepeatedCharacters(_input)));
        }

        [TestCase("abbcddeffg", "bdf")]
        [TestCase("aabccdeefgg", "aceg")]
        [TestCase("jynshfijhiyjkgfaj", "jhiyf")]

        public void SpacesDoNotCount(string input, string expected)
        {
            Assert.That(expected, Is.EqualTo(_checker.GetRepeatedCharacters(input)));
        }
    }
}