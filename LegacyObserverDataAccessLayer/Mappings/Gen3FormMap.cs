// -----------------------------------------------------------------------
// <copyright file="Gen3FormMap.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.Mappings
{
    using FluentNHibernate.Mapping;
    using Spc.Ofp.Legacy.Observer.Entities;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Gen3FormMap : ClassMap<Gen3Form>
    {
        public Gen3FormMap()
        {
            ReadOnly();
            Table("gen3");
            Id(x => x.Id, "gen3_id").GeneratedBy.Assigned();
            Map(x => x.Question1).Formula("case when q1 = 't' then 1 else 0 end");
            Map(x => x.Question2).Formula("case when q2 = 't' then 1 else 0 end");
            Map(x => x.Question3).Formula("case when q3 = 't' then 1 else 0 end");
            Map(x => x.Question4).Formula("case when q4 = 't' then 1 else 0 end");
            Map(x => x.Question5).Formula("case when q5 = 't' then 1 else 0 end");
            Map(x => x.Question6).Formula("case when q6 = 't' then 1 else 0 end");
            Map(x => x.Question7).Formula("case when q7 = 't' then 1 else 0 end");
            Map(x => x.Question8).Formula("case when q8 = 't' then 1 else 0 end");
            Map(x => x.Question9).Formula("case when q9 = 't' then 1 else 0 end");
            Map(x => x.Question10).Formula("case when q10 = 't' then 1 else 0 end");
            Map(x => x.Question11).Formula("case when q11 = 't' then 1 else 0 end");
            Map(x => x.Question12).Formula("case when q12 = 't' then 1 else 0 end");
            Map(x => x.Question13).Formula("case when q13 = 't' then 1 else 0 end");
            Map(x => x.Question14).Formula("case when q14 = 't' then 1 else 0 end");
            Map(x => x.Question15).Formula("case when q15 = 't' then 1 else 0 end");
            Map(x => x.Question16).Formula("case when q16 = 't' then 1 else 0 end");
            Map(x => x.Question17).Formula("case when q17 = 't' then 1 else 0 end");
            Map(x => x.Question18).Formula("case when q18 = 't' then 1 else 0 end");
            Map(x => x.Question19).Formula("case when q19 = 't' then 1 else 0 end");
            Map(x => x.Question20).Formula("case when q20 = 't' then 1 else 0 end");
            Map(x => x.Date1);
            Map(x => x.Comment1);
            Map(x => x.Date2);
            Map(x => x.Comment2);
            Map(x => x.Date3);
            Map(x => x.Comment3);

            References(x => x.Trip).Column("obstrip_id");
        }
    }
}
