// -----------------------------------------------------------------------
// <copyright file="LonglineFishingGear.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineFishingGear : FishingGear
    {
        public virtual bool? HasMainlineHauler { get; set; }
        public virtual string MainlineHaulerComments { get; set; }

        public virtual bool? HasBranchlineHauler { get; set; }
        public virtual string BranchlineHaulerComments { get; set; }

        public virtual bool? HasLineShooter { get; set; }
        public virtual string LineShooterComments { get; set; }

        public virtual bool? HasBaitThrower { get; set; }
        public virtual string BaitThrowerComments { get; set; }

        public virtual bool? HasBranchlineAttacher { get; set; }
        public virtual string BranchlineAttacherComments { get; set; }

        public virtual bool? HasWeighingScales { get; set; }
        public virtual string WeighingScalesComments { get; set; }

        public virtual string MainlineComposition { get; set; }
        public virtual string BranchlineComposition { get; set; }
        public virtual string MainlineMaterial { get; set; }
        public virtual int? MainlineLength { get; set; }
        public virtual decimal? MainlineDiameter { get; set; }
        public virtual string BranchlineMaterial1 { get; set; }
        public virtual string BranchlineMaterial2 { get; set; }
        public virtual string BranchlineMaterial3 { get; set; }
        public virtual bool? HasWireTrace { get; set; }

        public virtual bool? HasRefrigeratedSeawater { get; set; }
        public virtual bool? HasChilledSeawater { get; set; }
        public virtual bool? HasBlastFreezer { get; set; }
        public virtual bool? HasIce { get; set; }
        public virtual bool? HasOtherStorage { get; set; }

        public virtual string JapanHookSize { get; set; }
        public virtual int? JapanHookPercentage { get; set; }

        public virtual string CircleHookSize { get; set; }
        public virtual int? CircleHookPercentage { get; set; }

        public virtual string JHookSize { get; set; }
        public virtual int? JHookPercentage { get; set; }

        public virtual string OtherHookType { get; set; }
        public virtual string OtherHookSize { get; set; }
        public virtual int? OtherHookPercentage { get; set; }

    }
}
