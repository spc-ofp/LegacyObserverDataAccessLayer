﻿// -----------------------------------------------------------------------
// <copyright file="Electronics.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{

    /// <summary>
    /// Electronic device entity.
    /// </summary>
    public class Electronics
    {
        public virtual int Id { get; protected internal set; }
        public virtual MarineDevice Device { get; set; }
        public virtual Trip Trip { get; set; }
        public virtual string YesNo { get; set; }
        public virtual string Usage { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual string Comments { get; set; }
    }
}
