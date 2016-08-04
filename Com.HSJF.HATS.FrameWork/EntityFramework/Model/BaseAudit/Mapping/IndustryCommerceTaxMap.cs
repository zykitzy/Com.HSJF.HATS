using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping
{
    public class IndustryCommerceTaxMap : EntityTypeConfiguration<IndustryCommerceTax>
    {
        public IndustryCommerceTaxMap()
        {
            this.HasKey(t => t.ID);
            this.Property(t => t.BaseAuditID).HasMaxLength(128);
            this.Property(t => t.EnterpriseID).HasMaxLength(128);

            this.ToTable("IndustryCommerceTax", "hats");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActualManagement).HasColumnName("ActualManagement");
            this.Property(t => t.AnnualInspection).HasColumnName("AnnualInspection");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.BaseAuditID).HasColumnName("BaseAuditID");
            this.Property(t => t.EnterpriseID).HasColumnName("EnterpriseID");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            this.HasRequired(t => t.BaseAudit).WithMany(t => t.IndustryCommerceTaxs).HasForeignKey(t => t.BaseAuditID);
        }
    }
}