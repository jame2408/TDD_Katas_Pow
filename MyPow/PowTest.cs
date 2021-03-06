﻿using System;
using FsCheck;
using NUnit.Framework;

namespace MyPow
{
    [TestFixture]
    public class PowTest
    {
        Solution target = new Solution();

        [FsCheck.NUnit.Property]
        public Property Test_Power_Of_0_Should_Be_1(double x)
        {
            Func<bool> property = () => target.MyPow(x, 0) == 1;
            return property.ToProperty();
        }

        [Test]
        public void Test_Square_Root_Of_3_Should_Be_9()
        {
            var actual = target.MyPow(3, 2);
            Assert.AreEqual(9, actual);
        }
        
        [Test]
        public void Test_Cube_Root_Of_3_Should_Be_27()
        {
            var actual = target.MyPow(3, 3);
            Assert.AreEqual(27, actual);
        }

        [Test]
        public void Test_Negative_Square_Root_Of_3_Should_Be_1_By_9()
        {
            var actual = target.MyPow(3, -2);
            Assert.AreEqual(1/9d, actual);
        }
        
        [Test]
        public void Test_Minimal_integer_To_Power_Of_2_Should_Be_Approaches_0()
        {
            var actual = target.MyPow(2, Int32.MinValue);
            Assert.AreEqual(0, actual);
        }
    }
}
