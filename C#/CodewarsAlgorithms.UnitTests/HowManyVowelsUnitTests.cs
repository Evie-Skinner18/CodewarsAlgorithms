using System;
using NUnit.Framework;
//using CodewarsAlgorithms;

namespace CodewarsAlgorithms.UnitTests
{
    [TestFixture]
    public class HowManyVowelsUnitTests
    {

        [Test]
        public void CanGetVowelCountOfStringEvie_ShouldReturn3()
        {
            var kata = new Kata();
            var result = kata.GetVowelCount("Evie");
			Assert.That(result, Is.Not.Null);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CanGetVowelCountOfStringABRACADABRA_ShouldReturn5()
        {
            var kata = new Kata();
            var result = kata.GetVowelCount("ABRACADABRA");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CanGetVowelCountOfStringContainingAlphanumericCharactersAndSpaces_ShouldReturn12()
        {
            var kata = new Kata();
            var result = kata.GetVowelCount("1,2,3,4,5. Senses working oooooverrrtime!");
            Assert.That(result == 12, Is.True);
        }

        [Test]
        public void CanGetVowelCountOfemptyString_ShouldReturn0()
        {
            var kata = new Kata();
            var result = kata.GetVowelCount("");
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
