// -----------------------------------------------------------------------
// <copyright file="TestLonglineCatch.cs" company="Secretariat of the Pacific Community">
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
    public class TestLonglineCatch
    {
        Repository<LonglineCatch> repo;
        NHibernate.ISession session;

        [TestFixtureSetUp]
        public void Init()
        {
            session = DataService.GetSession();
            repo = new Repository<LonglineCatch>(session);
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
        public void GetTripBySetId([Values(63565, 63574)] int setId)
        {
            var catchlist = repo.FilterBy(cl => cl.FishingSet.Id == setId);
            Assert.NotNull(catchlist);
            Assert.True(catchlist.Count() > 5);
            foreach (var llc in catchlist)
            {
                Assert.NotNull(llc);
                Assert.True(llc.DateOnly.HasValue);
                Assert.False(String.IsNullOrEmpty(llc.TimeOnly));
                Assert.True(llc.GetDate().HasValue);
                Assert.False(String.IsNullOrEmpty(llc.SpeciesCode));
                Assert.False(String.IsNullOrEmpty(llc.ConditionCode));
                Assert.False(String.IsNullOrEmpty(llc.FateCode));
                Assert.False(String.IsNullOrEmpty(llc.Comments));
            }
        }


    }
}
