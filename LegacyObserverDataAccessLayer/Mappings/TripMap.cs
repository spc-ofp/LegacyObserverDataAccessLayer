﻿// -----------------------------------------------------------------------
// <copyright file="TripMap.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TripMap : ClassMap<Trip>
    {
        public TripMap()
        {
            ReadOnly();
            Table("obs_trip");
            Id(x => x.Id, "obstrip_id").GeneratedBy.Assigned();
            Map(x => x.RegistrationId, "regist_id");
            Map(x => x.ProgramId, "obs_prg_id");
            Map(x => x.CountryCode, "co_id");
            Map(x => x.TripNumber, "tripno");
            Map(x => x.FormVersion, "form_vers");
            Map(x => x.DepartureDate, "o_dep_date");
            Map(x => x.ReturnDate, "o_ret_date");
            Map(x => x.FlagCode, "flag_id");
            Map(x => x.FleetCode, "fleet_id");
            Map(x => x.GrossTonnage, "grt");
            Map(x => x.Captain, "captain");
            Map(x => x.FishingMaster, "fish_master");
            Map(x => x.Owner, "owner");
            Map(x => x.Licenses, "permit_1");
            Map(x => x.Comments, "notes");

            Map(x => x.CkTripNumber, "cktripno");
            Map(x => x.FmTripNumber, "fmtripno");
            Map(x => x.FfaTripNumber, "ffatripno");
            Map(x => x.SbTripNumber, "sbtripno");
            Map(x => x.HwTripNumber, "hwtripno");
            Map(x => x.IsSharkTarget, "sharktarget");
            Map(x => x.IsFullTrip, "fulltrip");
            Map(x => x.ProjectCode, "project_code");
            Map(x => x.IsCadetTrip, "cadet");

            Map(x => x.EnteredBy, "entered_by");
            Map(x => x.EnteredDate, "entered");
            Map(x => x.ClosedDate, "closed");
            Map(x => x.VerifiedBy, "verified_by");
            Map(x => x.VerifiedDate, "verified");

            References(x => x.Observer).Column("obsv_id").Not.LazyLoad();
            References(x => x.DeparturePort).Column("dep_id").Not.LazyLoad();
            References(x => x.ReturnPort).Column("ret_id").Not.LazyLoad();
            References(x => x.Vessel).Column("boat_id").Not.LazyLoad();

            HasOne(x => x.Gen3).PropertyRef(r => r.Trip).Cascade.All();
            HasOne(x => x.Inspection).PropertyRef(r => r.Trip).Cascade.All();

            HasMany(x => x.ElectronicDevices).KeyColumn("obstrip_id");
            HasMany(x => x.Sightings).KeyColumn("obstrip_id");
            HasMany(x => x.Transfers).KeyColumn("obstrip_id");
            HasMany(x => x.PollutionEvents).KeyColumn("obstrip_id");            

            DiscriminateSubClassesOnColumn<string>("gr_id");
        }
    }

    public class PurseSeineTripMap : SubclassMap<PurseSeineTrip>
    {
        public PurseSeineTripMap()
        {
            DiscriminatorValue("S");
            HasMany(x => x.Days).KeyColumn("obstrip_id");
            HasMany(x => x.Crew).KeyColumn("obstrip_id");
            HasMany(x => x.WellContents).KeyColumn("obstrip_id");
            HasMany(x => x.WellReconciliations).KeyColumn("obstrip_id");

            HasOne(x => x.FishingGear).PropertyRef(r => r.Trip).Cascade.All();
            HasOne(x => x.VesselAttributes).PropertyRef(r => r.Trip).Cascade.All();
        }
    }

    public class LongLineTripMap : SubclassMap<LongLineTrip>
    {
        public LongLineTripMap()
        {
            DiscriminatorValue("L");
        }
    }
}