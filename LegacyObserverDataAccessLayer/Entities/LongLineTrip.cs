// -----------------------------------------------------------------------
// <copyright file="LongLineTrip.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LongLineTrip : Trip
    {
        public LongLineTrip()
            : base()
        {
            FishingSets = new List<LonglineFishingSet>(32); // Guess for now
        }

        public virtual LonglineFishingGear FishingGear { get; set; }

        public virtual IList<LonglineFishingSet> FishingSets { get; protected internal set; }

        public virtual void AddFishingSet(LonglineFishingSet fset)
        {
            fset.Trip = this;
            this.FishingSets.Add(fset);
        }
    }
}
