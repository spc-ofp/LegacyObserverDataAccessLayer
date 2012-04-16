// -----------------------------------------------------------------------
// <copyright file="TestGen3Form.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using System.Linq;
    using NUnit.Framework;
    using Spc.Ofp.Common.Repo;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// NUnit test for Gen3Form entity
    /// </summary>
    [TestFixture]
    public class TestGen3Form
    {
        Repository<Gen3Form> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<Gen3Form>(DataService.GetSession());
        }

        [Test]
        public void GetGen3ByTripId()
        {
            var gen3 = repo.FilterBy(f => f.Trip.Id == 8799).FirstOrDefault();
            Assert.NotNull(gen3);
            Assert.NotNull(gen3.Trip);
            Assert.AreEqual(8799, gen3.Trip.Id);
        }

        [Test]
        public void GetGen3ById()
        {
            var gen3 = repo.FindBy(60);
            Assert.NotNull(gen3);
            Assert.NotNull(gen3.Trip);
            Assert.AreEqual(8782, gen3.Trip.Id);
            Assert.True(gen3.Date1.HasValue);
            Assert.True(gen3.Question5.HasValue);
            Assert.False(gen3.Question5.Value);
            Assert.True(gen3.Question6.HasValue);
            Assert.True(gen3.Question6.Value);
            Assert.That(gen3.Comment1,
                Is.Not.Null
                .And.Not.Empty
                .And.StartsWith("SEE"));
        }
    }
}
