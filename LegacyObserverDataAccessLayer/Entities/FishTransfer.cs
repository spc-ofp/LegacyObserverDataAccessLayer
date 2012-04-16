// -----------------------------------------------------------------------
// <copyright file="FishTransfer.cs" company="">
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
    public class FishTransfer
    {
        public virtual int Id { get; protected set; }
        public virtual Trip Trip { get; set; }
        public virtual DateTime? DateOnly { get; set; }
        public virtual string TimeOnly { get; set; }
        public virtual string Latitude { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string Name { get; set; }
        public virtual string CallSign { get; set; }
        public virtual string FlagCode { get; set; }
        public virtual int? VesselType { get; set; } // TODO Change to Enum
        public virtual string TransferType { get; set; } // TODO Change to Enum
        public virtual decimal? TonsOfSkipjack { get; set; }
        public virtual decimal? TonsOfYellowfin { get; set; }
        public virtual decimal? TonsOfBigeye { get; set; }
        public virtual decimal? TonsOfMixed { get; set; }
        public virtual string Comments { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }
    }
}
