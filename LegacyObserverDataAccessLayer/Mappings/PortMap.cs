// -----------------------------------------------------------------------
// <copyright file="PortMap.cs" company="">
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
    public class PortMap : ClassMap<Port>
    {
        public PortMap()
        {
            ReadOnly();
            Table("port");
            Id(x => x.Id, "port_id").GeneratedBy.Assigned();
            Map(x => x.FfaId, "ffa_portid");
            Map(x => x.Name, "port_name");
            Map(x => x.CountryCode, "co_id");
        }
    }
}
