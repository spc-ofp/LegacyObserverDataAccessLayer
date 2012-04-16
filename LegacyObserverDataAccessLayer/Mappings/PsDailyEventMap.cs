// -----------------------------------------------------------------------
// <copyright file="PsDailyEventMap.cs" company="">
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
    public class PsDailyEventMap : ClassMap<PsDailyEvent>
    {
        public PsDailyEventMap()
        {
            ReadOnly();
            Table("s_alog");
            Id(x => x.Id, "s_alog_id").GeneratedBy.Identity();
            Map(x => x.DateOnly).Formula("date(actdate)");
            Map(x => x.TimeOnly, "acttime");
            Map(x => x.UtcDateOnly).Formula("date(utc_adate)");
            Map(x => x.UtcTimeOnly, "utc_atime");
            Map(x => x.Latitude, "lat_long");
            Map(x => x.Longitude, "lon_long");
            Map(x => x.EezId, "ez_id");
            Map(x => x.FishDays, "fish_days");
            Map(x => x.ActivityType, "s_act_id");
            Map(x => x.WindDirection, "winddir");
            Map(x => x.WindSpeed, "wind_kts");
            Map(x => x.SeaCondition, "sea_id");
            Map(x => x.AssociationType, "sch_id");
            Map(x => x.DetectionType, "det_id");
            Map(x => x.Beacon, "beacon");
            Map(x => x.Comments, "comment");
            
            Map(x => x.EnteredBy, "enteredby");
            Map(x => x.EnteredDate).Formula("datetime(inserttime)");

            References(x => x.Day).Column("s_day_id");
            HasOne(x => x.FishingSet).PropertyRef(r => r.DailyEvent).Cascade.All();
        }
    }
}
