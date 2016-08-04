using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping
{
    public class HouseDetailMap : EntityTypeConfiguration<HouseDetail>
    {
        public HouseDetailMap()
        {
            this.HasKey(t => t.ID);
            this.Property(t => t.AssessedValue).HasPrecision(12, 2);
            this.Property(t => t.TotalHeight).HasPrecision(12, 2);
            this.Property(t => t.Accout).HasMaxLength(128);
            this.Property(t => t.CollateralID).HasMaxLength(128);
            this.Property(t => t.CompletionDate).HasMaxLength(4);

            this.ToTable("HouseDetail", "hats");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Accout).HasColumnName("Accout");
            this.Property(t => t.AssessedValue).HasColumnName("AssessedValue");
            this.Property(t => t.BaseAuditID).HasColumnName("BaseAuditID");
            this.Property(t => t.Collateral).HasColumnName("Collateral");
            this.Property(t => t.CompletionDate).HasColumnName("CompletionDate");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.HouseType).HasColumnName("HouseType");
            this.Property(t => t.LandType).HasColumnName("LandType");
            this.Property(t => t.LimitInfo).HasColumnName("LimitInfo");
            this.Property(t => t.RepairSituation).HasColumnName("RepairSituation");
            this.Property(t => t.ServiceCondition).HasColumnName("ServiceCondition");
            this.Property(t => t.TotalHeight).HasColumnName("TotalHeight");
            this.Property(t => t.CollateralID).HasColumnName("CollateralID");
            this.Property(t => t.HousePhotoFile).HasColumnName("HousePhotoFile");
            this.Property(t => t.HouseReportFile).HasColumnName("HouseReportFile");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            this.HasRequired(t => t.BaseAudit).WithMany(t => t.HouseDetails).HasForeignKey(t => t.BaseAuditID);
        }
    }
}