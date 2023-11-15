using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FitnessClubAPI.Models;
using Fitnessclub.Data.Entities;
using Fitnessclub.Data.Repositories;

namespace FitnessClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        public MemberRepository MemberRepository { get; set; }

        public MemberController() 
        { 
            this.MemberRepository = new MemberRepository();
        }
        [HttpGet]
        public List<TblMember> GetAllMembers()
        {
            return this.MemberRepository.GetAllMembers();
        }
        [HttpPost]
        public void AddMembers(Member member)
        {
            TblMember tblmember = new TblMember();
            tblmember.MemberId = 1;
            tblmember.MemberEmail = member.MemberEmail;
            tblmember.MemberPhone = member.MemberPhone;
            tblmember.DateOfBirth = member.DateOfBirth;
            tblmember.MembershipType = member.MembershipType;
            tblmember.StartDate = member.StartDate;
            tblmember.EndDate = member.EndDate;
            tblmember.MemberName = member.MemberName;
            this.MemberRepository.AddMembers(tblmember);
        }
        [HttpDelete]
        public void DeleteMembers(int memberId)
        {
            this.MemberRepository.DeleteMember(memberId);
        }
        [HttpGet("{memberId:int}")]
        public Member GetMember(int memberId,int staffId)
        {
            return new Member();
        }
    }
}
