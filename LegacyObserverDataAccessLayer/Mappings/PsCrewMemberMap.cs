// -----------------------------------------------------------------------
// <copyright file="PsCrewMemberMap.cs" company="">
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
    public class PsCrewMemberMap : ClassMap<PsCrewMember>
    {
        public PsCrewMemberMap()
        {
            ReadOnly();
            Table("ps1_crew");
            Id(x => x.Id, "crew_id").GeneratedBy.Assigned();
            Map(x => x.Position, "position_i");
            Map(x => x.Name, "name");
            Map(x => x.Nationality, "flag_id");
            Map(x => x.YearsExperience, "exp_yr");
            Map(x => x.MonthsExperience, "exp_mo");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
