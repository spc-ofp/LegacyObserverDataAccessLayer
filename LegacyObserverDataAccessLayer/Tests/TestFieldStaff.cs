// -----------------------------------------------------------------------
// <copyright file="TestFieldStaff.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using System;
    using NUnit.Framework;
    using Spc.Ofp.Common.Repo;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// NUnit tests for FieldStaff entity
    /// </summary>
    [TestFixture]
    public class TestFieldStaff
    {
        [Test]
        public void GetAllStaff()
        {
            var repo = new Repository<FieldStaff>(DataService.GetSession());
            var staff = repo.All();
            Assert.NotNull(staff);
            foreach (var staffMember in staff)
            {
                Assert.NotNull(staffMember);
                Assert.NotNull(staffMember.StaffCode);
            }
        }

        [Test]
        public void GetByStaffCode()
        {
            var repo = new Repository<FieldStaff>(DataService.GetSession());
            var person = repo.FindBy("DJB");
            Assert.NotNull(person);
            Assert.AreEqual("DJB", person.StaffCode);
            Assert.AreEqual("DAVE J", person.FirstName);
            Assert.IsTrue("Dave J".Equals(person.FirstName.Trim(), StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
