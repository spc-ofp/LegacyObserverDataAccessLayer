// -----------------------------------------------------------------------
// <copyright file="LonglineFishingSet.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LonglineFishingSet
    {
        public LonglineFishingSet()
        {
            CatchList = new List<LonglineCatch>(); // TODO How many per?
            EventList = new List<LonglineSetHaulEvent>(16); // TODO How many per?
            ConversionFactors = new List<LonglineConversionFactor>(); // TODO How many per?
        }
        
        public virtual int Id { get; protected set; }
        public virtual Trip Trip { get; set; }

        public virtual int? SetNumber { get; set; }

        public virtual DateTime? DateOnly { get; set; }

        public virtual string TimeOnly { get; set; }

        public virtual DateTime? UtcDateOnly { get; set; }

        public virtual string UtcTimeOnly { get; set; }

        public virtual string TargetSpeciesCode { get; set; }

        public virtual int? HooksPerBasket { get; set; }

        public virtual int? TotalBasketCount { get; set; }

        public virtual int? TotalHookCount { get; set; }

        public virtual int? FloatlineLength { get; set; }

        public virtual decimal? LineSettingSpeed { get; set; }

        public virtual int? LineSettingSpeedUnit { get; set; } // 1 = m/s, 2 = kts

        public virtual decimal? VesselSpeed { get; set; }

        public virtual int? BranchlineSetInterval { get; set; }

        public virtual int? DistanceBetweenBranchlines { get; set; }

        public virtual int? BranchlineLength { get; set; }

        public virtual int? SharkLineCount { get; set; }

        public virtual int? SharkLineLength { get; set; }

        // TDR is Temperature Depth Recorder
        public virtual bool? TdrDeployed { get; set; }

        public virtual int? TotalHooksObserved { get; set; }

        public virtual int? TotalBasketsObserved { get; set; }

        public virtual int? LightStickCount { get; set; }

        public virtual bool? HasGen3Event { get; set; }

        public virtual bool? AllPositionsDirectlyObserved { get; set; }

        public virtual string MeasuringInstrument { get; set; }

        public virtual string BaitSpecies1Code { get; set; }
        public virtual int? BaitSpecies1Weight { get; set; }
        public virtual string BaitSpecies1Hooks { get; set; }

        public virtual string BaitSpecies2Code { get; set; }
        public virtual int? BaitSpecies2Weight { get; set; }
        public virtual string BaitSpecies2Hooks { get; set; }

        public virtual string BaitSpecies3Code { get; set; }
        public virtual int? BaitSpecies3Weight { get; set; }
        public virtual string BaitSpecies3Hooks { get; set; }

        public virtual string BaitSpecies4Code { get; set; }
        public virtual int? BaitSpecies4Weight { get; set; }
        public virtual string BaitSpecies4Hooks { get; set; }

        public virtual string BaitSpecies5Code { get; set; }
        public virtual int? BaitSpecies5Weight { get; set; }
        public virtual string BaitSpecies5Hooks { get; set; }

        public virtual string SetDetails { get; set; }

        public virtual IList<LonglineCatch> CatchList { get; protected internal set; }

        public virtual IList<LonglineSetHaulEvent> EventList { get; protected internal set; }

        public virtual IList<LonglineConversionFactor> ConversionFactors { get; protected internal set; }

        public virtual void AddCatch(LonglineCatch lcatch)
        {
            lcatch.FishingSet = this;
            lcatch.Trip = this.Trip; // ???
            CatchList.Add(lcatch);
        }

        public virtual void AddEvent(LonglineSetHaulEvent levent)
        {
            levent.FishingSet = this;
            levent.Trip = this.Trip; // ???
            EventList.Add(levent);
        }

        public virtual void AddConversionFactor(LonglineConversionFactor cfactor)
        {
            cfactor.FishingSet = this;
            cfactor.Trip = this.Trip;
            ConversionFactors.Add(cfactor);
        }
    }
}
