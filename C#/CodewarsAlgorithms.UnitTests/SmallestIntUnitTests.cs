using System;
using NUnit.Framework;

namespace CodewarsAlgorithms.UnitTests
{
    [TestFixture]
    public class SmallestIntUnitTests
    {
        [Test]
        public void CanGetSmallestIntArray_ShouldReturnMinus13()
        {
            var kata = new SmallestInt();
            var result = kata.FindSmallestInt(new int[] { 88, 234, 9, -13 });
            Assert.AreEqual(-13, result);
        }

        //  
    }
}
