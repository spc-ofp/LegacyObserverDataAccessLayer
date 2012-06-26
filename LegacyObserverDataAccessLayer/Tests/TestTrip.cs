// -----------------------------------------------------------------------
// <copyright file="TestTrip.cs" company="Secretariat of the Pacific Community">
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
        public void GetTripsById([Values(4391, 4393, 4394)] int tripId)
        {            
            var trip = repo.FindBy(tripId);
            string msg = String.Format("obstrip_id: {0}", tripId);
            Assert.NotNull(trip, msg);           
        }

        /*
        [Test]
        [Ignore("Test was written to determine why some trips were coming back as null")]
        public void GetTripWithInvalidPort()
        {
            var tripId = 487;
            string msg = String.Format("obstrip_id: {0}", tripId);
            var trip = repo.FindBy(tripId);
            Assert.Null(trip, msg);
        }
        */

        [Test]
        public void GetTripById([Values(10)] int tripId)
        {
            var trip = repo.FindBy(tripId) as PurseSeineTrip;
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
        public void GetTripUsingNewWorkbook([Values(16574)] int tripId)
        {
            var trip = repo.FindBy(tripId) as PurseSeineTrip;
            Assert.NotNull(trip);
            StringAssert.AreEqualIgnoringCase("2009", trip.FormVersion);
            Assert.True(trip.VesselDepartureDate.HasValue);
            Assert.NotNull(trip.VesselDeparturePort);
        }

        [Test]
        public void GetTripWithWellRecon([Values(8381)] int tripId)
        {
            var trip = repo.FindBy(tripId) as PurseSeineTrip;
            Assert.NotNull(trip);
            Assert.NotNull(trip.WellReconciliations);
            foreach (var recon in trip.WellReconciliations)
            {
                Assert.NotNull(recon);
                Assert.AreEqual(trip.Id, recon.Trip.Id);
            }
        }

        [Test]
        public void GetTripWithCrew([Values(8381)] int tripId)
        {
            var trip = repo.FindBy(tripId) as PurseSeineTrip;
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
        public void GetTripWithWellContent([Values(8599)] int tripId)
        {
            var trip = repo.FindBy(tripId) as PurseSeineTrip;
            Assert.NotNull(trip);
            Assert.NotNull(trip.WellContents);
            foreach (var content in trip.WellContents)
            {
                Assert.NotNull(content);
                Assert.AreEqual(trip.Id, content.Trip.Id);
            }
        }


        [Test]
        public void GetTripWithGen3([Values(8788)] int tripId)
        {
            var trip = repo.FindBy(tripId);
            Assert.NotNull(trip);
            Assert.NotNull(trip.Gen3);
            Assert.AreEqual(trip.Id, trip.Gen3.Trip.Id);
        }

        [Test]
        public void GetTripWithElectronics([Values(1608)] int tripId)
        {
            var trip = repo.FindBy(tripId);
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
        public void GetTripWithSightings([Values(8381)] int tripId)
        {
            var trip = repo.FindBy(tripId);
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
        public void GetTripWithTransfers([Values(8348)] int tripId)
        {
            var trip = repo.FindBy(tripId);
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
        public void GetTripWithPollutionEvents([Values(8824)] int tripId)
        {
            var trip = repo.FindBy(tripId);
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
        public void GetTripWithInspection([Values(15792)] int tripId)
        {
            var trip = repo.FindBy(tripId);
            Assert.NotNull(trip);
            Assert.NotNull(trip.Inspection);
            Assert.AreEqual(1, trip.Inspection.LifejacketProvided);
            Assert.AreEqual(3, trip.Inspection.LifejacketsAvailable);
            Assert.AreEqual(4, trip.Inspection.BuoyCount);
            Assert.AreEqual("406", trip.Inspection.Epi1Type.Trim());
            Assert.True(trip.Inspection.ExpiryOfLiferaft1.HasValue);
        }

        // obstrip_id values selected by inspection -- they're all NCOB with the same
        // observer staff code.
        [Test]
        public void GetLonglineTrip([Values(15852, 15850, 15713)] int tripId)
        {
            var trip = repo.FindBy(tripId) as LongLineTrip;
            Assert.NotNull(trip);
            // Check common attributes, including attributes that are boolean in the
            // source database and some that are boolean stored as char(1)
            StringAssert.AreEqualIgnoringCase("NCOB", trip.ProgramId);
            Assert.NotNull(trip.Vessel);
            Assert.True(trip.DepartureDate.HasValue);
            Assert.True(trip.ReturnDate.HasValue);
            Assert.NotNull(trip.Observer);
            StringAssert.AreEqualIgnoringCase("CHC", trip.Observer.StaffCode);
            Assert.True(trip.IsSpillTrip.HasValue);
            Assert.False(trip.IsSpillTrip.Value);
            Assert.True(trip.IsRopTrip.HasValue && trip.IsRopTrip.Value);
            Assert.True(trip.IncludeInWcpfcData.HasValue && !trip.IncludeInWcpfcData.Value);
            StringAssert.AreEqualIgnoringCase("2007", trip.FormVersion);
            StringAssert.AreEqualIgnoringCase("NC", trip.FlagCode);
            Assert.NotNull(trip.DeparturePort);
            StringAssert.AreEqualIgnoringCase("NOUMEA", trip.DeparturePort.Name);
            Assert.NotNull(trip.ReturnPort);
            StringAssert.AreEqualIgnoringCase("NOUMEA", trip.ReturnPort.Name);
            Assert.True(trip.EnteredDate.HasValue);
            Assert.True(trip.ClosedDate.HasValue);
            Assert.True(trip.IsSharkTarget.HasValue && !trip.IsSharkTarget.Value);

            // Check dependent objects
            Assert.NotNull(trip.FishingGear);
            StringAssert.AreEqualIgnoringCase("ALL", trip.FishingGear.MainlineHaulerComments); // By inspection
            StringAssert.AreEqualIgnoringCase("ALL", trip.FishingGear.LineShooterComments); // Again, by inspection
            Assert.True(trip.FishingGear.HasBranchlineAttacher.HasValue && !trip.FishingGear.HasBranchlineAttacher.Value); // char(1) converted to bool
            StringAssert.AreEqualIgnoringCase("Monofilament", trip.FishingGear.MainlineMaterial);
            Assert.True(trip.FishingGear.HasIce.HasValue && trip.FishingGear.HasIce.Value);
            Assert.False(trip.FishingGear.JapanHookPercentage.HasValue);

            Assert.NotNull(trip.FishingSets);
            Assert.False(0 == trip.FishingSets.Count);
            foreach (var fset in trip.FishingSets)
            {
                Assert.NotNull(fset);
                Assert.True(fset.DateOnly.HasValue);
                Assert.True(fset.UtcDateOnly.HasValue);
                Assert.True(fset.GetDate().HasValue);
                Assert.True(fset.GetUtcDate().HasValue);
                Assert.True(fset.HooksPerBasket.HasValue);
                Assert.True(fset.BranchlineLength.HasValue);
                Assert.True((10 < fset.BranchlineLength.Value) && (fset.BranchlineLength.Value < 20));
                Assert.False(String.IsNullOrEmpty(fset.BaitSpecies1Code));
                Assert.False(String.IsNullOrEmpty(fset.BaitSpecies1Hooks));
                Assert.True(fset.AllPositionsDirectlyObserved.HasValue);
                Assert.True(fset.EnteredDate.HasValue);
                Assert.False(String.IsNullOrEmpty(fset.EnteredBy));
                
                // More child collections
                Assert.NotNull(fset.CatchList);
                Assert.NotNull(fset.EventList);
                Assert.NotNull(fset.ConversionFactors);
            }


        }
    }
}
