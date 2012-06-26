// -----------------------------------------------------------------------
// <copyright file="PsLengthFrequencyHeader.cs" company="Secretariat of the Pacific Community">
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
    public class PsLengthFrequencyHeader
    {
        public PsLengthFrequencyHeader()
        {
            Details = new List<PsLengthFrequencyDetail>(255);
        }
        
        public virtual int Id { get; protected set; }

        public virtual PsFishingSet FishingSet { get; set; }

        //public virtual int? PagesInSet { get; set; }

        public virtual int? TotalBrails { get; set; }

        public virtual int? NumberOfBrailsSampled { get; set; }

        public virtual int? FishPerBrail { get; set; }

        public virtual int? FullBrailCount { get; set; }

        public virtual int? SevenEighthsBrailCount { get; set; }

        public virtual int? ThreeQuartersBrailCount { get; set; }

        public virtual int? TwoThirdsBrailCount { get; set; }

        public virtual int? OneHalfBrailCount { get; set; }

        public virtual int? OneThirdBrailCount { get; set; }

        public virtual int? OneQuarterBrailCount { get; set; }

        public virtual int? OneEighthBrailCount { get; set; }

        public virtual string MeasuringInstrument { get; set; }

        public virtual string Protocol { get; set; }

        public virtual decimal? SumOfBrails { get; set; }

        public virtual string ProtocolComments { get; set; }

        public virtual string OtherSample { get; set; }

        public virtual int? SampleType { get; set; }

        public virtual int? WhichBrail { get; set; }

        public virtual int? PageNumber { get; set; }

        public virtual int? TotalPages { get; set; }

        // New fields (v2009?)
        public virtual decimal? SumOfBrailsForPage { get; set; }

        public virtual int? TotalBrailsForPage { get; set; }

        public virtual int? NumberOfFishSampled { get; set; }

        public virtual string BrailStart { get; set; }

        public virtual string BrailEnd { get; set; }

        public virtual string EnteredBy { get; set; }

        public virtual DateTime? EnteredDate { get; set; }

        public virtual IList<PsLengthFrequencyDetail> Details { get; protected internal set; }
    }
}
