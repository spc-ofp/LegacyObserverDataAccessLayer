// -----------------------------------------------------------------------
// <copyright file="PsLengthFrequencyHeaderMap.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsLengthFrequencyHeaderMap : ClassMap<PsLengthFrequencyHeader>
    {
        public PsLengthFrequencyHeaderMap()
        {
            ReadOnly();
            Table("s_lf_h");
            Id(x => x.Id, "s_lfreq_id").GeneratedBy.Native();

            //Map(x => x.PagesInSet, "page_no");
            Map(x => x.TotalBrails, "tbrail");
            //Map(x => x.NumberOfBrailsSampled, "nbrail"); // Ignore
            Map(x => x.FishPerBrail, "fish_brl");
            Map(x => x.FullBrailCount, "brail_full");
            Map(x => x.SevenEighthsBrailCount, "brail_78");
            Map(x => x.ThreeQuartersBrailCount, "brail_34");
            Map(x => x.TwoThirdsBrailCount, "brail_23");
            Map(x => x.OneHalfBrailCount, "brail_12");
            Map(x => x.OneThirdBrailCount, "brail_13");
            Map(x => x.OneQuarterBrailCount, "brail_14");
            Map(x => x.OneEighthBrailCount, "brail_18");
            Map(x => x.Measure, "measure");
            Map(x => x.Protocol, "protocol");
            Map(x => x.SumOfBrails, "sum_brails");
            Map(x => x.ProtocolComments, "prot_comments");
            Map(x => x.SampleType, "samptype");
            Map(x => x.WhichBrail, "whichbrail");
            Map(x => x.PageNumber, "nbformused"); // Page X...
            Map(x => x.TotalPages, "totused"); // ...of Y
            Map(x => x.EnteredBy, "enteredby");
            Map(x => x.EnteredDate).Formula("datetime(inserttime)");  //, "inserttime");

            HasMany(x => x.Details).KeyColumn("s_lfreq_id");
        }
    }
}
