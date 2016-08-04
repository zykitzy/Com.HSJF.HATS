using System.Data.Entity.ModelConfiguration;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping
{
    public class EstimateSourceMap : EntityTypeConfiguration<EstimateSource>
    {
        public EstimateSourceMap()
        {
            this.HasKey(t => t.ID);
            this.Property(t => t.RushEstimate).HasPrecision(12, 2);

            this.ToTable("EstimateSource", "hats");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ContactNumber).HasColumnName("ContactNumber");
            this.Property(t => t.EstimateInstitutions).HasColumnName("EstimateInstitutions");
            this.Property(t => t.InformationProvider).HasColumnName("InformationProvider");
            this.Property(t => t.RushEstimate).HasColumnName("RushEstimate");
            this.Property(t => t.Sequence).HasColumnName("Sequence");

            this.HasRequired(t => t.HouseDetail).WithMany(t => t.EstimateSources).HasForeignKey(t => t.HouseDetailID);
        }
    }
}