// -----------------------------------------------------------------------
// <copyright file="SafetyInspection.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SafetyInspection
    {
        public virtual int Id { get; protected set; }

        public virtual Trip Trip { get; set; }

        public virtual int? LifejacketProvided { get; set; }

        public virtual bool? LifejacketSizeOk { get; set; }

        public virtual int? LifejacketsAvailable { get; set; }

        public virtual int? BuoyCount { get; set; }

        public virtual string Epi1Type { get; set; }

        public virtual int? Epi1Count { get; set; }

        public virtual string Epi2Type { get; set; }

        public virtual int? Epi2Count { get; set; }

        public virtual int? CapacityOfLiferaft1 { get; set; }

        public virtual int? CapacityOfLiferaft2 { get; set; }

        public virtual int? CapacityOfLiferaft3 { get; set; }

        public virtual int? CapacityOfLiferaft4 { get; set; }

        public virtual DateTime? ExpiryOfLiferaft1 { get; set; }

        public virtual DateTime? ExpiryOfLiferaft2 { get; set; }

        public virtual DateTime? ExpiryOfLiferaft3 { get; set; }

        public virtual DateTime? ExpiryOfLiferaft4 { get; set; }

        public virtual string TypeOfLiferaft1 { get; set; }

        public virtual string TypeOfLiferaft2 { get; set; }

        public virtual string TypeOfLiferaft3 { get; set; }

        public virtual string TypeOfLiferaft4 { get; set; }

    }
}
