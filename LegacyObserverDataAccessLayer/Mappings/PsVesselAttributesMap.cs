// -----------------------------------------------------------------------
// <copyright file="PsVesselAttributesMap.cs" company="">
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
    public class PsVesselAttributesMap : ClassMap<PsVesselAttributes>
    {
        public PsVesselAttributesMap()
        {
            ReadOnly();
            Table("s_vess_attr");
            Id(x => x.Id, "id").GeneratedBy.Assigned();
            Map(x => x.Owner, "owner");
            Map(x => x.SpeedboatCount, "n_speed");
            Map(x => x.TowboatCount, "n_tow");
            Map(x => x.Tenderboats, "tenderboats");
            Map(x => x.SkiffEngineMake, "skiff_make");
            Map(x => x.SkiffEnginePower, "skiff_hp");
            Map(x => x.CruisingSpeed, "v_speed");
            Map(x => x.HelicopterMake, "heli_make");
            Map(x => x.HelicopterModel, "heli_model");
            Map(x => x.HelicopterRegistrationNumber, "heli_reg_no");
            Map(x => x.HelicopterRange, "heli_range");
            Map(x => x.HelicopterRangeUnits, "heli_range_unt");
            Map(x => x.HelicopterColor, "heli_colr");
            Map(x => x.HelicopterServiceCount, "heli_nbvess");
            Map(x => x.HasWasteDisposal, "waste_disp");
            Map(x => x.WasteDisposalDescription, "waste_dis2");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
