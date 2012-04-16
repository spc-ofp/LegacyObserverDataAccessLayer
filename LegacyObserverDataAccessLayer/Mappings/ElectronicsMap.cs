// -----------------------------------------------------------------------
// <copyright file="ElectronicsMap.cs" company="">
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
    public class ElectronicsMap : ClassMap<Electronics>
    {
        public ElectronicsMap()
        {
            ReadOnly();
            Table("electronics");
            Id(x => x.Id, "id").GeneratedBy.Identity();
            Map(x => x.YesNo, "yesno");
            Map(x => x.Usage, "usage");
            Map(x => x.Make, "make_desc");
            Map(x => x.Model, "model_desc");
            Map(x => x.Comments, "comment");

            References(x => x.Device).Column("device_id");
            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
