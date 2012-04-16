// -----------------------------------------------------------------------
// <copyright file="SightingMap.cs" company="">
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
    public class SightingMap : ClassMap<Sighting>
    {
        public SightingMap()
        {
            ReadOnly();
            Table("aircraftsight");
            Id(x => x.Id, "id").GeneratedBy.Native();
            Map(x => x.DateOnly, "date");
            Map(x => x.TimeOnly, "time");
            Map(x => x.Latitude, "lat");
            Map(x => x.Longitude, "lon");
            Map(x => x.EezId, "ez_id");
            Map(x => x.Name, "s_name");
            Map(x => x.CallSign, "s_callsign");
            Map(x => x.FlagCode, "s_flag");
            Map(x => x.VesselType, "s_type");
            Map(x => x.Bearing, "bearing");
            Map(x => x.Distance, "distance");
            Map(x => x.DistanceUnit, "dist_unit");
            Map(x => x.ActivityType, "activity");
            Map(x => x.PhotoNumber, "photo_no");
            Map(x => x.Comments, "comment");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
