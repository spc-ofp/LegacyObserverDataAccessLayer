// -----------------------------------------------------------------------
// <copyright file="PsSetCatch.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsSetCatch
    {
        public virtual int Id { get; protected set; }

        public virtual PsFishingSet FishingSet { get; set; }

        public virtual PurseSeineTrip Trip { get; set; }

        public virtual string SpeciesCode { get; set; }

        public virtual bool? IsLargeFish { get; set; }

        public virtual string FateCode { get; set; }

        public virtual string ConditionCode { get; set; }

        public virtual bool YesNo { get; set; } // Not sure what this is

        public virtual decimal? PercentTotalCatch { get; set; }

        public virtual decimal? ObserverWeight { get; set; } // Observer Weight

        public virtual decimal? VesselWeight { get; set; } // Vessel Weight

        public virtual decimal? CalculatedSpeciesCatch { get; set; }

        public virtual int? ObserverCount { get; set; } // ObserverCount

        public virtual decimal? SpeciesWeightLow { get; set; } // Species Weight Low

        public virtual decimal? SpeciesWeightHigh { get; set; } // Species Weight High

        public virtual int? AverageLength { get; set; } // Average Length

        public virtual int? CountFromLog { get; set; } // vesslog

        public virtual string Comments { get; set; }

        public virtual string Tags { get; set; }

        public virtual decimal? SpeciesWeightEstimate { get; set; } // Species Weight Estimate

        public virtual int? AverageWeightMethodId { get; set; }

        public virtual decimal EstimatedSpeciesCatch { get; set; }

        public virtual int CatchWeightMethodId { get; set; }

        public virtual int EstimatedSpeciesCount { get; set; }
    }
}
