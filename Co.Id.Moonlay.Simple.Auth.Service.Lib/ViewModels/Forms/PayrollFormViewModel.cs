using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.ViewModels.Forms
{
    public class PayrollFormViewModel : IValidatableObject
    {
        public int AccountInformationId { get; set; }
        public int Salary { get; set; }
        public int Tax { get; set; }
        public int BPJSKesehatan { get; set; }
        public int BPJSTenagaKerja { get; set; }
        public int NPWP { get; set; }
        public string NameBankAccount { get; set; }
        public string Bank { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankBranch { get; set; }
        public DateTimeOffset BackDatedPayment { get; set; }
        public int Allowance { get; set; }
        public int Incentive { get; set; }
        public int PaidLeave { get; set; }
        public int UnPaidLeave { get; set; }
        public string SalaryPeriod { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int TakeHomePay { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
