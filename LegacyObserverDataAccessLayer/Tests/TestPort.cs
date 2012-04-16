// -----------------------------------------------------------------------
// <copyright file="TestPort.cs" company="">
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
    /// NUnit tests for Port entity
    /// </summary>
    [TestFixture]
    public class TestPort
    {
        Repository<Port> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<Port>(DataService.GetSession());
        }

        [Test]
        public void GetAllPorts()
        {
            var ports = repo.All();
            Assert.NotNull(ports);
            foreach (var port in ports)
            {
                Assert.NotNull(port);
                Assert.NotNull(port.Name);
            }
        }

        [Test]
        public void GetPortById()
        {
            var port = repo.FindBy(207);
            Assert.NotNull(port);
            Assert.AreEqual(207, port.Id);
            Assert.NotNull(port.Name);
            Assert.True("CHUUK".Equals(port.Name.Trim(), StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
