// -----------------------------------------------------------------------
// <copyright file="LonglineFishingSetMap.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using System;
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineFishingSetMap : ClassMap<LonglineFishingSet>
    {
        public LonglineFishingSetMap()
        {
            ReadOnly();
            Table("l_sethaul");
            Id(x => x.Id, "l_shaul_id").GeneratedBy.Assigned();
            Map(x => x.SetNumber, "set_id");
            Map(x => x.DateOnly, "setdate");
            Map(x => x.TimeOnly, "settime");
            Map(x => x.UtcDateOnly, "utc_sdate");
            Map(x => x.UtcTimeOnly, "utc_stime");
            Map(x => x.TargetSpeciesCode, "tar_sp_id").Length(3);
            Map(x => x.HooksPerBasket, "hk_bt_flt");
            Map(x => x.TotalBasketCount, "bask");
            Map(x => x.TotalHookCount, "hook_set");
            Map(x => x.FloatlineLength, "\"float\"");
            Map(x => x.LineSettingSpeed, "lspeed");
            Map(x => x.LineSettingSpeedUnit, "linesp_unit");
            Map(x => x.VesselSpeed, "vspeed");
            Map(x => x.BranchlineSetInterval, "tbranch");
            Map(x => x.DistanceBetweenBranchlines, "dist");
            Map(x => x.BranchlineLength, "branch");
            Map(x => x.SharkLineCount, "nbshark_lines");
            Map(x => x.SharkLineLength, "tdr_len");
            Map(x => x.TdrDeployed, "tdr_deployed");
            Map(x => x.TotalHooksObserved, "hook");
            Map(x => x.TotalBasketsObserved, "baskobs");
            Map(x => x.LightStickCount, "lightsticks");
            Map(x => x.HasGen3Event, "event");
            Map(x => x.AllPositionsDirectlyObserved, "obsv_direct");
            Map(x => x.MeasuringInstrument, "measureinst");

            Map(x => x.BaitSpecies1Code, "bait1_sp_id");
            Map(x => x.BaitSpecies1Weight, "bait1_w");
            Map(x => x.BaitSpecies1Hooks, "bait1_h");

            Map(x => x.BaitSpecies2Code, "bait2_sp_id");
            Map(x => x.BaitSpecies2Weight, "bait2_w");
            Map(x => x.BaitSpecies2Hooks, "bait2_h");

            Map(x => x.BaitSpecies3Code, "bait3_sp_id");
            Map(x => x.BaitSpecies3Weight, "bait3_w");
            Map(x => x.BaitSpecies3Hooks, "bait3_h");

            Map(x => x.BaitSpecies4Code, "bait4_sp_id");
            Map(x => x.BaitSpecies4Weight, "bait4_w");
            Map(x => x.BaitSpecies4Hooks, "bait4_h");

            Map(x => x.BaitSpecies5Code, "bait5_sp_id");
            Map(x => x.BaitSpecies5Weight, "bait5_w");
            Map(x => x.BaitSpecies5Hooks, "bait5_h");

            Map(x => x.SetDetails, "setdetails");

            HasMany(x => x.CatchList).KeyColumn("l_shaul_id");
            HasMany(x => x.EventList).KeyColumn("l_shaul_id");
            HasMany(x => x.ConversionFactors).KeyColumn("l_shaul_id");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
