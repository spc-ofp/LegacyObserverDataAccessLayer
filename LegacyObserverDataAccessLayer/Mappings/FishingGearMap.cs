// -----------------------------------------------------------------------
// <copyright file="FishingGearMap.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// Base mapping for all gear types.
    /// </summary>
    public abstract class BaseFishingGearMap<T> : ClassMap<T> where T : FishingGear
    {
        protected BaseFishingGearMap()
        {
            ReadOnly();
            Id(x => x.Id, "id").GeneratedBy.Assigned();
            References(x => x.Trip).Column("obstrip_id");
        }
    }

    public sealed class PsFishingGearMap : BaseFishingGearMap<PsFishingGear>
    {
        public PsFishingGearMap()
        {
            Table("s_gear");
            Map(x => x.PowerblockModel, "pb_model");
            Map(x => x.PowerblockPower, "pb_power");
            Map(x => x.PowerblockSpeed, "pb_speed");
            Map(x => x.PursewinchModel, "pw_model");
            Map(x => x.PursewinchPower, "pw_power");
            Map(x => x.PursewinchSpeed, "pw_speed");
            Map(x => x.NetDepth, "net_depth_m");
            Map(x => x.NetDepthUnits, "net_depth_unit");
            Map(x => x.NetLength, "net_length_m");
            Map(x => x.NetLengthUnits, "net_length_unit");
            Map(x => x.NetStrips, "net_strips");
            Map(x => x.MeshSize, "mesh_main");
            Map(x => x.MeshSizeUnits, "mesh_main_unit");
            Map(x => x.NetHangRatio, "net_hang");
            Map(x => x.Brail1Size, "brail_size");
            Map(x => x.Brail2Size, "brail_size2");
            Map(x => x.BrailDescription, "brail_type");
        }
    }

    public sealed class LonglineFishingGearMap : BaseFishingGearMap<LonglineFishingGear>
    {
        public LonglineFishingGearMap()
        {
            Table("l_gear");
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
        }
    }
}
