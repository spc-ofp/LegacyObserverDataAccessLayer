// -----------------------------------------------------------------------
// <copyright file="PsLengthFrequencyDetail.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsLengthFrequencyDetail
    {
        public virtual int Id { get; protected set; }

        public virtual PsLengthFrequencyHeader Header { get; set; }

        public virtual PsFishingSet FishingSet { get; set; }

        public virtual int? SampleNumber { get; set; }

        public virtual string SpeciesCode { get; set; }

        public virtual int? Length { get; set; }
    }
}
