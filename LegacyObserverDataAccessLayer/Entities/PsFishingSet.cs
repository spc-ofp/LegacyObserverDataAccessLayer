// -----------------------------------------------------------------------
// <copyright file="PsFishingSet.cs" company="Secretariat of the Pacific Community">
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
    public class PsFishingSet
    {
        public PsFishingSet()
        {
            SetCatchList = new List<PsSetCatch>(16);
            LengthFrequencyHeaders = new List<PsLengthFrequencyHeader>(8);
        }
        
        public virtual int Id { get; protected set; }

        public virtual PsDay Day { get; set; }

        public virtual PsDailyEvent DailyEvent { get; set; }

        public virtual int? SetNumber { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual decimal? ld_onboard { get; set; }

        public virtual decimal? ld_ves_onb { get; set; }

        public virtual decimal? ld_tonnage { get; set; }

        public virtual decimal? ld_ves_ton { get; set; }

        public virtual bool? IsFromThisSet { get; set; }

        public virtual decimal? ld_newonboard { get; set; }

        public virtual decimal? ld_ves_new { get; set; }

        public virtual decimal? tuna_catch { get; set; }

        public virtual decimal? ld_brails { get; set; }

        public virtual decimal? ld_brails2 { get; set; }

        public virtual decimal? total_catch { get; set; }

        public virtual string WinchOn { get; set; } // We'd really like this to be a TimeSpan

        public virtual string RingsUp { get; set; } // We'd really like this to be a TimeSpan

        public virtual string StartOfBrail { get; set; }

        public virtual string EndOfBrail { get; set; }

        public virtual string Stop { get; set; }

        public virtual int? b_nb_species { get; set; }

        public virtual string b_sp_id { get; set; }

        public virtual string Comments { get; set; }

        public virtual int? SkipjackPercentage { get; set; }

        public virtual int? YellowfinPercentage { get; set; }

        public virtual int? BigeyePercentage { get; set; }

        public virtual int? LargeYellowfinPercentage { get; set; }

        public virtual int? LargeYellowfinCount { get; set; }

        public virtual int? LargeBigeyePercentage { get; set; }

        public virtual int? LargeBigeyeCount { get; set; }

        public virtual int? RecoveredTagCount { get; set; }

        public virtual IList<PsSetCatch> SetCatchList { get; protected internal set; }

        public virtual IList<PsLengthFrequencyHeader> LengthFrequencyHeaders { get; protected internal set; }

        public virtual DateTime? EnteredDate { get; set; }

        public virtual string EnteredBy { get; set; }

        public virtual void AddSetCatch(PsSetCatch setcatch)
        {
            setcatch.FishingSet = this;
            this.SetCatchList.Add(setcatch);
        }

        public virtual void AddLengthFrequencyHeader(PsLengthFrequencyHeader header)
        {
            header.FishingSet = this;
            this.LengthFrequencyHeaders.Add(header);
        }

        public virtual bool? ContainsSkipjack
        {
            get
            {
                if (!this.SkipjackPercentage.HasValue)
                    return null;

                return this.SkipjackPercentage.Value > 0;
            }
        }

        public virtual bool? ContainsYellowfin
        {
            get
            {
                if (!this.YellowfinPercentage.HasValue)
                    return null;

                return this.YellowfinPercentage.Value > 0;
            }
        }

        public virtual bool? ContainsBigeye
        {
            get
            {
                if (!this.BigeyePercentage.HasValue)
                    return null;

                return this.BigeyePercentage.Value > 0;
            }
        }

        
    }
}
