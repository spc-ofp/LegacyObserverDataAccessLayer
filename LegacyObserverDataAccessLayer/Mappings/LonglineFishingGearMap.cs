// -----------------------------------------------------------------------
// <copyright file="LonglineFishingGearMap.cs" company="Secretariat of the Pacific Community">
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
    public sealed class LonglineFishingGearMap : ClassMap<LonglineFishingGear>
    {
        public LonglineFishingGearMap()
        {
            ReadOnly();
            Table("l_gear");
            Id(x => x.Id, "id").GeneratedBy.Assigned();
            Map(x => x.HasMainlineHauler, "mline_haul").CustomType<YesNoType>();
            Map(x => x.MainlineHaulerComments, "c_mline_haul");
            Map(x => x.HasBranchlineHauler, "bline_haul").CustomType<YesNoType>();
            Map(x => x.BranchlineHaulerComments, "c_bline_haul");
            Map(x => x.HasLineShooter, "lshoot").CustomType<YesNoType>();
            Map(x => x.LineShooterComments, "c_lshoot");
            Map(x => x.HasBaitThrower, "bait_thr").CustomType<YesNoType>();
            Map(x => x.BaitThrowerComments, "c_bait_thr");
            Map(x => x.HasBranchlineAttacher, "branch_att").CustomType<YesNoType>();
            Map(x => x.BranchlineAttacherComments, "c_branch_att");
            Map(x => x.HasWeighingScales, "weight_sca").CustomType<YesNoType>();
            Map(x => x.WeighingScalesComments, "c_weight_sca");
            Map(x => x.MainlineComposition, "mainl_comp");
            Map(x => x.BranchlineComposition, "bline_comp");
            Map(x => x.MainlineMaterial, "mainl_mat").Length(15);
            Map(x => x.MainlineLength, "mainl_len");
            Map(x => x.MainlineDiameter, "mainl_diam").Precision(8).Scale(3);
            Map(x => x.BranchlineMaterial1, "bline_mat1");
            Map(x => x.BranchlineMaterial2, "bline_mat2");
            Map(x => x.BranchlineMaterial3, "bline_mat3");
            Map(x => x.HasWireTrace, "wire_trace").CustomType<YesNoType>();
            Map(x => x.HasRefrigeratedSeawater, "sea_water").CustomType<YesNoType>();
            Map(x => x.HasBlastFreezer, "blast_freezer").CustomType<YesNoType>();
            Map(x => x.HasIce, "ice").CustomType<YesNoType>();
            Map(x => x.HasChilledSeawater, "chilled_sea_water").CustomType<YesNoType>();
            Map(x => x.HasOtherStorage, "oth_storage").CustomType<YesNoType>();
            Map(x => x.JapanHookSize, "hk_japan_s");
            Map(x => x.JapanHookPercentage, "hk_japan_p");
            Map(x => x.CircleHookSize, "hk_circle_s");
            Map(x => x.CircleHookPercentage, "hk_circle_p");
            Map(x => x.JHookSize, "hk_j_s");
            Map(x => x.JHookPercentage, "hk_j_p");
            Map(x => x.OtherHookType, "hk_other_t");
            Map(x => x.OtherHookSize, "hk_other_s");
            Map(x => x.OtherHookPercentage, "hk_other_p");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
