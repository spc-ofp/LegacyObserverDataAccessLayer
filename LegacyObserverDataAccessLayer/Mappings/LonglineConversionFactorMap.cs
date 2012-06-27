// -----------------------------------------------------------------------
// <copyright file="LonglineConversionFactorMap.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineConversionFactorMap : ClassMap<LonglineConversionFactor>
    {
        public LonglineConversionFactorMap()
        {
            ReadOnly();
            Table("l_sh_log");
            Id(x => x.Id, "id").GeneratedBy.Assigned();
            Map(x => x.DateOnly, "cdate");
            Map(x => x.TimeOnly, "ctime");
            Map(x => x.SpeciesCode, "sp_id");
            Map(x => x.LabelNumber, "label_no");
            Map(x => x.TtLength, "len_tt");
            Map(x => x.UfLength, "len_uf");
            Map(x => x.UsLength, "len_us");
            Map(x => x.LfLength, "len_lf");
            Map(x => x.PfLength, "len_pf");
            Map(x => x.PsLength, "len_ps");
            Map(x => x.SlLength, "len_sl");
            Map(x => x.EoLength, "len_eo");
            Map(x => x.CkLength, "len_ck");
            Map(x => x.TlLength, "len_tl");
            Map(x => x.CuLength, "len_cu");
            Map(x => x.WwWeight, "wt_ww").Precision(8).Scale(3);
            Map(x => x.HeadWeight, "wt_head").Precision(8).Scale(3);
            Map(x => x.TailWeight, "wt_tail").Precision(8).Scale(3);
            Map(x => x.GutsWeight, "wt_guts").Precision(8).Scale(3);            
            Map(x => x.ProcessedWeight, "wt_pr").Precision(8).Scale(3);
            Map(x => x.ProcessedWeightCode, "wr_pr_id");
            Map(x => x.LandedWeight, "wt_ld").Precision(8).Scale(3);
            Map(x => x.LandedWeightCode, "wt_ld_id");

            References(x => x.FishingSet).Column("l_shaul_id");
        }
    }
}
