// -----------------------------------------------------------------------
// <copyright file="TestFishTransfer.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Spc.Ofp.Common.Repo;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class TestFishTransfer
    {
        Repository<FishTransfer> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<FishTransfer>(DataService.GetSession());
        }

        [Test]
        public void GetTransfersForTrip([Values(16583, 16394, 15663)] int tripId)
        {
            var transfers = repo.FilterBy(t => t.Trip.Id == tripId).ToList();
            Assert.NotNull(transfers);
            Assert.True(transfers.Count > 0);
            foreach (var transfer in transfers)
            {
                Assert.NotNull(transfer);
                Assert.True(transfer.DateOnly.HasValue);
                Assert.False(String.IsNullOrEmpty(transfer.TimeOnly));
                Assert.True(transfer.GetDate().HasValue);
                Assert.False(String.IsNullOrEmpty(transfer.Name));
                Assert.True(transfer.VesselType.HasValue);
                Assert.False(String.IsNullOrEmpty(transfer.FlagCode));
                Assert.False(String.IsNullOrEmpty(transfer.TransferType));
            }
        }

        [Test]
        public void GetTransferById([Values(5664, 5665)] int transferId)
        {
            var transfer = repo.FindBy(transferId);
            Assert.NotNull(transfer);
            Assert.AreEqual(16580, transfer.Trip.Id);
            Assert.AreEqual(1, transfer.VesselType);
            StringAssert.AreEqualIgnoringCase("JP", transfer.FlagCode);
        }
    }
}
