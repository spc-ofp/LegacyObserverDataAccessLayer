// -----------------------------------------------------------------------
// <copyright file="PollutionHeaderMap.cs" company="">
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
    public class PollutionHeaderMap : ClassMap<PollutionHeader>
    {
        public PollutionHeaderMap()
        {
            ReadOnly();
            Table("gen6_pollution_h");
            Id(x => x.Id, "poll_h_id").GeneratedBy.Identity();
            Map(x => x.DateOnly, "date");
            Map(x => x.TimeOnly, "time");
            Map(x => x.Latitude, "lat");
            Map(x => x.Longitude, "lon");
            Map(x => x.EezId, "ez_id");
            Map(x => x.WindDirection, "winddir");
            Map(x => x.WindSpeed, "windspeed");
            Map(x => x.SeaCondition, "seacond");
            Map(x => x.CurrentSpeed, "current");
            Map(x => x.CurrentDirection, "currentdir");
            Map(x => x.ActivityType, "act_id");
            Map(x => x.VesselName, "vesselname");
            Map(x => x.Ircs, "ircs");
            Map(x => x.VesselType, "vesseltype_id");
            Map(x => x.Bearing, "bearing");
            Map(x => x.Distance, "distance");
            Map(x => x.Stickers, "stickers");
            Map(x => x.Marpol, "marpol");
            Map(x => x.Infringement, "infringements");
            Map(x => x.HasPhotos, "photos");
            Map(x => x.Comments);

            HasMany(x => x.Details).KeyColumn("poll_h_id");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
