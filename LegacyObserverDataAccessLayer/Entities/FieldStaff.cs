// -----------------------------------------------------------------------
// <copyright file="FieldStaff.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FieldStaff
    {
        public virtual string StaffCode { get; protected internal set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
