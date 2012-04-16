// -----------------------------------------------------------------------
// <copyright file="MarineDeviceMap.cs" company="">
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
    public class MarineDeviceMap : ClassMap<MarineDevice>
    {
        public MarineDeviceMap()
        {
            ReadOnly();
            Table("mar_dev");
            Id(x => x.Id, "device_id");
            Map(x => x.Description, "dev_desc");
            Map(x => x.Category, "dev_cat");
            Map(x => x.ListFor, "gearlist");
            Map(x => x.LongLineOrder, "order_l");
            Map(x => x.PurseSeineOrder, "order_s");
            Map(x => x.PoleAndLineOrder, "order_p");
        }
    }
}
