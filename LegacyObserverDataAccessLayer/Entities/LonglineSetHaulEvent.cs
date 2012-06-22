// -----------------------------------------------------------------------
// <copyright file="LonglineSetHaulEvent.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineSetHaulEvent
    {
        public virtual int Id { get; protected set; }
        public virtual Trip Trip { get; set; }
        public virtual LonglineFishingSet FishingSet { get; set; }

        public virtual int? EventNumber { get; set; }

        public virtual string EventType { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual string Latitude { get; set; }

        public virtual string Longitude { get; set; }

        public virtual string EezId { get; set; }

        public virtual int? WindDirection { get; set; }

        public virtual int? WindSpeed { get; set; }

        public virtual string SeaCondition { get; set; }

        public virtual int? CloudCoverage { get; set; }

        public virtual string Comments { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }
    }
}
