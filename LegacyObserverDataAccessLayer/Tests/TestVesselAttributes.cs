// -----------------------------------------------------------------------
// <copyright file="TestVesselAttributes.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using NUnit.Framework;
    using Spc.Ofp.Common.Repo;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class TestVesselAttributes
    {
        Repository<PsVesselAttributes> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<PsVesselAttributes>(DataService.GetSession());
        }

        [Test]
        public void GetAllVesselAttributes()
        {
            var attributes = repo.All();
            Assert.NotNull(attributes);
            foreach (var attr in attributes)
            {
                Assert.NotNull(attr);
                Assert.NotNull(attr.Trip);
            }
        }
    }
}
