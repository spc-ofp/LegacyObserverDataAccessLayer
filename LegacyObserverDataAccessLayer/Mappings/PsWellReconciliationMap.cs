// -----------------------------------------------------------------------
// <copyright file="PsWellReconciliationMap.cs" company="">
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
    public class PsWellReconciliationMap : ClassMap<PsWellReconciliation>
    {
        public PsWellReconciliationMap()
        {
            ReadOnly();
            Table("s_log_well_recon");
            Id(x => x.Id, "lw_id").GeneratedBy.Assigned();
            Map(x => x.ObserverDateOnly, "obsdate");
            Map(x => x.ObserverTimeOnly, "obstime");
            Map(x => x.LogDateOnly, "logdate");
            Map(x => x.LogTimeOnly, "logtime");
            Map(x => x.FillCode, "wellfill");
            Map(x => x.IsCentralWell, "central1");

            Map(x => x.PortWell1, "pw1");
            Map(x => x.PortWell2, "pw2");
            Map(x => x.PortWell3, "pw3");
            Map(x => x.PortWell4, "pw4");
            Map(x => x.PortWell5, "pw5");
            Map(x => x.PortWell6, "pw6");
            Map(x => x.PortWell7, "pw7");
            Map(x => x.PortWell8, "pw8");
            Map(x => x.PortWell9, "pw9");
            Map(x => x.PortWell10, "pw10");
            Map(x => x.PortWell11, "pw11");
            Map(x => x.PortWell12, "pw12");

            Map(x => x.StarboardWell1, "sw1");
            Map(x => x.StarboardWell2, "sw2");
            Map(x => x.StarboardWell3, "sw3");
            Map(x => x.StarboardWell4, "sw4");
            Map(x => x.StarboardWell5, "sw5");
            Map(x => x.StarboardWell6, "sw6");
            Map(x => x.StarboardWell7, "sw7");
            Map(x => x.StarboardWell8, "sw8");
            Map(x => x.StarboardWell9, "sw9");
            Map(x => x.StarboardWell10, "sw10");
            Map(x => x.StarboardWell11, "sw11");
            Map(x => x.StarboardWell12, "sw12");

            Map(x => x.Comments, "comment");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
