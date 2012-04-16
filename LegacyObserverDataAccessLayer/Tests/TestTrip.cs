﻿// -----------------------------------------------------------------------
// <copyright file="TestTrip.cs" company="">
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
    /// NUnit test for Trip entity
    /// </summary>
    [TestFixture]
    public class TestTrip
    {
        Repository<Trip> repo;

        [TestFixtureSetUp]
        public void Init()
        {
            repo = new Repository<Trip>(DataService.GetSession());
        }

        [Test]
        public void GetTripById()
        {
            var trip = repo.FindBy(10) as PurseSeineTrip;
            Assert.NotNull(trip);
            Assert.NotNull(trip.Observer);
            Assert.NotNull(trip.DeparturePort);
            Assert.NotNull(trip.ReturnPort);
            Assert.NotNull(trip.Vessel);
            Assert.True("95-03".Equals(trip.TripNumber.Trim(), StringComparison.CurrentCultureIgnoreCase));
            Assert.NotNull(trip.ElectronicDevices);
            Assert.NotNull(trip.Sightings);
            Assert.NotNull(trip.PollutionEvents);
            Assert.NotNull(trip.Interactions);
            Assert.NotNull(trip.Days);
            Assert.True(trip.Days.Count > 10);
            foreach (var day in trip.Days)
            {
                Assert.NotNull(day);
                Assert.AreEqual(trip.Id, day.Trip.Id);
                Assert.NotNull(day.LogEntries);
                foreach (var logEntry in day.LogEntries)
                {
                    Assert.NotNull(logEntry);
                    Assert.AreEqual(day.Id, logEntry.Day.Id);
                }
                Assert.NotNull(day.FishingSets);
                foreach (var fset in day.FishingSets)
                {
                    Assert.NotNull(fset);
                    Assert.AreEqual(day.Id, fset.Day.Id);
                    Assert.AreEqual(fset.Id, fset.DailyEvent.Id);
                    Assert.NotNull(fset.SetCatchList);
                    foreach (var sc in fset.SetCatchList)
                    {
                        Assert.NotNull(sc);
                        Assert.AreEqual(fset.Id, sc.FishingSet.Id);
                        Assert.AreEqual(trip.Id, sc.Trip.Id);
                        Assert.NotNull(sc.SpeciesCode);
                    }

                    Assert.NotNull(fset.LengthFrequencyHeaders);
                    foreach (var lfh in fset.LengthFrequencyHeaders)
                    {
                        Assert.NotNull(lfh);
                        Assert.NotNull(lfh.Details);

                        foreach (var lfd in lfh.Details)
                        {
                            Assert.NotNull(lfd);
                            Assert.NotNull(lfd.SpeciesCode);
                        }
                    }
                }
            }

        }

        [Test]
        public void GetTripWithWellRecon()
        {
            var trip = repo.FindBy(8381) as PurseSeineTrip;
            Assert.NotNull(trip);
            Assert.NotNull(trip.WellReconciliations);
            foreach (var recon in trip.WellReconciliations)
            {
                Assert.NotNull(recon);
                Assert.AreEqual(trip.Id, recon.Trip.Id);
            }
        }

        [Test]
        public void GetTripWithCrew()
        {
            var trip = repo.FindBy(8381) as PurseSeineTrip;
            Assert.NotNull(trip);
            Assert.NotNull(trip.Crew);
            foreach (var crewmember in trip.Crew)
            {
                Assert.NotNull(crewmember);
                Assert.NotNull(crewmember.Position);
                Assert.NotNull(crewmember.Name);
            }
        }

        [Test]
        public void GetTripWithWellContent()
        {
            var trip = repo.FindBy(8599) as PurseSeineTrip;
            Assert.NotNull(trip);
            Assert.NotNull(trip.WellContents);
            foreach (var content in trip.WellContents)
            {
                Assert.NotNull(content);
                Assert.AreEqual(trip.Id, content.Trip.Id);
            }
        }


        [Test]
        public void GetTripWithGen3()
        {
            var trip = repo.FindBy(8788);
            Assert.NotNull(trip);
            Assert.NotNull(trip.Gen3);
            Assert.AreEqual(trip.Id, trip.Gen3.Trip.Id);
        }

        [Test]
        public void GetTripWithElectronics()
        {
            var trip = repo.FindBy(1608);
            Assert.NotNull(trip);
            Assert.NotNull(trip.ElectronicDevices);
            var jrcDevices =
                from device in trip.ElectronicDevices
                where device.Make.Trim() == "JRC"
                select device;

            Assert.True(jrcDevices.Count() > 5);

            foreach (var device in trip.ElectronicDevices)
            {
                Assert.NotNull(device);
                Assert.AreEqual(trip.Id, device.Trip.Id);
                if (String.IsNullOrEmpty(device.Make.Trim()))
                {
                    continue;
                }
                Assert.True("Y".Equals(device.YesNo.Trim(), StringComparison.CurrentCultureIgnoreCase));
            }
        }

        [Test]
        public void GetTripWithSightings()
        {
            var trip = repo.FindBy(8381);
            Assert.NotNull(trip);
            Assert.NotNull(trip.Sightings);
            Assert.True(trip.Sightings.Count > 5);

            foreach (var sighting in trip.Sightings)
            {
                Assert.NotNull(sighting);
                Assert.AreEqual(trip.Id, sighting.Trip.Id);
                Assert.That(sighting.Name.Trim(),
                    Is.Not.Null
                    .And.Not.Empty);
                Assert.True(sighting.GetDate().HasValue);
                Assert.False(sighting.GetDate().Value.TimeOfDay.Equals(TimeSpan.Zero));

            }
        }

        [Test]
        public void GetTripWithTransfers()
        {
            var trip = repo.FindBy(8348);
            Assert.NotNull(trip);
            Assert.NotNull(trip.Transfers);
            Assert.True(trip.Transfers.Count > 10);

            foreach (var transfer in trip.Transfers)
            {
                Assert.NotNull(transfer);
                Assert.AreEqual(trip.Id, transfer.Trip.Id);
            }
        }

        [Test]
        public void GetTripWithPollutionEvents()
        {
            var trip = repo.FindBy(8824);
            Assert.NotNull(trip);
            Assert.NotNull(trip.PollutionEvents);
            Assert.True(trip.PollutionEvents.Count > 2);

            foreach (var header in trip.PollutionEvents)
            {
                Assert.NotNull(header);
                Assert.AreEqual(trip.Id, header.Trip.Id);
                foreach (var detail in header.Details)
                {
                    Assert.NotNull(detail);
                    Assert.AreEqual(header.Id, detail.Header.Id);
                    Assert.NotNull(detail.Quantity);
                }
            }
        }

        [Test]
        public void GetTripWithInspection()
        {
            var trip = repo.FindBy(7181);
            Assert.NotNull(trip);
            Assert.NotNull(trip.Inspection);
            Assert.AreEqual(2, trip.Inspection.LifejacketProvided);
            Assert.AreEqual(2, trip.Inspection.LifejacketsAvailable);
            Assert.AreEqual(2, trip.Inspection.BuoyCount);
            Assert.AreEqual("406", trip.Inspection.Epi1Type.Trim());
            Assert.True(trip.Inspection.ExpiryOfLiferaft1.HasValue);
        }
    }
}