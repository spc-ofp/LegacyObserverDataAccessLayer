﻿// -----------------------------------------------------------------------
// <copyright file="Trip.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class Trip
    {
        protected Trip()
        {
            ElectronicDevices = new List<Electronics>(8);
            Sightings = new List<Sighting>(8);
            Transfers = new List<FishTransfer>(8);
            PollutionEvents = new List<PollutionHeader>(8);
            Interactions = new List<SsInteraction>(8);           
        }

        public virtual int Id { get; protected set; }

        public virtual int RegistrationId { get; set; }

        public virtual string ProgramId { get; set; }

        public virtual string CountryCode { get; set; }

        public virtual FieldStaff Observer { get; set; }

        public virtual string TripNumber { get; set; }

        // s_obsv_id
        public virtual FieldStaff CompanionObserver { get; set; }

        // s_tripno
        public virtual string CompanionTripNumber { get; set; }

        public virtual string FormVersion { get; set; }

        public virtual DateTime? DepartureDate { get; set; }

        public virtual DateTime? ReturnDate { get; set; }

        public virtual DateTime? VesselDepartureDate { get; set; }

        public virtual Vessel Vessel { get; set; }

        public virtual string VesselName { get; set; }

        public virtual string VesselRegistrationNumber { get; set; }

        public virtual string FlagCode { get; set; }

        public virtual string FleetCode { get; set; }

        public virtual decimal? GrossTonnage { get; set; }

        public virtual string Owner { get; set; }

        public virtual string Captain { get; set; }

        public virtual string FishingMaster { get; set; }

        public virtual string Licenses { get; set; }

        public virtual string Comments { get; set; }

        public virtual string CkTripNumber { get; set; }

        public virtual string FmTripNumber { get; set; }

        public virtual string FfaTripNumber { get; set; }

        public virtual string SbTripNumber { get; set; }

        public virtual string HwTripNumber { get; set; }

        public virtual bool? IsSharkIdentifiedToSpeciesLevel { get; set; }

        public virtual bool? IsSharkTarget { get; set; }

        // Did the observer trip coincide with the start and end of the vessel trip
        public virtual bool? IsFullTrip { get; set; }

        public virtual string ProjectCode { get; set; }

        public virtual bool? IsCadetTrip { get; set; }

        public virtual bool? IsSpillTrip { get; set; }

        // ROP Trip:  Vessel fishing outside it's flag EEZ
        public virtual bool? IsRopTrip { get; set; }

        public virtual bool? IncludeInWcpfcData { get; set; }

        public virtual int? RecordedSetCount { get; set; }

        public virtual int? LogsheetTripId { get; set; }

        public virtual int? EstimatedLogsheetTripId { get; set; }

        public virtual bool? HasLogsheetData { get; set; }

        public virtual bool? HasHardCopy { get; set; }

        public virtual DateTime? ReceivedDate { get; set; }

        public virtual bool? IsJournalAvailable { get; set; }

        public virtual DateTime? AcknowledgedDate { get; set; }

        public virtual string CrewNationality1 { get; set; }

        public virtual string CrewNationality2 { get; set; }

        public virtual string CrewNationality3 { get; set; }

        public virtual string CrewNationality4 { get; set; }

        public virtual int? CrewNationalityCount1 { get; set; }

        public virtual int? CrewNationalityCount2 { get; set; }

        public virtual int? CrewNationalityCount3 { get; set; }

        public virtual int? CrewNationalityCount4 { get; set; }

        public virtual Port DeparturePort { get; set; }

        public virtual Port ReturnPort { get; set; }

        public virtual Port VesselDeparturePort { get; set; }

        public virtual Gen3Form Gen3 { get; set; }

        public virtual SafetyInspection Inspection { get; set; }

        public virtual IList<Electronics> ElectronicDevices { get; protected internal set; }

        public virtual IList<Sighting> Sightings { get; protected internal set; }

        public virtual IList<FishTransfer> Transfers { get; protected internal set; }

        public virtual IList<PollutionHeader> PollutionEvents { get; protected internal set; }

        public virtual IList<SsInteraction> Interactions { get; protected internal set; }       

        public virtual string EnteredBy { get; set; }

        public virtual DateTime? EnteredDate { get; set; }

        public virtual string VerifiedBy { get; set; }

        public virtual DateTime? VerifiedDate { get; set; }

        public virtual DateTime? ClosedDate { get; set; }

        public virtual void AddElectronicDevice(Electronics device)
        {
            device.Trip = this;
            this.ElectronicDevices.Add(device);
        }

        public virtual void AddSighting(Sighting sighting)
        {
            sighting.Trip = this;
            this.Sightings.Add(sighting);
        }

        public virtual void AddTransfer(FishTransfer transfer)
        {
            transfer.Trip = this;
            this.Transfers.Add(transfer);
        }

        public virtual void AddPollutionEvent(PollutionHeader header)
        {
            header.Trip = this;
            this.PollutionEvents.Add(header);
        }

        public virtual void AddInteraction(SsInteraction interaction)
        {
            interaction.Trip = this;
            this.Interactions.Add(interaction);
        }

    }
}
