// -----------------------------------------------------------------------
// <copyright file="PsFishingGear.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsFishingGear
    {
        public virtual int Id { get; set; }
        public virtual Trip Trip { get; set; }
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
