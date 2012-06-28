// -----------------------------------------------------------------------
// <copyright file="LonglineConversionFactor.cs" company="Microsoft">
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
    public class LonglineConversionFactor
    {
        public virtual int Id { get; protected set; }

        public virtual LonglineFishingSet FishingSet { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual string SpeciesCode { get; set; }

        public virtual string LabelNumber { get; set; }

        public virtual int? TtLength { get; set; }

        public virtual int? UfLength { get; set; }

        public virtual int? UsLength { get; set; }

        public virtual int? LfLength { get; set; }

        public virtual int? PfLength { get; set; }

        public virtual int? PsLength { get; set; }

        public virtual int? SlLength { get; set; }

        public virtual int? EoLength { get; set; }

        public virtual int? CkLength { get; set; }

        public virtual int? TlLength { get; set; }

        public virtual int? CuLength { get; set; }

        public virtual decimal? WwWeight { get; set; }

        public virtual decimal? HeadWeight { get; set; }

        public virtual decimal? TailWeight { get; set; }

        public virtual decimal? GutsWeight { get; set; }

        public virtual decimal ProcessedWeight { get; set; }

        public virtual string ProcessedWeightCode { get; set; }

        public virtual decimal? LandedWeight { get; set; }

        public virtual string LandedWeightCode { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }
    }
}
