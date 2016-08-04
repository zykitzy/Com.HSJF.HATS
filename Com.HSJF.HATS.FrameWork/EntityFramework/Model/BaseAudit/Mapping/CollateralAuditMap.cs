using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping
{
    public class CollateralAuditMap : EntityTypeConfiguration<CollateralAudit>
    {
        public CollateralAuditMap()
        {
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.AuditID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.CollateralType)
                .HasMaxLength(50);

            this.Property(t => t.HouseNumber)
                .HasMaxLength(128);

            this.Property(t => t.BuildingName)
                .HasMaxLength(128);

            this.Property(t => t.RightOwner)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("CollateralAudit", "hats");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AuditID).HasColumnName("AuditID");
            this.Property(t => t.CollateralType).HasColumnName("CollateralType");
            this.Property(t => t.HouseNumber).HasColumnName("HouseNumber");
            this.Property(t => t.HouseFile).HasColumnName("HouseFile");
            this.Property(t => t.BuildingName).HasColumnName("BuildingName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.RightOwner).HasColumnName("RightOwner");
            this.Property(t => t.HouseSize).HasColumnName("HouseSize");
            this.Property(t => t.HouseReportFile).HasColumnName("HouseReportFile");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            // Relationships
            this.HasRequired(t => t.BaseAudit)
                .WithMany(t => t.CollateralAudits)
                .HasForeignKey(d => d.AuditID);
        }
    }
}