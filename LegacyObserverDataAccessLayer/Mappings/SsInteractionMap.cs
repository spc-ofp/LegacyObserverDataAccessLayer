// -----------------------------------------------------------------------
// <copyright file="SsInteractionMap.cs" company="">
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
    public class SsInteractionMap : ClassMap<SsInteraction>
    {
        public SsInteractionMap()
        {
            ReadOnly();
            Table("special_species");
            Id(x => x.Id, "id").GeneratedBy.Native();
            Map(x => x.Landed, "landed");
            Map(x => x.LandedDateOnly, "date_land");
            Map(x => x.LandedTimeOnly, "time_land");
            Map(x => x.DateOnly, "date_inter");
            Map(x => x.TimeOnly, "time_inter");
            Map(x => x.Latitude, "lat");
            Map(x => x.Longitude, "lon");
            Map(x => x.SpeciesCode, "sp_id");
            Map(x => x.SpeciesDescription, "sp_desc");
            Map(x => x.LandedConditionCode, "ld_cond_id");
            Map(x => x.LandedConditionDescription, "ld_cond_desc");
            Map(x => x.LandedHandling, "ld_handling");
            Map(x => x.LandedLength, "ld_len");
            Map(x => x.LandedLengthCode, "ld_len_code");
            Map(x => x.LandedSex, "ld_sex");
            Map(x => x.DiscardedConditionCode, "dsc_cond_id");
            Map(x => x.DiscardedConditionDescription, "dsc_cond_desc");
            Map(x => x.RetrievedTagNumber, "tag_ret_no");
            Map(x => x.RetrievedTagType, "tag_ret_type");
            Map(x => x.RetrievedTagOrganization, "tag_ret_org");
            Map(x => x.PlacedTagNumber, "tag_pla_no");
            Map(x => x.PlacedTagType, "tag_pla_type");
            Map(x => x.PlacedTagOrganization, "tag_pla_org");
            Map(x => x.VesselActivity, "vess_act");
            Map(x => x.VesselActivityOther, "vess_act_oth");
            Map(x => x.InteractionConditionCode, "int_cond_id");
            Map(x => x.InteractionConditionDescription, "int_cond_desc");
            Map(x => x.InteractionDescription, "int_describe");
            Map(x => x.SightingActivity, "sgt_act");
            Map(x => x.SightingActivityOther, "sgt_act_oth");
            Map(x => x.SightingCount, "sgt_nb");
            Map(x => x.SightingAdultCount, "sgt_nb_ad");
            Map(x => x.SightingJuvenileCount, "sgt_nb_ju");
            Map(x => x.SightingLength, "sgt_len");
            Map(x => x.SightingDistance, "sgt_dist");
            Map(x => x.SightingDistanceUnit, "sgt_dis_unit");
            Map(x => x.SightingBehavior, "sgt_behav");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
