using System;
using System.Collections.Generic;

namespace Fitnessclub.Data.Entities
{
    public partial class TblStaff
    {
        public int StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffPhone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Position { get; set; }

        public virtual TblMember? TblMember { get; set; }
    }
}
