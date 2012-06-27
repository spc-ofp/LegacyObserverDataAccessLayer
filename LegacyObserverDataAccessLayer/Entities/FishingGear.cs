// -----------------------------------------------------------------------
// <copyright file="FishingGear.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2011 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class FishingGear
    {
        public virtual int Id { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
