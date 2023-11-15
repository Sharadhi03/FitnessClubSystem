namespace FitnessClubAPI.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MembershipType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
