// -----------------------------------------------------------------------
// <copyright file="PsWellContent.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using Spc.Ofp.Legacy.Observer.Common;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsWellContent
    {
        public virtual int Id { get; set; } // wc_id
        public virtual Trip Trip { get; set; }
        public virtual WellContentType WellContents { get; set; }
        public virtual int? WellNumber { get; set; }
        public virtual int? PortOrStarboard { get; set; }
        public virtual decimal? Capacity { get; set; }
        public virtual string Comments { get; set; }
    }
}
