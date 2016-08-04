using Com.HSJF.Infrastructure.DoMain;
using System.Collections.Generic;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit
{
    public class HouseDetail : EntityModel
    {
        public HouseDetail()
        {
            this.EstimateSources = new List<EstimateSource>();
        }

        public string ID { get; set; }
        public decimal? AssessedValue { get; set; }
        public string Accout { get; set; }
        public decimal? TotalHeight { get; set; }
        public string CompletionDate { get; set; }
        public string HouseType { get; set; }
        public string LandType { get; set; }
        public string ServiceCondition { get; set; }
        public string RepairSituation { get; set; }
        public string Collateral { get; set; }
        public string LimitInfo { get; set; }
        public string Description { get; set; }

        //以下 2-16-06-16 第一次测试之后新增
        public string HousePhotoFile { get; set; }

        //以下 2-16-06-16 第一次测试之后新增
        public string HouseReportFile { get; set; }

        public string BaseAuditID { get; set; }
        public string CollateralID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        public BaseAudit BaseAudit { get; set; }

        public virtual ICollection<EstimateSource> EstimateSources { get; set; }
    }
}