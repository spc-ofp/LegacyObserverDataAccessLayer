// -----------------------------------------------------------------------
// <copyright file="MarineDevice.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class MarineDevice
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Category { get; set; }
        public virtual string ListFor { get; set; }
        public virtual int? LongLineOrder { get; set; }
        public virtual int? PurseSeineOrder { get; set; }
        public virtual int? PoleAndLineOrder { get; set; }
    }
}
