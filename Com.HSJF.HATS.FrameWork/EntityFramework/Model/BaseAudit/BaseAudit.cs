using Com.HSJF.Infrastructure.DoMain;
using System;
using System.Collections.Generic;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit
{
    public class BaseAudit : EntityModel
    {
        public BaseAudit()
        {
            this.IndividualCredits = new List<IndividualCredit>();
            this.EnterpriseCredits = new List<EnterpriseCredit>();
            this.EnforcementPersons = new List<EnforcementPerson>();
            this.IndustryCommerceTaxs = new List<IndustryCommerceTax>();
            this.HouseDetails = new List<HouseDetail>();
            this.Guarantors = new List<Guarantor>();
            this.CollateralAudits = new List<CollateralAudit>();
            this.RelationPersonAudits = new List<RelationPersonAudit>();
            this.IntroducerAudits = new List<IntroducerAudit>();
        }

        //继承进件 BaseCase
        public string ID { get; set; }

        public string CaseNum { get; set; }
        public string CaseType { get; set; }
        public string SalesID { get; set; }
        public string SalesGroupID { get; set; }
        public string DistrictID { get; set; }
        public string BorrowerName { get; set; }
        public int Version { get; set; }
        public decimal? LoanAmount { get; set; }

        //以下 2-16-06-16 第一次测试之后新增
        public string Term { get; set; }

        public string Partner { get; set; }
        public decimal? AuditAmount { get; set; }
        public decimal? AnnualRate { get; set; }
        public decimal? PlatformCharge { get; set; }
        public decimal? ComprehensiveRate { get; set; }
        public string MortgageOrder { get; set; }
        public string CaseDetail { get; set; }
        public string AuditTerm { get; set; }
        public decimal? AuditRate { get; set; }
        public string OpeningBank { get; set; }
        public string OpeningSite { get; set; }
        public string BankCard { get; set; }
        public string AuditComment { get; set; }
        public string Description { get; set; }
        public string RejectType { get; set; }

        // 2016-06-27 再次新增
        public decimal? ServiceCharge { get; set; }

        public decimal? ServiceChargeRate { get; set; }
        public decimal? Deposit { get; set; }
        public DateTime? DepositDate { get; set; }
        public int? IsActivitieRate { get; set; }
        public string Merchandiser { get; set; }
        public string LenderName { get; set; }
        public decimal? EarnestMoney { get; set; }
        public decimal? OutboundCost { get; set; }
        public decimal? DebitNotarizationCost { get; set; }
        public decimal? DebitEvaluationCost { get; set; }
        public decimal? DebitGuaranteeCost { get; set; }
        public decimal? DebitInsuranceCost { get; set; }
        public decimal? DebitOtherCost { get; set; }
        public decimal? LevyNotarizationCost { get; set; }
        public decimal? LevyAssetsSurveyCost { get; set; }
        public decimal? LevyCreditReportCost { get; set; }
        public decimal? LevyOtherCost { get; set; }

        //新增审核字段
        public string CaseMode { get; set; }

        public string ThirdParty { get; set; }
        public decimal? MonthlyInterest { get; set; }
        public DateTime? LendingDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? ActualInterest { get; set; }
        public decimal? AdvanceInterest { get; set; }

        public int? IsNeedReport { get; set; }
        public string FaceReportFile { get; set; }
        public string FieldReportFile { get; set; }
        public string LoanDetailReportFile { get; set; }

        public string CaseStatus { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateUser { get; set; }
        public virtual ICollection<CollateralAudit> CollateralAudits { get; set; }
        public virtual ICollection<RelationPersonAudit> RelationPersonAudits { get; set; }

        public virtual ICollection<IndividualCredit> IndividualCredits { get; set; }
        public virtual ICollection<EnterpriseCredit> EnterpriseCredits { get; set; }
        public virtual ICollection<EnforcementPerson> EnforcementPersons { get; set; }
        public virtual ICollection<IndustryCommerceTax> IndustryCommerceTaxs { get; set; }
        public virtual ICollection<HouseDetail> HouseDetails { get; set; }
        public virtual ICollection<Guarantor> Guarantors { get; set; }
        public virtual ICollection<IntroducerAudit> IntroducerAudits { get; set; }

        //公证抵押
        //public virtual PublicMortgage PublicMortgage { get; set; }

        //放款
        //public virtual Com.HSJF.Framework.EntityFramework.Model.Lending.Lending Lending { get; set; }
    }
}