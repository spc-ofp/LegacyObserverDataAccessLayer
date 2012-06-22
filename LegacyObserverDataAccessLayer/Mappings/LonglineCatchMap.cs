// -----------------------------------------------------------------------
// <copyright file="LonglineCatchMap.cs" company="Secretariat of the Pacific Community">
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
    public class LonglineCatchMap : ClassMap<LonglineCatch>
    {
        public LonglineCatchMap()
        {
            ReadOnly();
            Table("l_cmon");
            Id(x => x.Id, "l_cmon_id").GeneratedBy.Assigned();
            Map(x => x.DateOnly, "cdate");
            Map(x => x.TimeOnly, "ctime");
            Map(x => x.SampleNumber, "sample_no");
            Map(x => x.HookNumber, "hook_no");
            Map(x => x.SpeciesCode, "sp_id");
            Map(x => x.ConditionCode, "cond_id");
            Map(x => x.DiscardedConditionCode, "cond_2_id");
            Map(x => x.FateCode, "fate_id");
            Map(x => x.Length, "len");
            Map(x => x.LengthCode, "len_id");
            Map(x => x.Weight, "wt");
            Map(x => x.EstimatedWeight, "wt_est");
            Map(x => x.EstimatedReleaseWeight, "wt_est_rel");
            Map(x => x.WeightCode, "wt_id");
            Map(x => x.SexCode, "sex_id");
            Map(x => x.Gonad, "gonad");
            Map(x => x.Comments, "\"comments\"");

            References(x => x.FishingSet).Column("l_shaul_id");
            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
