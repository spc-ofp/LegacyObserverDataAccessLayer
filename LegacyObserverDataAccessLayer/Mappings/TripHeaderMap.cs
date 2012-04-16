// -----------------------------------------------------------------------
// <copyright file="TripHeaderMap.cs" company="">
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
    public class TripHeaderMap : ClassMap<TripHeader>
    {
        public TripHeaderMap()
        {
            ReadOnly();
            Table("obs_trip");
            Id(x => x.Id, "obstrip_id").GeneratedBy.Identity();
            Map(x => x.TripNumber, "tripno");
            Map(x => x.StaffCode, "obsv_id");
            Map(x => x.ProgramCode, "obs_prg_id");
            Map(x => x.DepartureDate, "o_dep_date");
            Map(x => x.ReturnDate, "o_ret_date");
            Map(x => x.GearCode, "gr_id");
            Map(x => x.CkTripNumber, "cktripno");
            Map(x => x.FmTripNumber, "fmtripno");
            Map(x => x.FfaTripNumber, "ffatripno");
            Map(x => x.SbTripNumber, "sbtripno");
            Map(x => x.HwTripNumber, "hwtripno");

        }
    }
}
