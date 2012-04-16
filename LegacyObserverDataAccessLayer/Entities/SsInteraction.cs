// -----------------------------------------------------------------------
// <copyright file="SsInteraction.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// Interation with a species of particular interest.
    /// </summary>
    public class SsInteraction
    {
        public virtual int Id { get; protected set; }

        public virtual Trip Trip { get; set;}

        public virtual int? Landed { get; set; }

        public virtual DateTime? LandedDateOnly { get; set; }

        public virtual string LandedTimeOnly { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual string Latitude { get; set; }

        public virtual string Longitude { get; set; }

        public virtual string SpeciesCode { get; set; }

        public virtual string SpeciesDescription { get; set; }

        public virtual string LandedConditionCode { get; set; }

        public virtual string LandedConditionDescription { get; set; }

        public virtual string LandedHandling { get; set; }

        public virtual decimal? LandedLength { get; set; }

        public virtual string LandedLengthCode { get; set; }

        public virtual string LandedSex { get; set; }

        public virtual string DiscardedConditionCode { get; set; }

        public virtual string DiscardedConditionDescription { get; set; }

        public virtual string RetrievedTagNumber { get; set; }

        public virtual string RetrievedTagType { get; set; }

        public virtual string RetrievedTagOrganization { get; set; }

        public virtual string PlacedTagNumber { get; set; }

        public virtual string PlacedTagType { get; set; }

        public virtual string PlacedTagOrganization { get; set; }

        public virtual int? VesselActivity { get; set; }

        public virtual string VesselActivityOther { get; set; }

        public virtual string InteractionConditionCode { get; set; }

        public virtual string InteractionConditionDescription { get; set; }

        public virtual string InteractionDescription { get; set; }

        public virtual int? SightingActivity { get; set; }

        public virtual string SightingActivityOther { get; set; }

        public virtual int? SightingCount { get; set; }

        public virtual int? SightingAdultCount { get; set; }

        public virtual int? SightingJuvenileCount { get; set; }

        public virtual string SightingLength { get; set; }

        public virtual decimal? SightingDistance { get; set; }

        public virtual string SightingDistanceUnit { get; set; }

        public virtual string SightingBehavior { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }

        public virtual DateTime? GetLandedDate()
        {
            return this.LandedDateOnly.Combine(this.LandedTimeOnly);
        }


    }
}
