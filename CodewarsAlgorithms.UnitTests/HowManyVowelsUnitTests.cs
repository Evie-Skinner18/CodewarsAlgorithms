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
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CanGetVowelCountOfStringABRACADABRA_ShouldReturn5()
        {
            var kata = new Kata();
            var result = kata.GetVowelCount("ABRACADABRA");
            Assert.AreEqual(5, result);
        }
    }
}
