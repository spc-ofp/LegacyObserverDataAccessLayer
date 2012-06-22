// -----------------------------------------------------------------------
// <copyright file="PsFishingGearMap.cs" company="Secretariat of the Pacific Community">
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
    public class PsFishingGearMap : ClassMap<PsFishingGear>
    {
        public PsFishingGearMap()
        {
            ReadOnly();
            Table("s_gear");
            Id(x => x.Id, "id").GeneratedBy.Assigned();
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

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
