// -----------------------------------------------------------------------
// <copyright file="VesselMap.cs" company="">
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
    public class VesselMap : ClassMap<Vessel>
    {
        public VesselMap()
        {
            ReadOnly();
            Table("vessel");
            Id(x => x.Id, "boat_id");
            Map(x => x.Name, "vesselname").Formula("trim(vesselname)");
            Map(x => x.RegistrationNumber, "regist_no");
            Map(x => x.GearCode, "gr_id");
            Map(x => x.CallSign, "call");
            Map(x => x.FfaVesselId, "ffa_vid");
            Map(x => x.FlagCountryCode, "flag_id");
            Map(x => x.RegistrationCountryCode, "flag_rg_id");
        }
    }
}
