// -----------------------------------------------------------------------
// <copyright file="Vessel.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// Fishing vessel entity.
    /// </summary>
    public class Vessel
    {
        public virtual int Id { get; protected internal set; }
        public virtual string Name { get; set; }
        public virtual string RegistrationNumber { get; set; }       
        public virtual string GearCode { get; set; }
        public virtual string FlagCountryCode { get; set; }
        public virtual string RegistrationCountryCode { get; set; }
        public virtual string CallSign { get; set; }
        public virtual int FfaVesselId { get; set; }
    }
}
