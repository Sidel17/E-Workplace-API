using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Models
{
    public class AccountInformation : StandardEntity
    {
        public string Fullname { get; set; }
        public string EmployeeID { get; set; }
        public string Username { get; set; }
        public DateTimeOffset? Dob { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public string CoorporateEmail { get; set; }
        public string Password { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? JoinDate { get; set; }
        public string SkillSet { get; set; }

        public int AccountId { get; set; }

        public string JobTitleName { get; set; }
        public string Department { get; set; }

        //public int FamilyId { get; set; }
        //public int ExpId { get; set; }
    }
}
