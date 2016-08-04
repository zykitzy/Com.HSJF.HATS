using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping
{
    public class EnforcementPersonMap : EntityTypeConfiguration<EnforcementPerson>
    {
        public EnforcementPersonMap()
        {
            this.HasKey(t => t.ID);
            this.Property(t => t.PersonID).HasMaxLength(128);

            this.ToTable("EnforcementPerson", "hats");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BadNews).HasColumnName("BadNews");
            this.Property(t => t.BaseAuditID).HasColumnName("BaseAuditID");
            this.Property(t => t.EnforcementWeb).HasColumnName("EnforcementWeb");
            this.Property(t => t.LawXP).HasColumnName("LawXP");
            this.Property(t => t.ShiXin).HasColumnName("ShiXin");
            this.Property(t => t.TrialRecord).HasColumnName("TrialRecord");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            this.HasRequired(t => t.BaseAudit).WithMany(t => t.EnforcementPersons).HasForeignKey(t => t.BaseAuditID);
        }
    }
}