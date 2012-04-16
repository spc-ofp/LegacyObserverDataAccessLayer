// -----------------------------------------------------------------------
// <copyright file="PollutionDetailMap.cs" company="">
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
    public class PollutionDetailMap : ClassMap<PollutionDetail>
    {
        public PollutionDetailMap()
        {
            ReadOnly();
            Table("gen6_pollution_d");
            Id(x => x.Id, "poll_d_id").GeneratedBy.Identity();
            Map(x => x.Material, "material_id");
            Map(x => x.YesNo, "yn");
            Map(x => x.Type, "type");
            Map(x => x.Quantity, "quantity");

            References(x => x.Header).Column("poll_h_id");
            DiscriminateSubClassesOnColumn("poll_type");
        }
    }

    public sealed class WasteDetailMap : SubclassMap<WasteDetail>
    {
        public WasteDetailMap()
        {
            DiscriminatorValue(1);
        }
    }

    public sealed class SpillDetailMap : SubclassMap<SpillDetail>
    {
        public SpillDetailMap()
        {
            DiscriminatorValue(2);
        }
    }
}
