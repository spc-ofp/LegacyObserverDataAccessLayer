// -----------------------------------------------------------------------
// <copyright file="PsVesselAttributes.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsVesselAttributes
    {
        public virtual int Id { get; set; }
        public virtual Trip Trip { get; set; }
        public virtual string Owner { get; set; }
        public virtual int? SpeedboatCount { get; set; }
        public virtual int? TowboatCount { get; set; }
        public virtual bool? Tenderboats { get; set; }
        public virtual int? SkiffEnginePower { get; set; }
        public virtual string SkiffEngineMake { get; set; }
        public virtual decimal? CruisingSpeed { get; set; }
        public virtual string HelicopterMake { get; set; }
        public virtual string HelicopterModel { get; set; }
        public virtual string HelicopterRegistrationNumber { get; set; }
        public virtual int? HelicopterRange { get; set; }
        public virtual string HelicopterRangeUnits { get; set; }
        public virtual string HelicopterColor { get; set; }
        public virtual int? HelicopterServiceCount { get; set; }
        public virtual bool? HasWasteDisposal { get; set; }
        public virtual string WasteDisposalDescription { get; set; }
    }
}
