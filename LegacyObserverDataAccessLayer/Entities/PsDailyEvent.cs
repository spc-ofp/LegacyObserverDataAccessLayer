// -----------------------------------------------------------------------
// <copyright file="PsDailyEvent.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsDailyEvent
    {
        public virtual int Id { get; protected set; }

        public virtual PsDay Day { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual DateTime? UtcDateOnly { get; set; }

        public virtual string UtcTimeOnly { get; set; }

        public virtual string Latitude { get; set; }

        public virtual string Longitude { get; set; }

        public virtual string EezId { get; set; }

        public virtual decimal FishDays { get; set; }

        public virtual int ActivityType { get; set; } // ENUM

        public virtual int? WindDirection { get; set; }

        public virtual int? WindSpeed { get; set; }

        public virtual string SeaCondition { get; set; } // Enum

        public virtual int AssociationType { get; set; } // Enum

        public virtual int DetectionType { get; set; } // Enum

        public virtual string Beacon { get; set; }

        public virtual string Comments { get; set; }

        public virtual PsFishingSet FishingSet { get; set; }

        public virtual DateTime? EnteredDate { get; set; }

        public virtual string EnteredBy { get; set; }      

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }

        public virtual DateTime? GetUtcDate()
        {
            return this.UtcDateOnly.Combine(this.UtcTimeOnly);
        }
    }
}
