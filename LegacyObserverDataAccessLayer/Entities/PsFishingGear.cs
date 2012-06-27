// -----------------------------------------------------------------------
// <copyright file="PsFishingGear.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsFishingGear : FishingGear
    {
        public virtual string PowerblockModel { get; set; }
        public virtual int? PowerblockPower { get; set; }
        public virtual int? PowerblockSpeed { get; set; }
        public virtual string PursewinchModel { get; set; }
        public virtual int? PursewinchPower { get; set; }
        public virtual int? PursewinchSpeed { get; set; }
        public virtual int? NetDepth { get; set; }
        public virtual string NetDepthUnits { get; set; }
        public virtual int? NetLength { get; set; }
        public virtual string NetLengthUnits { get; set; }
        public virtual int? NetStrips { get; set; }
        public virtual int? MeshSize { get; set; }
        public virtual string MeshSizeUnits { get; set; }
        public virtual int? NetHangRatio { get; set; }
        public virtual decimal? Brail1Size { get; set; }
        public virtual decimal? Brail2Size { get; set; }
        public virtual string BrailDescription { get; set; }
    }
}
