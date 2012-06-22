// -----------------------------------------------------------------------
// <copyright file="Gen3Form.cs" company="Secretariat of the Pacific Community">
// Copyright (C) 2012 Secretariat of the Pacific Community
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Entities
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Gen3Form
    {
        public virtual int Id { get; protected internal set; }
        public virtual Trip Trip { get; set; }
        public virtual bool? Question1  { get; set; }
        public virtual bool? Question2 { get; set; }
        public virtual bool? Question3 { get; set; }
        public virtual bool? Question4 { get; set; }
        public virtual bool? Question5 { get; set; }
        public virtual bool? Question6 { get; set; }
        public virtual bool? Question7 { get; set; }
        public virtual bool? Question8 { get; set; }
        public virtual bool? Question9 { get; set; }
        public virtual bool? Question10 { get; set; }
        public virtual bool? Question11 { get; set; }
        public virtual bool? Question12 { get; set; }
        public virtual bool? Question13 { get; set; }
        public virtual bool? Question14 { get; set; }
        public virtual bool? Question15 { get; set; }
        public virtual bool? Question16 { get; set; }
        public virtual bool? Question17 { get; set; }
        public virtual bool? Question18 { get; set; }
        public virtual bool? Question19 { get; set; }
        public virtual bool? Question20 { get; set; }
        public virtual DateTime? Date1 { get; set; }
        public virtual string Comment1 { get; set; }
        public virtual DateTime? Date2 { get; set; }
        public virtual string Comment2 { get; set; }
        public virtual DateTime? Date3 { get; set; }
        public virtual string Comment3 { get; set; }
    }
}
