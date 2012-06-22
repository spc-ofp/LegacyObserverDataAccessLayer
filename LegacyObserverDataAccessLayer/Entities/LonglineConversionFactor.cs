// -----------------------------------------------------------------------
// <copyright file="LonglineConversionFactor.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineConversionFactor
    {
        public virtual int Id { get; protected set; }

        public virtual LonglineFishingSet FishingSet { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual string SpeciesCode { get; set; }

        public virtual string LabelNumber { get; set; }
    }
}
