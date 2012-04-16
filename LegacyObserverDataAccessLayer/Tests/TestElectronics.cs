// -----------------------------------------------------------------------
// <copyright file="TestElectronics.cs" company="">
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
    public class TestElectronics
    {
        Repository<Electronics> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<Electronics>(DataService.GetSession());
        }

        [Test]
        public void GetAllElectronics()
        {
            var electronics = repo.All();
            Assert.NotNull(electronics);
            foreach (var electronicDevice in electronics)
            {
                Assert.NotNull(electronicDevice);
                Assert.NotNull(electronicDevice.Trip);
                Assert.NotNull(electronicDevice.Device);
            }
        }
    }
}
