// -----------------------------------------------------------------------
// <copyright file="PsLengthFrequencyHeader.cs" company="">
// TODO: Update copyright text.
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

        //public virtual int? NumberOfBrailsSampled { get; set; }

        public virtual int? FishPerBrail { get; set; }

        public virtual int? FullBrailCount { get; set; }

        public virtual int? SevenEighthsBrailCount { get; set; }

        public virtual int? ThreeQuartersBrailCount { get; set; }

        public virtual int? TwoThirdsBrailCount { get; set; }

        public virtual int? OneHalfBrailCount { get; set; }

        public virtual int? OneThirdBrailCount { get; set; }

        public virtual int? OneQuarterBrailCount { get; set; }

        public virtual int? OneEighthBrailCount { get; set; }

        public virtual string Measure { get; set; }

        public virtual string Protocol { get; set; }

        public virtual decimal? SumOfBrails { get; set; }

        public virtual string ProtocolComments { get; set; }

        public virtual int? SampleType { get; set; }

        public virtual int? WhichBrail { get; set; }

        public virtual int? PageNumber { get; set; }

        public virtual int? TotalPages { get; set; }

        public virtual string EnteredBy { get; set; }

        public virtual DateTime? EnteredDate { get; set; }

        public virtual IList<PsLengthFrequencyDetail> Details { get; protected internal set; }
    }
}
