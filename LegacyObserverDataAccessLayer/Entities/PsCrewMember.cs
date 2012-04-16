// -----------------------------------------------------------------------
// <copyright file="PsCrewMember.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// Crew member entity
    /// </summary>
    public class PsCrewMember
    {
        public virtual int Id { get; set; }
        public virtual Trip Trip { get; set; }
        public virtual string Position { get; set; }
        public virtual string Name { get; set; }
        public virtual string Nationality { get; set; }
        public virtual int? YearsExperience { get; set; }
        public virtual int? MonthsExperience { get; set; }
        public virtual string Comments { get; set; }
    }
}
