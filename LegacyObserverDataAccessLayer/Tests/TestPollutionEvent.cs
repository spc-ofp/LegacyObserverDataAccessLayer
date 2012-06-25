// -----------------------------------------------------------------------
// <copyright file="TestPollutionEvent.cs" company="Secretariat of the Pacific Community">
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
    public class TestPollutionEvent
    {
        Repository<PollutionHeader> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<PollutionHeader>(DataService.GetSession());
        }

        [Test]
        public void GetPollutionEventsByTripId([Values(16582)] int tripId)
        {
            var events = repo.FilterBy(e => e.Trip.Id == tripId);
            Assert.NotNull(events);
            Assert.False(0 == events.Count());
            foreach (var pevent in events)
            {
                Assert.NotNull(pevent);
                Assert.True(pevent.DateOnly.HasValue);
                Assert.False(String.IsNullOrEmpty(pevent.TimeOnly));
                Assert.False(String.IsNullOrEmpty(pevent.Latitude));
                Assert.False(String.IsNullOrEmpty(pevent.Longitude));
                Assert.NotNull(pevent.Details);
                Assert.True(1 == pevent.Details.Count);
                var detail = pevent.Details[0];
                Assert.NotNull(detail);
                StringAssert.AreEqualIgnoringCase("P", detail.Material);
                Assert.True(detail.YesNo.HasValue);
                Assert.AreEqual(1, detail.YesNo.Value);
            }
        }
    }
}
