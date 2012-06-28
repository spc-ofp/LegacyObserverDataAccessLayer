// -----------------------------------------------------------------------
// <copyright file="TestGear.cs" company="Microsoft">
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
    public class TestGear
    {
        private const string MarineHydrotec = "MARINE HYDROTEC";

        Repository<PsFishingGear> prepo;
        Repository<LonglineFishingGear> lrepo;

        [TestFixtureSetUp]
        public void Init()
        {
            prepo = new Repository<PsFishingGear>(DataService.GetSession());
            lrepo = new Repository<LonglineFishingGear>(DataService.GetSession());
        }

        // gearId values selected by inspection
        [Test]
        public void GetPurseSeineGear([Values(206, 2379, 820)] int gearId)
        {
            var gear = prepo.FindBy(gearId);
            Assert.NotNull(gear);
            StringAssert.AreEqualIgnoringCase(MarineHydrotec, gear.PowerblockModel);
            StringAssert.AreEqualIgnoringCase(MarineHydrotec, gear.PursewinchModel);
            Assert.True(gear.NetDepth.HasValue);
            Assert.AreEqual(180, gear.NetDepth.Value);
            StringAssert.AreEqualIgnoringCase("Mtr", gear.NetDepthUnits);
            Assert.True(gear.Brail1Size.HasValue);
        }

        // gearId values selected by inspection
        [Test]
        public void GetLonglineGear([Values(1224, 1214, 1071, 1029)] int gearId)
        {
            var gear = lrepo.FindBy(gearId);
            Assert.NotNull(gear);
            Assert.True(gear.HasMainlineHauler.HasValue && gear.HasMainlineHauler.Value);
            StringAssert.AreEqualIgnoringCase("ALL", gear.MainlineHaulerComments);
            Assert.True(gear.HasBranchlineHauler.HasValue && gear.HasBranchlineHauler.Value);
            Assert.True(gear.HasLineShooter.HasValue && gear.HasLineShooter.Value);
        }
    }
}
