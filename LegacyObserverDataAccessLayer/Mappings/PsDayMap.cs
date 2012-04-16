// -----------------------------------------------------------------------
// <copyright file="PsDayMap.cs" company="">
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
    public class PsDayMap : ClassMap<PsDay>
    {
        public PsDayMap()
        {
            ReadOnly();
            Table("s_day");
            Id(x => x.Id, "s_day_id").GeneratedBy.Assigned();
            Map(x => x.DateOnly, "daydate");
            Map(x => x.TimeOnly, "daytime");
            Map(x => x.UtcDateOnly, "utc_date");
            Map(x => x.UtcTimeOnly, "utc_time");
            Map(x => x.LogNoFish, "lognofsh");
            Map(x => x.LogFish, "log_fsh");
            Map(x => x.FreeSchools, "sch_fsh");
            Map(x => x.FadFish, "fad_fsh");
            Map(x => x.FadNoFish, "fadnofsh");

            HasMany(x => x.LogEntries).KeyColumn("s_day_id");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
