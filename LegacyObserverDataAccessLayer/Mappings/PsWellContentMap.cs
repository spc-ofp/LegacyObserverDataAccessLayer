// -----------------------------------------------------------------------
// <copyright file="PsWellContentMap.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Common;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsWellContentMap : ClassMap<PsWellContent>
    {
        public PsWellContentMap()
        {
            ReadOnly();
            Table("ps1_wellcontent");
            Id(x => x.Id, "wc_id").GeneratedBy.Assigned();
            Map(x => x.WellContents, "fuel_water").CustomType<WellContentType>();
            Map(x => x.WellNumber, "w_no");
            Map(x => x.PortOrStarboard, "ps"); // Need to check Manu's conversion to see what this is
            Map(x => x.Capacity, "w_cap");
            Map(x => x.Comments, "comments");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
