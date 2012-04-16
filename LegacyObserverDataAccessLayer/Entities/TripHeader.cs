// -----------------------------------------------------------------------
// <copyright file="TripHeader.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;

    /// <summary>
    /// TripHeader is a lightweight object for working with
    /// a complete list of trips without pulling in the full
    /// object graph.
    /// </summary>
    public class TripHeader
    {
        // Primary key
        public virtual int Id { get; set; }

        public virtual string ProgramCode { get; set; }

        public virtual string StaffCode { get; set; }

        public virtual string TripNumber { get; set; }

        public virtual string FfaTripNumber { get; set; }

        public virtual string CkTripNumber { get; set; }

        public virtual string FmTripNumber { get; set; }

        public virtual string SbTripNumber { get; set; }

        public virtual string HwTripNumber { get; set; }

        public virtual string SpcTripNumber
        {
            get
            {
                return String.Format("{0} / {1}", this.StaffCode.Trim(), this.TripNumber.Trim());
            }
        }
    }
}
