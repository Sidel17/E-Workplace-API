using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.ViewModels.Forms
{
    public class PayslipFormViewModel : IValidatableObject
    {
        public string SalaryPeriod { get; set; }
        public string Fullname { get; set; }
        public string EmployeeID { get; set; }
        public string JobTitleName { get; set; }
        public string Department { get; set; }
        public string Bank { get; set; }
        public string BankAccountNumber { get; set; }

        //Payments
        public int Salary { get; set; }
        public DateTimeOffset BackDatedPayment { get; set; }
        public int Allowance { get; set; }
        public int Incentive { get; set; }
        public int PaidLeave { get; set; }

        //Decuction
        public int BPJSKesehatan { get; set; }
        public int BPJSTenagaKerja { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
