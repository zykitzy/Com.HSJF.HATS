using Com.HSJF.Infrastructure.DoMain;

namespace Com.HSJF.HATS.FrameWork.EntityFramework.Model.BaseAudit
{
    public class CollateralAudit : EntityModel
    {
        public string ID { get; set; }
        public string AuditID { get; set; }
        public string CollateralType { get; set; }
        public string HouseNumber { get; set; }
        public string HouseFile { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public string RightOwner { get; set; }
        public decimal? HouseSize { get; set; }

        //以下 2-16-06-16 第一次测试之后新增
        public string HouseReportFile { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        public virtual BaseAudit BaseAudit { get; set; }
    }
}