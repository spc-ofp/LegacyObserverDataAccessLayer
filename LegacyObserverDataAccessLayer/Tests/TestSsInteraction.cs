// -----------------------------------------------------------------------
// <copyright file="TestSsInteraction.cs" company="">
// TODO: Update copyright text.
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
    public class TestSsInteraction
    {
        
        [Test]
        public void GetAllInteractions()
        {
            using (var session = DataService.GetSession())
            {
                var repo = new Repository<SsInteraction>(session);
                var interactions = repo.All();
                Assert.NotNull(interactions);
                Assert.True(interactions.Count() > 20);
                foreach (var interaction in interactions)
                {
                    Assert.NotNull(interaction);
                    Assert.NotNull(interaction.Trip);
                }
            }
        }
    }
}
