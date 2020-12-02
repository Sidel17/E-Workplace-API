using Co.Id.Moonlay.Simple.Auth.Service.Lib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Configs
{
    class PayrollConfig : IEntityTypeConfiguration<Payroll>
    {
        public void Configure(EntityTypeBuilder<Payroll> builder)
        {
            builder.Property(p => p.NameBankAccount).HasMaxLength(255);
            builder.Property(p => p.Bank).HasMaxLength(15);
            builder.Property(p => p.BankAccountNumber).HasMaxLength(255);
            builder.Property(p => p.BankBranch).HasMaxLength(255);
        }
    }
}
