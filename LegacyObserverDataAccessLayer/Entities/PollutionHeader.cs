// -----------------------------------------------------------------------
// <copyright file="PollutionHeader.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using System.Collections.Generic;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// The Gen-6 form is split across two entities:  This class (PollutionHeader)
    /// and a collection of PollutionDetail records.
    /// </summary>
    public class PollutionHeader
    {
        public PollutionHeader()
        {
            Details = new List<PollutionDetail>();
        }
        
        public virtual int Id { get; protected set; }

        public virtual Trip Trip { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual string Latitude { get; set; }

        public virtual string Longitude { get; set; }

        public virtual string EezId { get; set; }

        public virtual int? WindDirection { get; set; }

        public virtual int? WindSpeed { get; set; }

        public virtual string SeaCondition { get; set; } // TODO Enum

        public virtual decimal? CurrentSpeed { get; set; }

        public virtual int? CurrentDirection { get; set; }

        public virtual int? ActivityType { get; set; } // TODO Enum

        public virtual string VesselName { get; set; }

        public virtual string Ircs { get; set; }

        public virtual int? VesselType { get; set; } // TODO Enum

        public virtual int? Bearing { get; set; }

        public virtual decimal? Distance { get; set; }

        public virtual bool? Stickers { get; set; }

        public virtual bool? Marpol { get; set; }

        public virtual bool? Infringement { get; set; }

        public virtual bool? HasPhotos { get; set; }

        public virtual string Comments { get; set; }

        public virtual IList<PollutionDetail> Details { get; protected internal set; }

        public virtual void AddDetail(PollutionDetail detail)
        {
            detail.Header = this;
            this.Details.Add(detail);
        }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }
    }
}
