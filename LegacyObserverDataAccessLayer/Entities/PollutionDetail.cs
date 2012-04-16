// -----------------------------------------------------------------------
// <copyright file="PollutionDetail.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class PollutionDetail
    {
        public virtual int Id { get; protected set; }

        public virtual PollutionHeader Header { get; set; }

        //public virtual int? PollutionType { get; set; } // TODO Enum

        public virtual string Material { get; set; }

        public virtual int? YesNo { get; set; }

        public virtual string Type { get; set; }

        public virtual string Quantity { get; set; }
    }
}
