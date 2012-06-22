// -----------------------------------------------------------------------
// <copyright file="TestSetCatch.cs" company="">
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
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class TestSetCatch
    {
        Repository<PsSetCatch> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<PsSetCatch>(DataService.GetSession());
        }

        [Test]
        public void GetSetCatchByTrip([Values(10)] int tripId)
        {
            var query = repo.FilterBy(item => item.Trip.Id == tripId);
            Assert.True(query.Count() > 200);

            foreach (var sc in query)
            {
                Assert.NotNull(sc);
                Assert.NotNull(sc.Comments);
            }           
        }

        [Test]
        public void GetSetCatchBySetId([Values(1109250)] int setId)
        {
            var items = repo.FilterBy(item => item.FishingSet.Id == setId);
            Assert.NotNull(items);
            foreach (var sc in items)
            {
                Assert.NotNull(sc);
                Assert.True(sc.IsLargeFish.HasValue);
                Assert.False(sc.IsLargeFish.Value);
                StringAssert.AreEqualIgnoringCase("RWW", sc.FateCode);
                StringAssert.AreEqualIgnoringCase("U", sc.ConditionCode);
                Assert.Greater(sc.EstimatedSpeciesCount, 10);
            }
        }
    }
}
