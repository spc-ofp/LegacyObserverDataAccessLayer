// -----------------------------------------------------------------------
// <copyright file="PsFishingSetMap.cs" company="">
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
    public class PsFishingSetMap : ClassMap<PsFishingSet>
    {
        public PsFishingSetMap()
        {
            ReadOnly();
            Table("s_alog");
            Id(x => x.Id, "s_alog_id").GeneratedBy.Assigned();
            Map(x => x.SetNumber, "setno");
            //Map(x => x.DateOnly).Formula("date(actdate)");
            //In Postgres, use date_trunc to force to day only
            Map(x => x.DateOnly).Formula("date_trunc('day',actdate)");
            Map(x => x.TimeOnly, "acttime");
            Map(x => x.ld_onboard);
            Map(x => x.ld_ves_onb);
            Map(x => x.ld_tonnage);
            Map(x => x.ld_ves_ton);
            Map(x => x.IsFromThisSet, "oneset");
            Map(x => x.ld_newonboard, "ld_newonbo");
            Map(x => x.ld_ves_new);
            Map(x => x.tuna_catch);
            Map(x => x.ld_brails);
            Map(x => x.ld_brails2);
            Map(x => x.total_catch, "tot_catch");
            Map(x => x.WinchOn, "wnch_on");
            Map(x => x.RingsUp, "ring_up");
            Map(x => x.StartOfBrail, "sbrail");
            Map(x => x.EndOfBrail, "ebrail");
            Map(x => x.Stop, "stop");
            Map(x => x.b_nb_species, "b_nbspecies");
            Map(x => x.b_sp_id);
            Map(x => x.Comments, "ps3_comment");
            Map(x => x.SkipjackPercentage, "perc_skj");
            Map(x => x.YellowfinPercentage, "perc_yft");
            Map(x => x.BigeyePercentage, "perc_bet");
            Map(x => x.LargeBigeyePercentage, "perc_larg_bet");
            Map(x => x.LargeBigeyeCount, "nb_larg_bet");
            Map(x => x.LargeYellowfinPercentage, "perc_larg_yft");
            Map(x => x.LargeYellowfinCount, "nb_larg_yft");

            Map(x => x.RecoveredTagCount, "b_nbtags");

            Map(x => x.EnteredBy, "enteredby");
            Map(x => x.EnteredDate, "inserttime");
            //Map(x => x.EnteredDate).Formula("datetime(inserttime)");

            HasMany(x => x.SetCatchList).KeyColumn("s_alog_id");
            HasMany(x => x.LengthFrequencyHeaders).KeyColumn("s_alog_id");

            References(x => x.Day).Column("s_day_id");
            References(x => x.DailyEvent).Column("s_alog_id");
        }
    }
}
