// -----------------------------------------------------------------------
// <copyright file="LonglineSetHaulEventMap.cs" company="Secretariat of the Pacific Community">
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
    public class LonglineSetHaulEventMap : ClassMap<LonglineSetHaulEvent>
    {
        public LonglineSetHaulEventMap()
        {
            ReadOnly();
            Table("l_sh_log");
            Id(x => x.Id, "id").GeneratedBy.Assigned();
            Map(x => x.EventNumber, "eventno");
            Map(x => x.EventType, "set_haul");
            Map(x => x.DateOnly, "logdate");
            Map(x => x.TimeOnly, "logtime");
            Map(x => x.Latitude, "lat_long");
            Map(x => x.Longitude, "lon_long");
            Map(x => x.EezId, "ez_id");
            Map(x => x.WindDirection, "winddir");
            Map(x => x.WindSpeed, "wind_kts");
            Map(x => x.SeaCondition, "sea_id");
            Map(x => x.CloudCoverage, "cloud");
            Map(x => x.Comments, "\"comments\"");

            References(x => x.FishingSet).Column("l_shaul_id");
        }
    }
}
