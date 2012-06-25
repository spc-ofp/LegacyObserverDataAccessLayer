// -----------------------------------------------------------------------
// <copyright file="TestLonglineSetHaulEvent.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
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
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class TestLonglineSetHaulEvent
    {
        Repository<LonglineSetHaulEvent> repo;
        NHibernate.ISession session;

        [TestFixtureSetUp]
        public void Init()
        {
            session = DataService.GetSession();
            repo = new Repository<LonglineSetHaulEvent>(session);
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            if (null != session)
            {
                session.Dispose();
            }
        }

        [Test]
        public void GetEventsBySetId([Values(63565, 63568)] int setId)
        {
            var events = repo.FilterBy(e => e.FishingSet.Id == setId);
            Assert.NotNull(events);
            Assert.True(events.Count() > 5);
            foreach (var shevent in events)
            {
                Assert.NotNull(shevent);
                Assert.True(shevent.GetDate().HasValue);
                Assert.True(shevent.DateOnly.HasValue);
                Assert.False(String.IsNullOrEmpty(shevent.EventType));
                Assert.False(String.IsNullOrEmpty(shevent.Latitude));
                Assert.False(String.IsNullOrEmpty(shevent.Longitude));
                StringAssert.AreEqualIgnoringCase("IW", shevent.EezId);
            }
        }
    }
}
