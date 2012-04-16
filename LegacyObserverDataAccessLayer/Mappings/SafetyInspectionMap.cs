// -----------------------------------------------------------------------
// <copyright file="SafetyInspectionMap.cs" company="">
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
    public class SafetyInspectionMap : ClassMap<SafetyInspection>
    {
        public SafetyInspectionMap()
        {
            ReadOnly();
            Table("safety");
            Id(x => x.Id, "safety_id").GeneratedBy.Assigned();
            Map(x => x.LifejacketProvided, "lj_provid");
            Map(x => x.LifejacketSizeOk, "lj_sizeok");
            Map(x => x.LifejacketsAvailable, "lj_avail");
            Map(x => x.BuoyCount, "nbbuoys");
            Map(x => x.Epi1Type, "epi1_type");
            Map(x => x.Epi1Count, "epi1_no");
            Map(x => x.Epi2Type, "epi2_type");
            Map(x => x.Epi2Count, "epi2_no");
            Map(x => x.CapacityOfLiferaft1, "lr1_capac");
            Map(x => x.ExpiryOfLiferaft1, "lr1_expiry");
            Map(x => x.TypeOfLiferaft1, "lr1_type");

            Map(x => x.CapacityOfLiferaft2, "lr2_capac");
            Map(x => x.ExpiryOfLiferaft2, "lr2_expiry");
            Map(x => x.TypeOfLiferaft2, "lr2_type");

            Map(x => x.CapacityOfLiferaft3, "lr3_capac");
            Map(x => x.ExpiryOfLiferaft3, "lr3_expiry");
            Map(x => x.TypeOfLiferaft3, "lr3_type");

            Map(x => x.CapacityOfLiferaft4, "lr4_capac");
            Map(x => x.ExpiryOfLiferaft4, "lr4_expiry");
            Map(x => x.TypeOfLiferaft4, "lr4_type");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
