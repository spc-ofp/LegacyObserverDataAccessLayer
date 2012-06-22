// -----------------------------------------------------------------------
// <copyright file="FishTransferMapping.cs" company="">
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
    public class FishTransferMap : ClassMap<FishTransfer>
    {
        public FishTransferMap()
        {
            ReadOnly();
            Table("fishtransfer");
            Id(x => x.Id, "fisht_id").GeneratedBy.Native();
            Map(x => x.DateOnly, "date");
            Map(x => x.TimeOnly, "time");
            Map(x => x.Latitude, "lat");
            Map(x => x.Longitude, "lon");
            Map(x => x.Name, "r_name");
            Map(x => x.CallSign, "r_callsign");
            Map(x => x.FlagCode, "r_flag");
            Map(x => x.VesselType, "r_type");
            Map(x => x.TonsOfSkipjack, "skj_c");
            Map(x => x.TonsOfYellowfin, "yft_c");
            Map(x => x.TonsOfBigeye, "bet_c");
            Map(x => x.TonsOfMixed, "mix_c");
            Map(x => x.TransferType, "transfer");
            Map(x => x.Comments, "comment");

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
