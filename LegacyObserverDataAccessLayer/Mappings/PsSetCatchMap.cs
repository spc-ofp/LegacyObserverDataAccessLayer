// -----------------------------------------------------------------------
// <copyright file="PsSetCatchMap.cs" company="">
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
    public class PsSetCatchMap : ClassMap<PsSetCatch>
    {
        public PsSetCatchMap()
        {
            ReadOnly();
            Table("s_cmon");
            Id(x => x.Id, "s_cmon_id").GeneratedBy.Assigned();

            Map(x => x.SpeciesCode, "sp_id");
            Map(x => x.IsLargeFish, "largefish");
            Map(x => x.FateCode, "fate_id");
            Map(x => x.ConditionCode, "cond_id");
            Map(x => x.YesNo, "yesno");
            Map(x => x.PercentTotalCatch, "perc_totcatch");
            Map(x => x.ObserverWeight, "sp_c");
            Map(x => x.VesselWeight, "sp_c_ves");
            Map(x => x.CalculatedSpeciesCatch, "sp_c_spcomp"); // Calculated species catch
            Map(x => x.ObserverCount, "sp_n");
            Map(x => x.SpeciesWeightLow, "sp_w_l"); // Species average weight, low end of range
            Map(x => x.SpeciesWeightHigh, "sp_w_h"); // Species average weight, high end of range
            Map(x => x.AverageLength, "av_len");
            Map(x => x.CountFromLog, "vesslog");
            Map(x => x.Comments, "comments");
            Map(x => x.Tags, "tags");
            Map(x => x.SpeciesWeightEstimate, "sp_w_est"); // Estimate of average weight for this species.  To be used to estimate catch by number or weight
            Map(x => x.AverageWeightMethodId, "sp_w_id"); // Indicator showing which method used to estimate average weight
            Map(x => x.EstimatedSpeciesCatch, "sp_c_est"); // Best estimate of species catch (metric tonnes)
            Map(x => x.CatchWeightMethodId, "sp_c_id"); // Indicator showing which method used to estimate catch in weight
            Map(x => x.EstimatedSpeciesCount, "sp_n_est"); // Best estimate of species catch in number

            References(x => x.Trip).Column("obstrip_id");
            References(x => x.FishingSet).Column("s_alog_id");
        }
    }
}
