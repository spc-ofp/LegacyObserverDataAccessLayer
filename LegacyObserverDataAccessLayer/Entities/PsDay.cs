// -----------------------------------------------------------------------
// <copyright file="PsDay.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using System.Collections.Generic;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsDay
    {
        public PsDay()
        {
            LogEntries = new List<PsDailyEvent>(16); // Assume 16 events
            FishingSets = new List<PsFishingSet>(8); // Assume 8 sets
        }
        
        public virtual int Id { get; protected set; }

        public virtual PurseSeineTrip Trip { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual DateTime? UtcDateOnly { get; set; }

        public virtual string UtcTimeOnly { get; set; }

        public virtual int? LogNoFish { get; set; }

        public virtual int? LogFish { get; set; }

        public virtual int? FreeSchools { get; set; }

        public virtual int? FadFish { get; set; }

        public virtual int? FadNoFish { get; set; }

        public virtual bool? HasGen3Event { get; set; }

        public virtual int? JournalPage { get; set; }

        public virtual IList<PsDailyEvent> LogEntries { get; protected internal set; }

        public virtual IList<PsFishingSet> FishingSets { get; protected internal set; }

        public virtual void AddEntry(PsDailyEvent entry)
        {
            entry.Day = this;
            this.LogEntries.Add(entry);
        }

        public virtual void AddFishingSet(PsFishingSet fset)
        {
            fset.Day = this;
            this.FishingSets.Add(fset);
        }

        public virtual DateTime? GetDate()
        {
            return this.DateOnly.Combine(this.TimeOnly);
        }

        public virtual DateTime? GetUtcDate()
        {
            return this.UtcDateOnly.Combine(this.UtcTimeOnly);
        }
    }
}
