using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FitnessClubAPI.Models;

namespace FitnessClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private static  List<Staff> stafflist = new List<Staff>()
        {
            new Staff
            {
                StaffId=123,
                StaffName ="sharadhi",
                StaffEmail ="sample@gmail.com",
                StaffPhone ="7422972947",
                DateOfBirth =new DateTime(2001,4,8),
                HireDate =new DateTime(2023,7,15),
                Position="trainer"
            },
            new Staff
            {
                StaffId=456,
                StaffName ="Eren",
                StaffEmail ="ereny@gmail.com",
                StaffPhone ="7422563827",
                DateOfBirth =new DateTime(2001,3,30),
                HireDate =new DateTime(2023,7,15),
                Position="receptionist"
            },
        };
        [HttpGet]
        public List<Staff> GetAllStaff()
        {
            return new List<Staff>();
        }
        [HttpPost]
        public void AddStaff(Staff staff)
        {
            stafflist.Add(staff);
        }
        [HttpDelete]
        public void DeleteStaff(int staffId)
        {
            var staff =stafflist.Where(s=>s.StaffId==staffId).FirstOrDefault();
            stafflist.Remove(staff);
        }
        [HttpGet("{staffId:int}")]
        public Staff  GetStaff(int staffId)
        {
            var staff = stafflist.Where(s => s.StaffId == staffId).FirstOrDefault();
            return staff;
        }
    }
}