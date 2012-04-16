// -----------------------------------------------------------------------
// <copyright file="PurseSeineTrip.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PurseSeineTrip : Trip
    {
        public PurseSeineTrip()
            : base()
        {
            Days = new List<PsDay>(45); // Pre-allocate a 45 entry list
            Crew = new List<PsCrewMember>(16);
            WellContents = new List<PsWellContent>(8);
            WellReconciliations = new List<PsWellReconciliation>(16);
        }

        public virtual PsFishingGear FishingGear { get; set; }

        public virtual PsVesselAttributes VesselAttributes { get; set; }

        public virtual IList<PsDay> Days { get; protected internal set; }

        public virtual IList<PsCrewMember> Crew { get; protected internal set; }

        public virtual IList<PsWellContent> WellContents { get; protected internal set; }

        public virtual IList<PsWellReconciliation> WellReconciliations { get; protected internal set; }

        public virtual void AddDay(PsDay day)
        {
            day.Trip = this;
            this.Days.Add(day);
        }

        public virtual void AddCrewMember(PsCrewMember crew)
        {
            crew.Trip = this;
            this.Crew.Add(crew);
        }

        public virtual void AddWellContent(PsWellContent content)
        {
            content.Trip = this;
            this.WellContents.Add(content);
        }

        public virtual void AddWellReconciliation(PsWellReconciliation recon)
        {
            recon.Trip = this;
            this.WellReconciliations.Add(recon);
        }
    }
}
