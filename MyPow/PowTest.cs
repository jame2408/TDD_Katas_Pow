using System;
using FsCheck;
using NUnit.Framework;

namespace MyPow
{
    [TestFixture]
    public class PowTest
    {
        [FsCheck.NUnit.Property]
        public Property Test_Power_Of_0_Should_Be_1(double x)
        {
            var targer = new Solution();
            Func<bool> property = () => targer.MyPow(x, 0) == 1;
            return property.ToProperty();
        }

        [Test]
        public void Test_Square_Root_Of_3_Should_Be_9()
        {
            var target = new Solution();
            var actual = target.MyPow(3, 2);
            Assert.AreEqual(9, actual);
        }
    }
}
