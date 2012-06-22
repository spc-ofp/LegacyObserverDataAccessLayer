// -----------------------------------------------------------------------
// <copyright file="LonglineConversionFactorMap.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineConversionFactorMap : ClassMap<LonglineConversionFactor>
    {
        public LonglineConversionFactorMap()
        {
            ReadOnly();
            Table("l_sh_log");
            Id(x => x.Id, "id").GeneratedBy.Assigned();
            Map(x => x.DateOnly, "cdate");
            Map(x => x.TimeOnly, "ctime");
            Map(x => x.SpeciesCode, "sp_id");
            Map(x => x.LabelNumber, "label_no");

            References(x => x.FishingSet).Column("l_shaul_id");
            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
