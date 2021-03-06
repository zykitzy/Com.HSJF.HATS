﻿using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping
{
    public class IntroducerAuditMap : EntityTypeConfiguration<IntroducerAudit>
    {
        public IntroducerAuditMap()
        {
            this.HasKey(t => t.ID);
            this.Property(t => t.AuditID).HasMaxLength(128);

            this.ToTable("IntroducerAudit", "hats");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.Contract).HasColumnName("Contract");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AuditID).HasColumnName("AuditID");
            this.Property(t => t.AccountBank).HasColumnName("AccountBank");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RebateAmmount).HasColumnName("RebateAmmount");
            this.Property(t => t.RebateRate).HasColumnName("RebateRate");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            this.HasRequired(t => t.BaseAudit).WithMany(t => t.IntroducerAudits).HasForeignKey(t => t.AuditID);
        }
    }
}