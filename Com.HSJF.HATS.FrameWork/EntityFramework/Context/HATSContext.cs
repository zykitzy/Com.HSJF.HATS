using Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit;
using Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit.Mapping;
using Com.HSJF.HATS.FrameWork.EntityFramework.Model.SystemSetting.Menu;
using Com.HSJF.HATS.FrameWork.EntityFramework.Model.SystemSetting.Menu.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Context
{
    public partial class HATSContext : DbContext
    {
        static HATSContext()
        {
            Database.SetInitializer<HATSContext>(null);
        }

        public HATSContext()
            : base("Name=HATSContext")
        { }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<Menu2Role> Menu2Role { get; set; }
        //  public DbSet<Menu2Role> Menu2Role { get; set; }

        //BaseAudit
        public DbSet<BaseAudit> BaseAudit { get; set; }

        public DbSet<EnforcementPerson> EnforcementPersons { get; set; }
        public DbSet<EnterpriseCredit> EnterpriseCredits { get; set; }
        public DbSet<EstimateSource> EstimateSources { get; set; }
        public DbSet<Guarantor> Guarantors { get; set; }
        public DbSet<HouseDetail> HouseDetails { get; set; }
        public DbSet<IndividualCredit> IndividualCredits { get; set; }
        public DbSet<IndustryCommerceTax> IndustryCommerceTaxs { get; set; }
        public DbSet<CollateralAudit> CollateralAudit { get; set; }
        public DbSet<RelationEnterpriseAudit> RelationEnterpriseAudit { get; set; }
        public DbSet<RelationPersonAudit> RelationPersonAudit { get; set; }
        public DbSet<ContactAudit> ContactAudit { get; set; }
        public DbSet<AddressAudit> AddresseAudit { get; set; }
        public DbSet<EmergencyContactAudit> EmergencyContactAudit { get; set; }
        public DbSet<IntroducerAudit> IntroducerAudit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new Menu2RoleMap());

            //BaseAudit
            modelBuilder.Configurations.Add(new BaseAuditMap());
            modelBuilder.Configurations.Add(new EnforcementPersonMap());
            modelBuilder.Configurations.Add(new EnterpriseCreditMap());
            modelBuilder.Configurations.Add(new EstimateSourceMap());
            modelBuilder.Configurations.Add(new GuarantorMap());
            modelBuilder.Configurations.Add(new HouseDetailMap());
            modelBuilder.Configurations.Add(new IndividualCreditMap());
            modelBuilder.Configurations.Add(new IndustryCommerceTaxMap());
            modelBuilder.Configurations.Add(new CollateralAuditMap());
            modelBuilder.Configurations.Add(new RelationPersonAuditMap());
            modelBuilder.Configurations.Add(new RelationEnterpriseAuditMap());
            modelBuilder.Configurations.Add(new ContactAuditMap());
            modelBuilder.Configurations.Add(new AddressAuditMap());
            modelBuilder.Configurations.Add(new EmergencyContactAuditMap());
            modelBuilder.Configurations.Add(new IntroducerAuditMap());
        }
    }
}