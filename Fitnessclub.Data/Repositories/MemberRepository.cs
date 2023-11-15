using Fitnessclub.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnessclub.Data.Repositories
{
    public class MemberRepository
    {
        FMSContext FmsdbContext { get; set; }
        public MemberRepository() 
        {
            this.FmsdbContext = new FMSContext();
        }
        public List<TblMember> GetAllMembers()
        {
            return this.FmsdbContext.TblMembers.ToList();
        }
        public void AddMember(TblMember member)
        {
            this.FmsdbContext.TblMembers.Add(member);
            this.FmsdbContext.SaveChanges();
        }
        public void DeleteMember(int memberId)
        {
            var Memberdelete=this.FmsdbContext.TblMembers.Where(m=> m.MemberId == memberId).FirstOrDefault();
            if(Memberdelete != null)
            {
                this.FmsdbContext.Remove(Memberdelete); 
                this.FmsdbContext.SaveChanges();
            }
        }

        public void AddMembers(TblMember tblmember)
        {
            throw new NotImplementedException();
        }
    }
}
