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
        public void GetSetCatchByTrip()
        {
            var query = repo.FilterBy(item => item.Trip.Id == 10);
            Assert.True(query.Count() > 200);

            foreach (var sc in query)
            {
                Assert.NotNull(sc);
                Assert.NotNull(sc.Comments);
            }
            
        }
    }
}
