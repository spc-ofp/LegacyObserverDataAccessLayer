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
        public void GetPollutionEventsByTripId()
        {

        }
    }
}
