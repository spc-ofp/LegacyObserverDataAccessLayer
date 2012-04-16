// -----------------------------------------------------------------------
// <copyright file="TestTripHeader.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Tests
{
    using System;
    using NUnit.Framework;
    using Spc.Ofp.Common.Repo;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class TestTripHeader
    {
        [Test]
        public void GetAllTripHeaders()
        {
            using (var session = DataService.GetSession())
            {
                var repo = new Repository<TripHeader>(session);
                var headers = repo.All();
                Assert.NotNull(headers);
                foreach (var header in headers)
                {
                    Assert.NotNull(header);
                    Assert.False(String.IsNullOrEmpty(header.StaffCode));
                    Assert.False(String.IsNullOrEmpty(header.ProgramCode));
                    Assert.False(String.IsNullOrEmpty(header.SpcTripNumber));
                    Assert.False(String.IsNullOrEmpty(header.GearCode));
                }
            }
        }
    }
}
