// -----------------------------------------------------------------------
// <copyright file="PsWellReconciliation.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using Spc.Ofp.Legacy.Observer.ExtensionMethods;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PsWellReconciliation
    {
        public virtual int Id { get; set; }
        public virtual Trip Trip { get; set; }
        public virtual DateTime? ObserverDateOnly { get; set; }
        public virtual string ObserverTimeOnly { get; set; }
        public virtual DateTime? LogDateOnly { get; set; }
        public virtual string LogTimeOnly { get; set; }
        public virtual string FillCode { get; set; }
        public virtual bool? IsCentralWell { get; set; }
        public virtual decimal? PortWell1 { get; set; }
        public virtual decimal? PortWell2 { get; set; }
        public virtual decimal? PortWell3 { get; set; }
        public virtual decimal? PortWell4 { get; set; }
        public virtual decimal? PortWell5 { get; set; }
        public virtual decimal? PortWell6 { get; set; }
        public virtual decimal? PortWell7 { get; set; }
        public virtual decimal? PortWell8 { get; set; }
        public virtual decimal? PortWell9 { get; set; }
        public virtual decimal? PortWell10 { get; set; }
        public virtual decimal? PortWell11 { get; set; }
        public virtual decimal? PortWell12 { get; set; }

        public virtual decimal? StarboardWell1 { get; set; }
        public virtual decimal? StarboardWell2 { get; set; }
        public virtual decimal? StarboardWell3 { get; set; }
        public virtual decimal? StarboardWell4 { get; set; }
        public virtual decimal? StarboardWell5 { get; set; }
        public virtual decimal? StarboardWell6 { get; set; }
        public virtual decimal? StarboardWell7 { get; set; }
        public virtual decimal? StarboardWell8 { get; set; }
        public virtual decimal? StarboardWell9 { get; set; }
        public virtual decimal? StarboardWell10 { get; set; }
        public virtual decimal? StarboardWell11 { get; set; }
        public virtual decimal? StarboardWell12 { get; set; }
        public virtual string Comments { get; set; }

        public virtual DateTime? GetDate()
        {
            return this.ObserverDateOnly.Combine(this.ObserverTimeOnly);
        }

        public virtual DateTime? GetLogDate()
        {
            return this.LogDateOnly.Combine(this.LogTimeOnly);
        }

    }
}
