// -----------------------------------------------------------------------
// <copyright file="FieldStaffMap.cs" company="">
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
    public class FieldStaffMap : ClassMap<FieldStaff>
    {
        public FieldStaffMap()
        {
            ReadOnly();
            Table("field_staff");
            Id(x => x.StaffCode, "staff_id").GeneratedBy.Assigned();
            Map(x => x.FirstName).Formula("trim(first_name)");
            Map(x => x.LastName, "last_name");
        }
    }
}
