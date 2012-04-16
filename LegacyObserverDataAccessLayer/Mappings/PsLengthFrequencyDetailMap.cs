// -----------------------------------------------------------------------
// <copyright file="PsLengthFrequencyDetailMap.cs" company="">
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
    public class PsLengthFrequencyDetailMap :ClassMap<PsLengthFrequencyDetail>
    {
        public PsLengthFrequencyDetailMap()
        {
            ReadOnly();
            Table("s_lfreq");
            Id(x => x.Id, "id");
            Map(x => x.SampleNumber, "sample_no");
            Map(x => x.SpeciesCode, "sp_id");
            Map(x => x.Length, "len");

            References(x => x.Header).Column("s_lfreq_id");
            References(x => x.FishingSet).Column("s_alog_id");
        }
    }
}
