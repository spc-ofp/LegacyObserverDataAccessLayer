// -----------------------------------------------------------------------
// <copyright file="MarineDevice.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
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
