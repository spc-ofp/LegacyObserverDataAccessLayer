// -----------------------------------------------------------------------
// <copyright file="Sighting.cs" company="">
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
    public class Sighting
    {
        public virtual int Id { get; protected set; }
        public virtual Trip Trip { get; set; }
        public virtual DateTime? DateOnly { get; set; }
        public virtual string TimeOnly { get; set; }
        public virtual string Latitude { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string EezId { get; set; }
        public virtual string Name { get; set; }
        public virtual string CallSign { get; set; }
        public virtual string FlagCode { get; set; }
        public virtual int VesselType { get; set; } // TODO Change to Enum
        public virtual int Bearing { get; set; }
        public virtual decimal Distance { get; set; }
        public virtual string DistanceUnit { get; set; }
        public virtual int ActivityType { get; set; } // TODO Change to Enum
        public virtual string PhotoNumber { get; set; }
        public virtual string Comments { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }
    }
}
