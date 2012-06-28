// -----------------------------------------------------------------------
// <copyright file="TestConversionFactor.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using Spc.Ofp.Common.Repo;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// NUnit test for LonglineConversionFactor entity
    /// </summary>
    [TestFixture]
    public class TestConversionFactor
    {
        Repository<LonglineConversionFactor> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<LonglineConversionFactor>(DataService.GetSession());
        }

        // cfactorId values determined by inspection
        [Test]
        public void GetItemsById([Values(98153, 100532, 102331, 217602)] int cfactorId)
        {
            var cfactor = repo.FindBy(cfactorId);
            string msg = String.Format("id: {0}", cfactorId);
            Assert.NotNull(cfactor, msg);
            StringAssert.AreEqualIgnoringCase("SWO", cfactor.SpeciesCode);
            Assert.True(cfactor.LfLength.HasValue);
            Assert.AreEqual(80, cfactor.LfLength.Value);
        }
    }
}
