// -----------------------------------------------------------------------
// <copyright file="LonglineCatch.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using System.Collections.Generic;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// From table l_cmon
    /// </summary>
    public class LonglineCatch
    {
        public virtual int Id { get; protected set; }

        public virtual Trip Trip { get; set; }
        public virtual LonglineFishingSet FishingSet { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual int? SampleNumber { get; set; }

        public virtual int? HookNumber { get; set; }

        public virtual string SpeciesCode { get; set; }

        public virtual string ConditionCode { get; set; }

        public virtual string DiscardedConditionCode { get; set; }

        public virtual string FateCode { get; set; }

        public virtual int? Length { get; set; }

        public virtual string LengthCode { get; set; }

        public virtual int? Weight { get; set; }

        public virtual int? EstimatedWeight { get; set; }

        public virtual int? EstimatedWeightReliability { get; set; }

        public virtual string WeightCode { get; set; }

        public virtual string SexCode { get; set; }

        public virtual string GonadStage { get; set; }

        public virtual string Comments { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }

    }
}
