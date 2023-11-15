using System;
using System.Collections.Generic;

namespace Fitnessclub.Data.Entities
{
    public partial class TblMember
    {
        public int MemberId { get; set; }
        public string? MemberName { get; set; }
        public string? MemberEmail { get; set; }
        public string? MemberPhone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? MemberType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual TblStaff Member { get; set; } = null!;
        public int StaffId { get; set; }
        public string MembershipType { get; set; }
    }
}
