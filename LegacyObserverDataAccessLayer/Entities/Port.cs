// -----------------------------------------------------------------------
// <copyright file="Port.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// Shipping port entity.
    /// </summary>
    public class Port
    {
        public virtual int Id { get; protected internal set; }
        public virtual int FfaId { get; set; }
        public virtual string Name { get; set; }
        public virtual string CountryCode { get; set; }       
    }
}
