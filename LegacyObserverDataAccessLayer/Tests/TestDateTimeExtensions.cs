// -----------------------------------------------------------------------
// <copyright file="TestDateTimeExtensions.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using System;
    using NUnit.Framework;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class TestDateTimeExtensions
    {
        [Test]
        public void DateOnly()
        {
            DateTime? dt = new DateTime(1865, 1, 1);
            Assert.AreEqual(dt, dt.Combine(String.Empty));
        }

        [Test]
        public void TimeOnly()
        {
            DateTime? dt = null;
            Assert.True(null == dt.Combine("1600"));
        }

        [Test]
        public void DateAndTime()
        {
            DateTime? dt = new DateTime(1865, 1, 1);
            DateTime expected = new DateTime(1865, 1, 1, 16, 1, 0);
            Assert.AreEqual(expected, dt.Combine("1601"));
        }

        [Test]
        public void InvalidTimes()
        {
            DateTime? dt = new DateTime(1865, 1, 1);
            Assert.AreEqual(dt, dt.Combine("160"));
            Assert.AreEqual(dt, dt.Combine("16000"));
        }
    }
}
